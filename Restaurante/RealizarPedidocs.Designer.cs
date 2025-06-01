namespace Restaurante
{
    partial class RealizarPedidocs
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
            this.flowLayoutPanelPedidos = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.TotalCusto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutPanelPedidos
            // 
            this.flowLayoutPanelPedidos.AutoScroll = true;
            this.flowLayoutPanelPedidos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flowLayoutPanelPedidos.Location = new System.Drawing.Point(456, 538);
            this.flowLayoutPanelPedidos.Name = "flowLayoutPanelPedidos";
            this.flowLayoutPanelPedidos.Size = new System.Drawing.Size(1221, 294);
            this.flowLayoutPanelPedidos.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 49.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(427, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 95);
            this.label1.TabIndex = 19;
            this.label1.Text = "Comidas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 49.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(440, 440);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(348, 95);
            this.label2.TabIndex = 20;
            this.label2.Text = "Bebidas";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(443, 123);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1221, 294);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // TotalCusto
            // 
            this.TotalCusto.AutoSize = true;
            this.TotalCusto.BackColor = System.Drawing.Color.White;
            this.TotalCusto.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.TotalCusto.Location = new System.Drawing.Point(1536, 858);
            this.TotalCusto.Name = "TotalCusto";
            this.TotalCusto.Size = new System.Drawing.Size(339, 58);
            this.TotalCusto.TabIndex = 22;
            this.TotalCusto.Text = "Total: R$ 0,00";
            // 
            // RealizarPedidocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.TotalCusto);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanelPedidos);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "RealizarPedidocs";
            this.Text = "RealizarPedidocs";
            this.Load += new System.EventHandler(this.RealizarPedidocs_Load);
            this.Controls.SetChildIndex(this.flowLayoutPanelPedidos, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.TotalCusto, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPedidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label TotalCusto;
    }
}