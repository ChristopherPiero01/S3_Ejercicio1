using System.Diagnostics.Eventing.Reader;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tipo = this.txtTipo.Text;
            int cantidadcajas = int.Parse(this.txtCajas.Text);
            decimal km = decimal.Parse(this.txtKm.Text);

            if (tipo == "Naranja" && km < 30)
            {
                double precio = cantidadcajas * 2;
                this.txtPrecio.Text = precio.ToString();
            }
            if (tipo == "Naranja" && km > 30)
            {
                double precio = cantidadcajas * 4;
                this.txtPrecio.Text= precio.ToString();
            }
            if (tipo == "Fresa" && km < 30)
            {
                double precio = cantidadcajas * 6;
                this.txtPrecio.Text = precio.ToString();
            }
            if (tipo == "Fresa" && km > 30)
            {
                double precio = cantidadcajas * 9;
                this.txtPrecio.Text = precio.ToString();
            }
            if (tipo == "Mango" && km < 30)
            {
                double precio = cantidadcajas * 3;
                this.txtPrecio.Text=precio.ToString();
            }
            if (tipo == "Mango" && km > 30)
            {
                double precio = cantidadcajas * 5;
                this.txtPrecio.Text = precio.ToString();
            }
        }
    }
}