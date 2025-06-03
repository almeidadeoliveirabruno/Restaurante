namespace Restaurante
{
    partial class VisualizarPedidos
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
            this.flowLayoutPedidos = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutPedidos
            // 
            this.flowLayoutPedidos.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.flowLayoutPedidos.Location = new System.Drawing.Point(57, 44);
            this.flowLayoutPedidos.Name = "flowLayoutPedidos";
            this.flowLayoutPedidos.Size = new System.Drawing.Size(1850, 818);
            this.flowLayoutPedidos.TabIndex = 0;
            // 
            // VisualizarPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.flowLayoutPedidos);
            this.Name = "VisualizarPedidos";
            this.Text = "VisualizarPedidos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VisualizarPedidos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPedidos;
    }
}