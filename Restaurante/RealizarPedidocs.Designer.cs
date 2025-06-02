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
            this.flowLayoutPanelBebidas = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanelComidas = new System.Windows.Forms.FlowLayoutPanel();
            this.TotalCusto = new System.Windows.Forms.Label();
            this.ClientesComBox = new System.Windows.Forms.ComboBox();
            this.MesaCombox = new System.Windows.Forms.ComboBox();
            this.Cliente = new System.Windows.Forms.Label();
            this.Mesa = new System.Windows.Forms.Label();
            this.Cadastrar = new System.Windows.Forms.Button();
            this.VisualizarPedidoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanelBebidas
            // 
            this.flowLayoutPanelBebidas.AutoScroll = true;
            this.flowLayoutPanelBebidas.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flowLayoutPanelBebidas.Location = new System.Drawing.Point(419, 497);
            this.flowLayoutPanelBebidas.Name = "flowLayoutPanelBebidas";
            this.flowLayoutPanelBebidas.Size = new System.Drawing.Size(1600, 294);
            this.flowLayoutPanelBebidas.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 49.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(427, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 95);
            this.label1.TabIndex = 19;
            this.label1.Text = "Comidas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 49.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(417, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(348, 95);
            this.label2.TabIndex = 20;
            this.label2.Text = "Bebidas";
            // 
            // flowLayoutPanelComidas
            // 
            this.flowLayoutPanelComidas.AutoScroll = true;
            this.flowLayoutPanelComidas.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flowLayoutPanelComidas.Location = new System.Drawing.Point(419, 102);
            this.flowLayoutPanelComidas.Name = "flowLayoutPanelComidas";
            this.flowLayoutPanelComidas.Size = new System.Drawing.Size(1600, 294);
            this.flowLayoutPanelComidas.TabIndex = 18;
            // 
            // TotalCusto
            // 
            this.TotalCusto.AutoSize = true;
            this.TotalCusto.BackColor = System.Drawing.Color.White;
            this.TotalCusto.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.TotalCusto.Location = new System.Drawing.Point(1648, 41);
            this.TotalCusto.Name = "TotalCusto";
            this.TotalCusto.Size = new System.Drawing.Size(339, 58);
            this.TotalCusto.TabIndex = 22;
            this.TotalCusto.Text = "Total: R$ 0,00";
            // 
            // ClientesComBox
            // 
            this.ClientesComBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ClientesComBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ClientesComBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientesComBox.FormattingEnabled = true;
            this.ClientesComBox.Location = new System.Drawing.Point(623, 797);
            this.ClientesComBox.Name = "ClientesComBox";
            this.ClientesComBox.Size = new System.Drawing.Size(1000, 50);
            this.ClientesComBox.Sorted = true;
            this.ClientesComBox.TabIndex = 23;
            // 
            // MesaCombox
            // 
            this.MesaCombox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.MesaCombox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.MesaCombox.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MesaCombox.FormattingEnabled = true;
            this.MesaCombox.Location = new System.Drawing.Point(623, 862);
            this.MesaCombox.Name = "MesaCombox";
            this.MesaCombox.Size = new System.Drawing.Size(250, 50);
            this.MesaCombox.Sorted = true;
            this.MesaCombox.TabIndex = 24;
            // 
            // Cliente
            // 
            this.Cliente.AutoSize = true;
            this.Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cliente.Location = new System.Drawing.Point(454, 800);
            this.Cliente.Name = "Cliente";
            this.Cliente.Size = new System.Drawing.Size(134, 42);
            this.Cliente.TabIndex = 25;
            this.Cliente.Text = "Cliente";
            // 
            // Mesa
            // 
            this.Mesa.AutoSize = true;
            this.Mesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.Mesa.Location = new System.Drawing.Point(454, 870);
            this.Mesa.Name = "Mesa";
            this.Mesa.Size = new System.Drawing.Size(110, 42);
            this.Mesa.TabIndex = 26;
            this.Mesa.Text = "Mesa";
            // 
            // Cadastrar
            // 
            this.Cadastrar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.Cadastrar.Location = new System.Drawing.Point(1540, 886);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(350, 75);
            this.Cadastrar.TabIndex = 29;
            this.Cadastrar.Text = "Realizar Pedido";
            this.Cadastrar.UseVisualStyleBackColor = false;
            this.Cadastrar.Click += new System.EventHandler(this.Cadastrar_Click);
            // 
            // VisualizarPedidoButton
            // 
            this.VisualizarPedidoButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.VisualizarPedidoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.VisualizarPedidoButton.Location = new System.Drawing.Point(1010, 886);
            this.VisualizarPedidoButton.Name = "VisualizarPedidoButton";
            this.VisualizarPedidoButton.Size = new System.Drawing.Size(450, 75);
            this.VisualizarPedidoButton.TabIndex = 30;
            this.VisualizarPedidoButton.Text = "Visualizar Pedidos";
            this.VisualizarPedidoButton.UseVisualStyleBackColor = false;
            this.VisualizarPedidoButton.Click += new System.EventHandler(this.VisualizarPedidoButton_Click);
            // 
            // RealizarPedidocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.VisualizarPedidoButton);
            this.Controls.Add(this.Cadastrar);
            this.Controls.Add(this.Mesa);
            this.Controls.Add(this.Cliente);
            this.Controls.Add(this.MesaCombox);
            this.Controls.Add(this.ClientesComBox);
            this.Controls.Add(this.TotalCusto);
            this.Controls.Add(this.flowLayoutPanelComidas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanelBebidas);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "RealizarPedidocs";
            this.Text = "RealizarPedidocs";
            this.Load += new System.EventHandler(this.RealizarPedidocs_Load);
            this.Controls.SetChildIndex(this.flowLayoutPanelBebidas, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.flowLayoutPanelComidas, 0);
            this.Controls.SetChildIndex(this.TotalCusto, 0);
            this.Controls.SetChildIndex(this.ClientesComBox, 0);
            this.Controls.SetChildIndex(this.MesaCombox, 0);
            this.Controls.SetChildIndex(this.Cliente, 0);
            this.Controls.SetChildIndex(this.Mesa, 0);
            this.Controls.SetChildIndex(this.Cadastrar, 0);
            this.Controls.SetChildIndex(this.VisualizarPedidoButton, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBebidas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelComidas;
        private System.Windows.Forms.Label TotalCusto;
        private System.Windows.Forms.ComboBox ClientesComBox;
        private System.Windows.Forms.ComboBox MesaCombox;
        private System.Windows.Forms.Label Cliente;
        private System.Windows.Forms.Label Mesa;
        private System.Windows.Forms.Button Cadastrar;
        private System.Windows.Forms.Button VisualizarPedidoButton;
    }
}