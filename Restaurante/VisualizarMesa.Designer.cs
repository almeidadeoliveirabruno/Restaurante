namespace Restaurante
{
    partial class VisualizarMesa
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
            this.flowLayoutPanelMesas = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutPanelMesas
            // 
            this.flowLayoutPanelMesas.Location = new System.Drawing.Point(624, 212);
            this.flowLayoutPanelMesas.Name = "flowLayoutPanelMesas";
            this.flowLayoutPanelMesas.Size = new System.Drawing.Size(1200, 500);
            this.flowLayoutPanelMesas.TabIndex = 17;
            // 
            // VisualizarMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1839, 768);
            this.Controls.Add(this.flowLayoutPanelMesas);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "VisualizarMesa";
            this.Text = "VisualizarMesacs";
            this.Controls.SetChildIndex(this.flowLayoutPanelMesas, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMesas;
    }
}