﻿namespace Restaurante
{
    partial class VisualizarEmpregados
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
            this.components = new System.ComponentModel.Container();
            this.repositorioEmpregadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.repositorioEmpregadoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.repositorioEmpregadoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.repositorioEmpregadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositorioEmpregadoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositorioEmpregadoBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // repositorioEmpregadoBindingSource
            // 
            this.repositorioEmpregadoBindingSource.DataSource = typeof(Restaurante.Models.RepositorioEmpregado);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(581, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1449, 428);
            this.dataGridView1.TabIndex = 17;
            // 
            // repositorioEmpregadoBindingSource1
            // 
            this.repositorioEmpregadoBindingSource1.DataSource = typeof(Restaurante.Models.RepositorioEmpregado);
            // 
            // repositorioEmpregadoBindingSource2
            // 
            this.repositorioEmpregadoBindingSource2.DataSource = typeof(Restaurante.Models.RepositorioEmpregado);
            // 
            // VisualizarEmpregados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.dataGridView1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "VisualizarEmpregados";
            this.Text = "VisualizarEmpregados";
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.repositorioEmpregadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositorioEmpregadoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositorioEmpregadoBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource repositorioEmpregadoBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource repositorioEmpregadoBindingSource1;
        private System.Windows.Forms.BindingSource repositorioEmpregadoBindingSource2;
    }
}