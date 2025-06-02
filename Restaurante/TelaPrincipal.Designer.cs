namespace Restaurante
{
    partial class TelaPrincipal
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
            this.Iniciar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.STACK = new System.Windows.Forms.Label();
            this.Overplate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Iniciar
            // 
            this.Iniciar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Iniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Iniciar.Location = new System.Drawing.Point(1426, 685);
            this.Iniciar.Name = "Iniciar";
            this.Iniciar.Size = new System.Drawing.Size(350, 150);
            this.Iniciar.TabIndex = 33;
            this.Iniciar.Text = "Iniciar ";
            this.Iniciar.UseVisualStyleBackColor = false;
            this.Iniciar.Click += new System.EventHandler(this.Iniciar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Restaurante.Properties.Resources.Pilhas_de_Pratos_Minimalistas;
            this.pictureBox1.Location = new System.Drawing.Point(42, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(994, 784);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // STACK
            // 
            this.STACK.AutoSize = true;
            this.STACK.BackColor = System.Drawing.Color.Transparent;
            this.STACK.Font = new System.Drawing.Font("Segoe UI Light", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STACK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.STACK.Location = new System.Drawing.Point(1088, 240);
            this.STACK.Name = "STACK";
            this.STACK.Size = new System.Drawing.Size(315, 159);
            this.STACK.TabIndex = 34;
            this.STACK.Text = "stack";
            // 
            // Overplate
            // 
            this.Overplate.AutoSize = true;
            this.Overplate.BackColor = System.Drawing.Color.Transparent;
            this.Overplate.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Overplate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Overplate.Location = new System.Drawing.Point(1088, 399);
            this.Overplate.Name = "Overplate";
            this.Overplate.Size = new System.Drawing.Size(602, 159);
            this.Overplate.TabIndex = 35;
            this.Overplate.Text = "overplate";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.Iniciar);
            this.panel1.Controls.Add(this.STACK);
            this.panel1.Controls.Add(this.Overplate);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(66, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1896, 878);
            this.panel1.TabIndex = 36;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1924, 1033);
            this.Controls.Add(this.panel1);
            this.Name = "TelaPrincipal";
            this.Text = "TelaPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Iniciar;
        private System.Windows.Forms.Label STACK;
        private System.Windows.Forms.Label Overplate;
        private System.Windows.Forms.Panel panel1;
    }
}