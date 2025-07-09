using Clases;
using ClasesGrafo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaClinica
{
    public partial class App : Form
    {
        Grafo grafo;
        public App()
        {
            InitializeComponent();
            grafo = new Grafo(cbInicio.Items.Count);
            label9.Text = DateTime.Now.ToString("dd/MM/yyyy");

            for (int i = 0; i < lugares.Length; i++)
            {
                grafo.insertar(i); // Agrega vertices al grafo  
            }

            grafo.llenarMatriz();
            grafo.crearGrafo();
            DistanciasGen();
        }

        ListDoble listaPacientes = new ListDoble();
        ColaPrioridad cola = new ColaPrioridad();
        Controller controller = new Controller();

        //lugares
        public string[] lugares = {
            "MegaPlaza",
            "RealPlaza",
            "UPN",
            "Ovalo Musical",
            "Recoleta",
            "Puente Amarillo",
            "Plaza de Armas"
        };

        //distancias de los lugares
        public string[,] distancias;

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            (bool validar, string mensaje) validacion = controller.validarCola(
                txtDNI.Text, txtNombres.Text, txtApellidos.Text, txtEdad.Text, txtSintomas.Text, cbEspecialidad.Text
            );
            if (!validacion.validar)
            {
                MessageBox.Show(validacion.mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!rbSi.Checked && !rbNo.Checked)
            {
                MessageBox.Show("Debe seleccionar si el paciente tiene prioridad.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cola.ExisteDNI(txtDNI.Text))
            {
                MessageBox.Show("Ya existe un paciente registrado con ese DNI.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string dni = txtDNI.Text.Trim();
            int edad = int.Parse(txtEdad.Text);
            string nombres = txtNombres.Text.Trim();
            string apellidos = txtApellidos.Text.Trim();
            string sintomas = txtSintomas.Text.Trim();
            string especialidad = cbEspecialidad.SelectedItem.ToString();
            bool prioridad = rbSi.Checked;
            
            Paciente nuevo = new Paciente(dni, prioridad, nombres, apellidos, sintomas, especialidad, edad);
            cola.Encolar(nuevo);

            cola.DataGrid(dgvCola);

            txtDNI.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtEdad.Clear();
            txtSintomas.Clear();
            cbEspecialidad.SelectedIndex = -1;
            rbSi.Checked = false;
            rbNo.Checked = false;

            MessageBox.Show("Paciente agregado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            if (dgvCola.Rows.Count == 0)
            {
                MessageBox.Show("No hay pacientes en la cola", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Paciente atendido = cola.Desencolar();
            cola.DataGrid(dgvCola);

            if (atendido != null)
            {
                MessageBox.Show("Paciente " + atendido.Nombres + " con DNI: " + atendido.DNI + " atendido.","Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            Paciente primero = cola.Peek();

            if (primero != null)
            {
                string datos = "DNI: " + primero.DNI + "\n" +
                               "Nombres: " + primero.Nombres + "\n" +
                               "Apellidos: " + primero.Apellidos + "\n" +
                               "Edad: " + primero.Edad + "\n" +
                               "Prioridad: " + (primero.Prioridad ? "Sí" : "No") + "\n" +
                               "Síntomas: " + primero.Sintomas + "\n" +
                               "Especialidad: " + primero.Especialidad;

                MessageBox.Show(datos, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Aun no hay pacientes en la cola", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            cola.Vaciar();
            dgvCola.Rows.Clear();
            MessageBox.Show("Se han vaciado todos los datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            int total = cola.Contar();
            MessageBox.Show("Hay " + total + " pacientes en cola", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnAgendarCita_Click(object sender, EventArgs e)
        {
            try
            {
                (bool validar, string mensaje) validacion = controller.validarListaDoble(
                 textDNI.Text, textNombre.Text, textApellido.Text, textDireccion.Text, textFechaCita.Text, 
                 textNumeroCelular.Text, textSintomas.Text, cbEspecialidadAgenda.Text
                );
                if (!validacion.validar)
                {
                    MessageBox.Show(validacion.mensaje, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                PacienteDoble nuevo = new PacienteDoble(
                    textDNI.Text,
                    textNombre.Text,
                    textApellido.Text,
                    textDireccion.Text,
                    textFechaCita.Text,
                    int.Parse(textNumeroCelular.Text), //parseamos para que acepte el parametro
                    textSintomas.Text,
                    cbEspecialidadAgenda.SelectedItem.ToString()
                );

                listaPacientes.Insertar(nuevo);
                MessageBox.Show("Cita agendada con éxito.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listaPacientes.CargarEnDataGrid(dgvListaDoble);
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Error al agendar cita: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizarLista_Click(object sender, EventArgs e)
        {
            listaPacientes.CargarEnDataGrid(dgvListaDoble);
            MessageBox.Show("Lista actualizada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLimpiarFormulario_Click(object sender, EventArgs e)
        {
            textDNI.Clear();
            textNombre.Clear();
            textApellido.Clear();
            textDireccion.Clear();
            textFechaCita.Clear();
            textNumeroCelular.Clear();
            textSintomas.Clear();
            cbEspecialidadAgenda.SelectedIndex = -1;
        }
        private void btnSubirCita_Click(object sender, EventArgs e)
        {
            //verifica si hay aguna celda seleccioanda 
            if (dgvListaDoble.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una cita para subir.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; //si no se tiene se referesa 
            }
            //se ubica en la fila 0 y cpluman 0 donde esta el DNi y lo gaurda en dni seleccioadno 
            string dniSeleccionado = dgvListaDoble.SelectedRows[0].Cells[0].Value.ToString(); 
            NodDoble nodoMov = listaPacientes.BuscarPorDNI(dniSeleccionado); //busca el dni en la lista de pacientes 

            if (nodoMov != null && nodoMov != listaPacientes.primero) //si lo ecnutea y si es que no esta en primer lugar sigue , si ya esra en primer lugar no se cumple lla condicion y pasa al else 
            {
                listaPacientes.MoverArriba(nodoMov); //cambia de posiciones 
                listaPacientes.CargarEnDataGrid(dgvListaDoble); //actualiza

                MessageBox.Show("Cita subida correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("La cita seleccionada ya está en la primera posición o no puede ser movida.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnBajarCita_Click(object sender, EventArgs e)
        {
            if (dgvListaDoble.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una cita para bajar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string dniSeleccionado = dgvListaDoble.SelectedRows[0].Cells[0].Value.ToString();
            NodDoble nodoMov = listaPacientes.BuscarPorDNI(dniSeleccionado);

            if (nodoMov != null && nodoMov != listaPacientes.ultimo)
            {
                listaPacientes.MoverAbajo(nodoMov);
                listaPacientes.CargarEnDataGrid(dgvListaDoble);
                MessageBox.Show("Cita bajada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("La cita seleccionada ya está en la última posición", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnCitaAtendida_Click(object sender, EventArgs e)
        {
            PacienteDoble atendido = listaPacientes.AtenderPrimero();

            if (atendido != null)
            {
                MessageBox.Show("Cita de " + atendido.Nombres + " " + atendido.Apellidos + " DNI:" + atendido.DNI + " ha sido atendida.", "Cita Atendida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listaPacientes.CargarEnDataGrid(dgvListaDoble); 
            }
            else
            {
                MessageBox.Show("No hay citas pendientes por atender.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBuscarDNI_Click(object sender, EventArgs e)
        {
            string dni = txtBuscarDNI.Text.Trim();

            if (string.IsNullOrEmpty(dni))
            {
                MessageBox.Show("El DNI no puede estar vacío.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dni.Length != 8 || !dni.All(char.IsDigit))
            {
                MessageBox.Show("El DNI debe tener 8 dígitos numéricos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            NodDoble resultado = listaPacientes.BuscarPorDNI(dni);

            if (resultado == null)
            {
                MessageBox.Show("No se encontró un registro con ese DNI.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dgvListaDoble.Rows.Clear();

            PacienteDoble p = resultado.dato;
            dgvListaDoble.Rows.Add(
                p.DNI,
                p.Nombres,
                p.Apellidos,
                p.Direccion,
                p.FechaCita,
                p.NumerodeCelular,
                p.Sintomas,
                p.Especialidad
            );

            MessageBox.Show("Registro encontrado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtBuscarDNI.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string dni = txtEliminarDNI.Text.Trim();
            if (string.IsNullOrEmpty(dni))
            {
                MessageBox.Show("El DNI no puede estar vacío.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dni.Length != 8 || !dni.All(char.IsDigit))
            {
                MessageBox.Show("El DNI debe tener exactamente 8 dígitos numéricos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!listaPacientes.ExisteDNI(dni))
            {
                MessageBox.Show("No se encontró un registro con ese DNI.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            listaPacientes.EliminarPorDNI(dni);
            listaPacientes.CargarEnDataGrid(dgvListaDoble);

            MessageBox.Show("Registro eliminado correctamente.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtEliminarDNI.Clear();
        }

        private void DistanciasGen()
        {
            int n = lugares.Length;
            distancias = new string[n, n];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    distancias[i, j] = "";

            Vertice actual = grafo.inicio_lista;
            for (int i = 0; i < n && actual != null; i++)
            {
                Arista tempArista = actual.lista_arista;
                while (tempArista != null)
                {
                    Vertice destino = tempArista.destino;
                    int j = 0;
                    Vertice temp = grafo.inicio_lista;
                    while (temp != null && temp != destino)
                    {
                        temp = temp.sig;
                        j++;
                    }

                    if (j < n)
                        distancias[i, j] = ((int)tempArista.costo).ToString();

                    tempArista = tempArista.sig;
                }
                actual = actual.sig;
            }
        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            (bool validar, string mensaje) validacion = controller.ValidarInfoGrafo(
                 txtNombresIns.Text, txtApellidosIns.Text, cbServicio.Text, cbRol.Text, cbInicio.Text);
            if (!validacion.validar)
            {
                MessageBox.Show(validacion.mensaje, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nombres = txtNombresIns.Text.Trim();
            string apellidos = txtApellidosIns.Text.Trim();
            string nombreCompleto = nombres + " " + apellidos;
            string servicio = cbServicio.SelectedItem.ToString();
            string rol = cbRol.SelectedItem.ToString();
            string lugarInicio = cbInicio.SelectedItem.ToString();
            MessageBox.Show("Se ha inscrito correctamente al encargado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtNombresIns.Clear();
            txtApellidosIns.Clear();
            cbServicio.SelectedIndex = -1;
            cbRol.SelectedIndex = -1;
            cbInicio.SelectedIndex = -1;

            int i = 0;
            while (i < cbInicio.Items.Count)
            {
                if (lugares[i] == lugarInicio)
                {
                    int j = 0;
                    while (j < cbInicio.Items.Count)
                    {
                        if (j != i && !string.IsNullOrWhiteSpace(distancias[i, j]))
                        {
                            string lugarDestino = lugares[j];
                            string distancia = distancias[i, j] + " km";

                            dgvGrafo.Rows.Add(
                                lugarDestino,
                                distancia,
                                servicio,
                                nombreCompleto,
                                rol
                            );
                        }
                        j++;
                    }
                    break;
                }
                i++;
            }
            //Para mostrar el lugar actual en el label encima de la tabla
            lblLugarActual.Text = "Lugar actual: " + lugarInicio;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            txtNombresIns.Clear();
            txtApellidosIns.Clear();
            cbServicio.SelectedIndex = -1;
            cbRol.SelectedIndex = -1;
            cbInicio.SelectedIndex = -1;
            dgvGrafo.Rows.Clear();
            MessageBox.Show("Inscripción cancelada correctamente.","Información",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnNavegar_Click(object sender, EventArgs e)
        {
            // validar si se selecciono una fila
            if (dgvGrafo.SelectedRows.Count == 0 || dgvGrafo.SelectedRows[0].Cells[0].Value == null)
            {
                MessageBox.Show("Seleccione una ruta válida en la tabla.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // obtener como string el lugar seleccionado
            string destino = dgvGrafo.SelectedRows[0].Cells[0].Value.ToString();

            // validar que el lugar al que se quiere ir exista en la lista de lugares al principio
            if (!lugares.Contains(destino))
            {
                MessageBox.Show("El lugar seleccionado no es válido.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // actualizar label que muestra el lugar actual
            lblLugarActual.Text = "Lugar actual: " + destino;

            // primero limpiar el datagrid
            dgvGrafo.Rows.Clear();

            //mostrar las nuevos lugares
            int indiceLugar = Array.IndexOf(lugares, destino);
            for (int i = 0; i < lugares.Length; i++)
            {
                if (i != indiceLugar && !string.IsNullOrWhiteSpace(distancias[indiceLugar, i]))
                {
                    int distancia = int.Parse(distancias[indiceLugar, i]);
                    dgvGrafo.Rows.Add(lugares[i], distancia + " km");
                }
            }
        }
    }
}
