namespace PuntoDeVenta
{
    partial class Input
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.subtotal = new System.Windows.Forms.Label();
            this.iva = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pagado = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.regresar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empresa S.A de C.V.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "00/00/2000";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "RFC: XXXX00000000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Subtotal:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "IVA:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total:";
            // 
            // subtotal
            // 
            this.subtotal.AutoSize = true;
            this.subtotal.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotal.Location = new System.Drawing.Point(249, 242);
            this.subtotal.Name = "subtotal";
            this.subtotal.Size = new System.Drawing.Size(48, 17);
            this.subtotal.TabIndex = 6;
            this.subtotal.Text = "0.00";
            // 
            // iva
            // 
            this.iva.AutoSize = true;
            this.iva.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iva.Location = new System.Drawing.Point(249, 283);
            this.iva.Name = "iva";
            this.iva.Size = new System.Drawing.Size(48, 17);
            this.iva.TabIndex = 7;
            this.iva.Text = "0.00";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(249, 328);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(48, 17);
            this.total.TabIndex = 8;
            this.total.Text = "0.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 389);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Dinero Recibido:";
            // 
            // pagado
            // 
            this.pagado.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagado.Location = new System.Drawing.Point(223, 386);
            this.pagado.Name = "pagado";
            this.pagado.Size = new System.Drawing.Size(138, 24);
            this.pagado.TabIndex = 10;
            this.pagado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.pagado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pagado_KeyDown);
            this.pagado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Pagado_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 449);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(188, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Dinero a devolver:";
            // 
            // regresar
            // 
            this.regresar.AutoSize = true;
            this.regresar.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regresar.Location = new System.Drawing.Point(249, 449);
            this.regresar.Name = "regresar";
            this.regresar.Size = new System.Drawing.Size(48, 17);
            this.regresar.TabIndex = 12;
            this.regresar.Text = "0.00";
            // 
            // Input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 749);
            this.Controls.Add(this.regresar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pagado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.total);
            this.Controls.Add(this.iva);
            this.Controls.Add(this.subtotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Input";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagar";
            this.Load += new System.EventHandler(this.Input_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label subtotal;
        private System.Windows.Forms.Label iva;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox pagado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label regresar;
    }
}