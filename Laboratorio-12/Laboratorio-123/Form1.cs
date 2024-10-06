namespace Laboratorio_123
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void semiperbtn_Click(object sender, EventArgs e)
        {
            double ladoA = double.Parse(ladoabox.Text);
            double ladoB = double.Parse(ladobbox.Text);
            double ladoC = double.Parse(ladocbox.Text);

            Calculos calculo = new Calculos();

            double semiperim = calculo.SemiPerimetro(ladoA, ladoB, ladoC);
            semiperbox.Text = semiperim.ToString("F2");
        }

        private void areabtn_Click(object sender, EventArgs e)
        {
            double ladoA = double.Parse(ladoabox.Text);
            double ladoB = double.Parse(ladobbox.Text);
            double ladoC = double.Parse(ladocbox.Text);

            Calculos calculo = new Calculos();

            double area = calculo.AreaTriangulo(ladoA, ladoB, ladoC);
            areabox.Text = area.ToString("F2");

        }

        private void borrarbtn_Click(object sender, EventArgs e)
        {
            ladocbox.Text = string.Empty;
            ladoabox.Text = string.Empty;
            ladobbox.Text = string.Empty;
            areabox.Text = string.Empty;
            semiperbox.Text = string.Empty;

        }

        private void salirbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
