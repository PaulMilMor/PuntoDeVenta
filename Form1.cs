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
    }
}
