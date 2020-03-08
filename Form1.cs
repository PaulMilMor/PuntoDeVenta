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

        private void total()
        {
            float total = 0.0f;
            for(int i = 0; i< dataGridView1.Rows.Count; i++)
            {
                total += float.Parse(dataGridView1[3, i].Value.ToString());

            }
            label3.Text = "Total = " + total;
            textBox1.Clear();
            textBox1.Focus();
        }

        private void buscarProductos()
        {
            if (textBox1.Text.IndexOf('*') != -1)
            {
                String[] sarray = textBox1.Text.Split('*');
                for (int i = 0; i < productos.GetUpperBound(0)+1; i++)
                {
                    if (sarray[1] == productos[i, 0])
                    {
                        dataGridView1.Rows.Add(productos[i,2], productos[i, 1], sarray[0], float.Parse(productos[i, 2]) * float.Parse(sarray[0]));
                        total();
                    }
                }
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    if (textBox1.Text == productos[i, 0])
                    {
                        dataGridView1.Rows.Add(productos[i,2], productos[i, 1],"1",productos[i, 2]);
                        total();
                    }
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
            label3.Text = "Total =";
            label3.Location = new Point(this.Width-dataGridView1.Columns[3].Width, label1.Height + label2.Height + dataGridView1.Height + 35);

        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buscarProductos();
            }
            if(e.KeyCode  == Keys.Escape)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 1);

            }
            if (e.KeyCode == Keys.P)
            {
                MessageBox.Show("Vas a pagar");
            }
        }
    }
}
