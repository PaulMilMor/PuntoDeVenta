using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVenta
{
    public partial class Input : Form
    {
        public Input(float subcash, float ivacash, float totcash)
        {
            InitializeComponent();
            subtotal.Text = subcash.ToString("0.00");
            iva.Text = ivacash.ToString("0.00");
            total.Text = totcash.ToString("0.00");

        }

        private void Input_Load(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongDateString();
            
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Pagado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Pagado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {   
                if(regresar.Text == "0.00")
                {
                    if (string.IsNullOrWhiteSpace(pagado.Text))
                    {
                        error.Visible = true;
                    }
                    else
                    {
                        float reccash = float.Parse(pagado.Text);
                        if (reccash < float.Parse(total.Text))
                        {
                            error.Visible = true;
                        }
                        else
                        {

                            regresar.Text = "$" + (reccash - float.Parse(total.Text));
                            placeholder.Text = "Presione Enter para cerrar.";
                            error.Visible = false;

                        }
                    }
                    
                }
                else
                {
                    this.Close();
                }


            }
        }
    }
}
