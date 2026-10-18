namespace CalcularNomina
{
    public partial class txtDevengado : Form
    {
        Empleado myEmpleado = new Empleado();
        Nomina myNomina = new Nomina();
        public TextBox txIdentificacion;
        public TextBox txtNombre;
        public TextBox txtAsignacionDia;
        private TextBox txtIdentificacion;

        public txtDevengado()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcularsalario_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Empleado GetMyEmpleado1()
        {
            return myEmpleado;
        }

        private void btnAlmacenaregistro_Click(object sender, EventArgs e, Empleado myEmpleado
        {
            myEmpleado.Nombre = txtNombre.Text;
            mythis.Empleado.Identificacion = txtIdentificacion.Text;
            mythis.Empleado.AsignacionDia = Convert.ToDecimal(txtAsignacionDia.Text);
            myNomina.DiasLaborados = Convert.ToInt32(txtDiasLaborados.Text);
            MessageBox.Show("Se guardo el regiatro correctamente");
        }


    }
}
