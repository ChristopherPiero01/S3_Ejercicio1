namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtTipo = new TextBox();
            txtCajas = new TextBox();
            txtKm = new TextBox();
            button1 = new Button();
            txtPrecio = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 37);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 0;
            label1.Text = "Tipo de fruta:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 86);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 1;
            label2.Text = "Número de cajas:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 134);
            label3.Name = "label3";
            label3.Size = new Size(120, 15);
            label3.TabIndex = 2;
            label3.Text = "Kilometros a recorrer:";
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(179, 34);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(100, 23);
            txtTipo.TabIndex = 3;
            // 
            // txtCajas
            // 
            txtCajas.Location = new Point(179, 83);
            txtCajas.Name = "txtCajas";
            txtCajas.Size = new Size(100, 23);
            txtCajas.TabIndex = 4;
            // 
            // txtKm
            // 
            txtKm.Location = new Point(179, 131);
            txtKm.Name = "txtKm";
            txtKm.Size = new Size(100, 23);
            txtKm.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(109, 183);
            button1.Name = "button1";
            button1.Size = new Size(232, 46);
            button1.TabIndex = 6;
            button1.Text = "Calcular el precio";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(179, 262);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 270);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 8;
            label4.Text = "Precio de viaje:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(txtPrecio);
            Controls.Add(button1);
            Controls.Add(txtKm);
            Controls.Add(txtCajas);
            Controls.Add(txtTipo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtTipo;
        private TextBox txtCajas;
        private TextBox txtKm;
        private Button button1;
        private TextBox txtPrecio;
        private Label label4;
    }
}