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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutPanelMesas
            // 
            this.flowLayoutPanelMesas.Location = new System.Drawing.Point(506, 91);
            this.flowLayoutPanelMesas.Name = "flowLayoutPanelMesas";
            this.flowLayoutPanelMesas.Size = new System.Drawing.Size(1200, 500);
            this.flowLayoutPanelMesas.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(494, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(543, 69);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mesas Disponiveis";
            // 
            // VisualizarMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1839, 768);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanelMesas);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "VisualizarMesa";
            this.Text = "VisualizarMesacs";
            this.Controls.SetChildIndex(this.flowLayoutPanelMesas, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMesas;
        private System.Windows.Forms.Label label1;
    }
}