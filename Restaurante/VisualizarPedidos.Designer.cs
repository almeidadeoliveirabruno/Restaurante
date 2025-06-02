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
            this.PedidosDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PedidosDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // PedidosDataGrid
            // 
            this.PedidosDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PedidosDataGrid.Location = new System.Drawing.Point(531, 50);
            this.PedidosDataGrid.Name = "PedidosDataGrid";
            this.PedidosDataGrid.RowHeadersWidth = 51;
            this.PedidosDataGrid.RowTemplate.Height = 24;
            this.PedidosDataGrid.Size = new System.Drawing.Size(780, 426);
            this.PedidosDataGrid.TabIndex = 0;
            // 
            // VisualizarPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.PedidosDataGrid);
            this.Name = "VisualizarPedidos";
            this.Text = "VisualizarPedidos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VisualizarPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PedidosDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PedidosDataGrid;
    }
}