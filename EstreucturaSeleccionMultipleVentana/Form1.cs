namespace EstreucturaSeleccionMultipleVentana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbfrutas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fruta = int.Parse(cmbfrutas.SelectedItem.ToString());
            float km = float.Parse(txtkm.Text);
            switch (fruta)
            {

                case 1:
                    if (km < 30)
                    {
                        fruta = 2;

                    }
                    else
                    {
                        fruta = 4;
                    }
                    break;

                case 2:
                    if (km < 30)
                    {
                        fruta = 6;

                    }
                    else
                    {
                        fruta = 9;
                    }
                    break;

                case 3:
                    if (km < 30)
                    {
                        fruta = 3;

                    }
                    else
                    {
                        fruta = 5;
                    }
                    break;

                default:


                    break;

            }

            lblresultado.Text = "El total es : " + fruta + " soles";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
        
        txtkm.Clear();
        lblresultado.Text = string.Empty;
        }
    }
}