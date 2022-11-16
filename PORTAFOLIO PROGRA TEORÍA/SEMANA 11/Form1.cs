namespace S11_01_JMML_1308819
{
    public partial class Form1 : Form
    {
        //Variables Globales
        cFormulario objFormulario = new cFormulario();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre, nacionalidad, genero, carrera;
            int edad;
            //Obteniendo valores del formulario y asignandolo a variables.
            nombre = TxtNombre.Text;
            nacionalidad = textBox2.Text;
            genero = textBox3.Text;
            carrera = comboBox1.Text;
            edad = int.Parse(textBox1.Text);
            //MessageBox.Show("El nombre ingresado es: " + nombre);
            // Mandar valores a la clase (se utiliza metodo set de la clase)
            objFormulario.setNombre(nombre);
            objFormulario.setNacionalidad(nacionalidad);
            objFormulario.setGenero(genero);
            objFormulario.setCarrera(carrera);
            objFormulario.setEdad(edad); 
            //label2.Text = nombre;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El nombre ingresado es: " + objFormulario.getNombre());
            MessageBox.Show("La Nacionalidad ingresada es: " + objFormulario.getNacionalidad());
            MessageBox.Show("El Género ingresado es: " + objFormulario.getGenero());  
            MessageBox.Show("La carrera seleccionada es: " + objFormulario.getCarrera());
            MessageBox.Show("La edad ingresada es de: " + objFormulario.getEdad());
        }
    }
}