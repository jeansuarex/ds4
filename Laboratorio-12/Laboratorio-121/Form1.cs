namespace Laboratorio_121
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void box_velocidad_TextChanged(object sender, EventArgs e)
        {
        }

        private void box_tiempo_TextChanged(object sender, EventArgs e)
        {
        }

        private void respuesta_box_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double velocidad = double.Parse(box_velocidad.Text);
                double tiempo = double.Parse(box_tiempo.Text);

                Calculo calculo = new Calculo();

                double distancia = calculo.CalcularDistancia(velocidad, tiempo);

                respuesta_box.Text = distancia.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa valores numéricos válidos.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
