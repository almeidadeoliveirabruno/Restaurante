namespace Restaurante
{
    partial class PedidosControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblId = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblprecoTotal = new System.Windows.Forms.Label();
            this.lblTempoEstimado = new System.Windows.Forms.Label();
            this.lblMesa = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.Comida = new System.Windows.Forms.Label();
            this.Bebida = new System.Windows.Forms.Label();
            this.lblComida = new System.Windows.Forms.Label();
            this.lblBebida = new System.Windows.Forms.Label();
            this.lblGarcom = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblId.Location = new System.Drawing.Point(12, 10);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(112, 46);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "LblID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.lblGarcom);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblprecoTotal);
            this.panel1.Controls.Add(this.lblTempoEstimado);
            this.panel1.Controls.Add(this.lblMesa);
            this.panel1.Controls.Add(this.lblId);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 385);
            this.panel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 83);
            this.button1.TabIndex = 12;
            this.button1.Text = "Status Pedido: Em Aberto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Location = new System.Drawing.Point(846, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1010, 319);
            this.panel2.TabIndex = 11;
            // 
            // lblprecoTotal
            // 
            this.lblprecoTotal.AutoSize = true;
            this.lblprecoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblprecoTotal.Location = new System.Drawing.Point(12, 250);
            this.lblprecoTotal.Name = "lblprecoTotal";
            this.lblprecoTotal.Size = new System.Drawing.Size(255, 46);
            this.lblprecoTotal.TabIndex = 10;
            this.lblprecoTotal.Text = "lblPrecoTotal";
            // 
            // lblTempoEstimado
            // 
            this.lblTempoEstimado.AutoSize = true;
            this.lblTempoEstimado.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblTempoEstimado.Location = new System.Drawing.Point(12, 190);
            this.lblTempoEstimado.Name = "lblTempoEstimado";
            this.lblTempoEstimado.Size = new System.Drawing.Size(333, 46);
            this.lblTempoEstimado.TabIndex = 7;
            this.lblTempoEstimado.Text = "Tempo Estimado:";
            // 
            // lblMesa
            // 
            this.lblMesa.AutoSize = true;
            this.lblMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblMesa.Location = new System.Drawing.Point(12, 130);
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Size = new System.Drawing.Size(128, 46);
            this.lblMesa.TabIndex = 6;
            this.lblMesa.Text = "Mesa:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblNome.Location = new System.Drawing.Point(12, 70);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(138, 46);
            this.lblNome.TabIndex = 5;
            this.lblNome.Text = "Nome:";
            // 
            // Comida
            // 
            this.Comida.AutoSize = true;
            this.Comida.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.Comida.Location = new System.Drawing.Point(853, 0);
            this.Comida.Name = "Comida";
            this.Comida.Size = new System.Drawing.Size(189, 46);
            this.Comida.TabIndex = 11;
            this.Comida.Text = "Comidas:";
            // 
            // Bebida
            // 
            this.Bebida.AutoSize = true;
            this.Bebida.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.Bebida.Location = new System.Drawing.Point(1366, 0);
            this.Bebida.Name = "Bebida";
            this.Bebida.Size = new System.Drawing.Size(175, 46);
            this.Bebida.TabIndex = 12;
            this.Bebida.Text = "Bebidas:";
            // 
            // lblComida
            // 
            this.lblComida.AutoSize = true;
            this.lblComida.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblComida.Location = new System.Drawing.Point(853, 46);
            this.lblComida.Name = "lblComida";
            this.lblComida.Size = new System.Drawing.Size(86, 46);
            this.lblComida.TabIndex = 13;
            this.lblComida.Text = "Info";
            // 
            // lblBebida
            // 
            this.lblBebida.AutoSize = true;
            this.lblBebida.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblBebida.Location = new System.Drawing.Point(1366, 46);
            this.lblBebida.Name = "lblBebida";
            this.lblBebida.Size = new System.Drawing.Size(86, 46);
            this.lblBebida.TabIndex = 14;
            this.lblBebida.Text = "Info";
            // 
            // lblGarcom
            // 
            this.lblGarcom.AutoSize = true;
            this.lblGarcom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblGarcom.Location = new System.Drawing.Point(299, 333);
            this.lblGarcom.Name = "lblGarcom";
            this.lblGarcom.Size = new System.Drawing.Size(103, 29);
            this.lblGarcom.TabIndex = 13;
            this.lblGarcom.Text = "Garçom";
            // 
            // PedidosControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblBebida);
            this.Controls.Add(this.lblComida);
            this.Controls.Add(this.Bebida);
            this.Controls.Add(this.Comida);
            this.Controls.Add(this.panel1);
            this.Name = "PedidosControl";
            this.Size = new System.Drawing.Size(1866, 382);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMesa;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTempoEstimado;
        private System.Windows.Forms.Label lblprecoTotal;
        private System.Windows.Forms.Label Comida;
        private System.Windows.Forms.Label Bebida;
        private System.Windows.Forms.Label lblComida;
        private System.Windows.Forms.Label lblBebida;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblGarcom;
    }
}
