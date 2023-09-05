namespace S3_Ejercicio01_ventana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fruta = int.Parse(txtfruta.Text);
            float caja = float.Parse(txtcaja.Text);
            float dist = float.Parse(txtdist.Text);
            float precio = 0.00f;

            if (dist < 30f)
            {
                switch (fruta)
                {
                    case 1:
                        precio = 2.00f;
                        break;
                    case 2:
                        precio = 6.00f;
                        break;
                    case 3:
                        precio = 3.00f;
                        break;
                }
            }
            else
            {
                switch (fruta)
                {
                    case 1:
                        precio = 4.00f;
                        break;
                    case 2:
                        precio = 9.00f;
                        break;
                    case 3:
                        precio = 5.00f;
                        break;
                }
            }
            precio *= caja;
            lblresult.Text = "el precio es: " + precio;
        }
    }
}