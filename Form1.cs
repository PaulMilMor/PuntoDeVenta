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
    public partial class Form1 : Form
    {
        private String[,] productos =
        {
            {"1","Burro","100" },
            {"2","Hot dog","60" },
            {"3","Ensalada","130" },
            {"4","Boneless","120" },
            {"5","Hamburguesa","110" }
        };

        private void buscarProductos()
        {
            
            for(int i =0; i < 5; i++)
            {
                if (textBox1.Text == productos[i,0])
                {
                    dataGridView1.Rows.Add("1", productos[i,1]);
                }
            }

        }
        public Form1()
        {
            InitializeComponent();
            
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Location = new Point((this.Width / 2) - label1.Width / 2, 5);
            label2.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
            label2.Location = new Point((this.Width / 2) - label2.Width / 2, label1.Height + 10);
            dataGridView1.Width = this.Width - 20;
            dataGridView1.Height = this.Height * 3 / 4;
            dataGridView1.Location = new Point(10, label2.Height + label1.Height + 25);
            textBox1.Width = this.Width;
            textBox1.Location = new Point(0, this.Height - textBox1.Height);

        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buscarProductos();
            }
        }
    }
}
