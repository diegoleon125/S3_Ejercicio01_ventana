namespace S3_Ejercicio01_ventana
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
            label4 = new Label();
            label5 = new Label();
            txtfruta = new TextBox();
            txtdist = new TextBox();
            button1 = new Button();
            lblresult = new Label();
            label6 = new Label();
            txtcaja = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 17);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese fruta:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 32);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 1;
            label2.Text = "(1) Naranja";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 47);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "(2) Fresa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 62);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 3;
            label4.Text = "(3) Mango";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 135);
            label5.Name = "label5";
            label5.Size = new Size(94, 15);
            label5.TabIndex = 4;
            label5.Text = "Distancia en km:";
            // 
            // txtfruta
            // 
            txtfruta.Location = new Point(136, 14);
            txtfruta.Name = "txtfruta";
            txtfruta.Size = new Size(43, 23);
            txtfruta.TabIndex = 5;
            // 
            // txtdist
            // 
            txtdist.Location = new Point(136, 132);
            txtdist.Name = "txtdist";
            txtdist.Size = new Size(100, 23);
            txtdist.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(104, 164);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblresult
            // 
            lblresult.AutoSize = true;
            lblresult.Location = new Point(45, 202);
            lblresult.Name = "lblresult";
            lblresult.Size = new Size(75, 15);
            lblresult.TabIndex = 8;
            lblresult.Text = "El precio es...";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(58, 102);
            label6.Name = "label6";
            label6.Size = new Size(103, 15);
            label6.TabIndex = 9;
            label6.Text = "Cantidad de cajas:";
            // 
            // txtcaja
            // 
            txtcaja.Location = new Point(167, 99);
            txtcaja.Name = "txtcaja";
            txtcaja.Size = new Size(79, 23);
            txtcaja.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 259);
            Controls.Add(txtcaja);
            Controls.Add(label6);
            Controls.Add(lblresult);
            Controls.Add(button1);
            Controls.Add(txtdist);
            Controls.Add(txtfruta);
            Controls.Add(label5);
            Controls.Add(label4);
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
        private Label label4;
        private Label label5;
        private TextBox txtfruta;
        private TextBox txtdist;
        private Button button1;
        private Label lblresult;
        private Label label6;
        private TextBox txtcaja;
    }
}