using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryHerreraSP3
{
    public partial class frmAutoTest : Form
    {
        // declaración de la estructura para los turnos
        public struct TURNO
        {
            public int NumeroTurno;
            public string Dominio;
            public int AnioFabricacion;
            public string Titular;
        };
        // constante para la cantidad total de elementos del arreglo
        const int MAX = 50;
        // declaración del arreglo unidimensional de 50 elementos
        public TURNO[] turnos;
        // variable para controlar la cantidad de elementos cargados
        public int Cantidad = 0;

        private void limpiarControles()
        {
            // valores para el estado inicial de los controles de carga
            txtNroTurno.Clear();
            txtDominio.Clear();
            numAnioFabricacion.Value = 2022;
            txtTitular.Clear();
        }

        private void inicializarInterfaz()
        {
            limpiarControles(); // estado inicial de los controles de carga de datos
                                // estado inicial de los controles de consultas
            txtCantidadTurnos.Clear();
            txtAnioMasAntiguo.Clear();
            txtDominio6Caracteres.Clear();
        }

        private bool validarDatos()
        {
            bool resultado = false; // valor a devolver si no se cumplen todas las condiciones
            // validar la existencia de los datos a ingresar
            if (txtNroTurno.Text != "" && txtDominio.Text != "" && txtTitular.Text != "")
            {
                if (txtDominio.Text.Length >= 6) // validar el contenido del Dominio
                {
                    // validar que NO exista el número de turno a cargar
                    if (!buscarTurno(int.Parse(txtNroTurno.Text)))
                    {
                        resultado = true; // si todo está bien devuelve verdadero
                    }
                    else
                    {
                        MessageBox.Show("El Número de Turno ingresado ya existe",
                        "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El Dominio debe tener 6 o 7 caracteres",
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe completar los datos faltantes", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return resultado;
        }


        // función para buscar un número de turno en el arreglo de turnos
        // recibe por parámetro el número a buscar
        // devuelve verdadero si el número existe en el arreglo y falso en caso contrario
        private bool buscarTurno(int numero)
        {
            bool existe = false; // valor inicial a devolver
            int pos = 0; // primera posición del arreglo
                         // recorrer el arreglo hasta la posición que tenga datos cargados
            while (pos < Cantidad)
            {
                // comparar el número buscado con el número en el arreglo
                if (numero == turnos[pos].NumeroTurno)
                {
                    existe = true; // indica que el número fue encontrado
                    break; // sale del ciclo while
                }
                pos++; // próxima posición del arreglo
            }
            return existe; // devuelve verdadero o falso
        }

        public frmAutoTest()
        {
            InitializeComponent();
        }

        private void frmAutoTest_Load(object sender, EventArgs e)
        {
            // creación del arreglo
            turnos = new TURNO[MAX];
            // inicializar la variable que controla la cantidad de elementos cargados
            Cantidad = 0;
            // establecer el estado inicial de todos los componentes de la interfaz
            inicializarInterfaz();
        }

        private void txtNroTurno_KeyPress(object sender, KeyPressEventArgs e)
        {
            // sin NO es un dígito y NO es Backspace (para borrar)
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true; // borrar la tecla ingresada
            }
        }

        private void txtDominio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // usamos los métodos de la clase 'Char', (IsLower y ToUpper)
            if (Char.IsLower(e.KeyChar)) // es una minúscula ?
            {
                e.KeyChar = Char.ToUpper(e.KeyChar); // convertir a mayúscula
            }
            // no es ni letra ni número y es distinto de Backspace ?
            if (!Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // borrar la tecla
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // validar los datos antes de ingresarlos al arreglo
            if (validarDatos())
            {
                // agregar los datos al arreglo en la posición indicada por
                // la variable 'Cantidad'
                turnos[Cantidad].NumeroTurno = int.Parse(txtNroTurno.Text);
                turnos[Cantidad].Dominio = txtDominio.Text;
                turnos[Cantidad].AnioFabricacion = int.Parse(numAnioFabricacion.Value.ToString());
                turnos[Cantidad].Titular = txtTitular.Text;
                // incrementar la cantidad de elementos cargados
                Cantidad++;
                // verificar si queda espacio en el arreglo
                if (Cantidad == MAX)
                {
                    MessageBox.Show("Se completó la capacidad de carga de datos",
                    "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    btnRegistrar.Enabled = false; // deshabilitar el botón Registrar
                }
                limpiarControles(); // restablecer el estado inicial del formulario
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            // primer consulta: cantidad de turnos registrados
            // se obtiene directamente de la variable 'Cantidad'
            txtCantidadTurnos.Text = Cantidad.ToString();

            // segunda consulta: se debe recorrer el arreglo y determinar
            // el menor valor del campo 'AnioFabricacion'
            int menor = int.MaxValue; // mayor valor posible
            int pos;
            // recorrer el arreglo hasta la posición con datos
            for (pos = 0; pos < Cantidad; pos++)
            {
                // comparar el valor del elemento en el arreglo
                if (turnos[pos].AnioFabricacion < menor)
                {
                    menor = turnos[pos].AnioFabricacion; // guarda el menor valor
                }
            }
            // mostrar el resultado
            txtAnioMasAntiguo.Text = menor.ToString();

            // tercera consulta: cantidad de vehículos con dominio de 6 caracteres
            int contador = 0; // contador en cero
                              // recorrer el arreglo hasta la posición con datos
            for (pos = 0; pos < Cantidad; pos++)
            {
                // controlar si la longitud del dominio es 6
                if (turnos[pos].Dominio.Length == 6)
                {
                    contador++; // incrementar el contador
                }
            }
            // mostrar el resultado
            txtDominio6Caracteres.Text = contador.ToString();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close(); // cierra el formulario
        }
    }
}
  