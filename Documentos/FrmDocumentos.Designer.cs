﻿namespace Documentos
{
    partial class FrmDocumentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDocumentos));
            toolStrip1 = new ToolStrip();
            btnOrdenar = new ToolStripButton();
            btnOrdenarRapido = new ToolStripButton();
            cmbCriterio = new ToolStripComboBox();
            txtTiempo = new ToolStripTextBox();
            btnOrdenarInsercion = new ToolStripButton();
            btnOrdenarMezcla = new ToolStripButton();
            dgvDocumentos = new DataGridView();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDocumentos).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnOrdenar, btnOrdenarRapido, cmbCriterio, txtTiempo, btnOrdenarInsercion, btnOrdenarMezcla });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(701, 55);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnOrdenar
            // 
            btnOrdenar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnOrdenar.Image = Properties.Resources.Ordenar;
            btnOrdenar.ImageScaling = ToolStripItemImageScaling.None;
            btnOrdenar.ImageTransparentColor = Color.Magenta;
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(52, 52);
            btnOrdenar.ToolTipText = "Ordenar Burbuja";
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // btnOrdenarRapido
            // 
            btnOrdenarRapido.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnOrdenarRapido.Image = Properties.Resources.OrdenarRapido;
            btnOrdenarRapido.ImageScaling = ToolStripItemImageScaling.None;
            btnOrdenarRapido.ImageTransparentColor = Color.Magenta;
            btnOrdenarRapido.Name = "btnOrdenarRapido";
            btnOrdenarRapido.Size = new Size(52, 52);
            btnOrdenarRapido.Text = "toolStripButton1";
            btnOrdenarRapido.ToolTipText = "Ordenar Rapido";
            btnOrdenarRapido.Click += btnOrdenarRapido_Click;
            // 
            // cmbCriterio
            // 
            cmbCriterio.Items.AddRange(new object[] { "primero NOMBRE COMPLETO luego DOCUMENTO", "primero DOCUMENTO luego NOMBRE COMPLETO" });
            cmbCriterio.Name = "cmbCriterio";
            cmbCriterio.Size = new Size(263, 55);
            cmbCriterio.ToolTipText = "Criterio de Ordenamiento";
            // 
            // txtTiempo
            // 
            txtTiempo.Name = "txtTiempo";
            txtTiempo.Size = new Size(100, 55);
            // 
            // btnOrdenarInsercion
            // 
            btnOrdenarInsercion.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnOrdenarInsercion.Image = (Image)resources.GetObject("btnOrdenarInsercion.Image");
            btnOrdenarInsercion.ImageScaling = ToolStripItemImageScaling.None;
            btnOrdenarInsercion.ImageTransparentColor = Color.Magenta;
            btnOrdenarInsercion.Name = "btnOrdenarInsercion";
            btnOrdenarInsercion.Size = new Size(52, 52);
            btnOrdenarInsercion.Text = "toolStripButton1";
            btnOrdenarInsercion.ToolTipText = "Ordenar por inserción";
            btnOrdenarInsercion.Click += btnOrdenarInsercion_Click;
            // 
            // btnOrdenarMezcla
            // 
            btnOrdenarMezcla.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnOrdenarMezcla.Image = (Image)resources.GetObject("btnOrdenarMezcla.Image");
            btnOrdenarMezcla.ImageScaling = ToolStripItemImageScaling.None;
            btnOrdenarMezcla.ImageTransparentColor = Color.Magenta;
            btnOrdenarMezcla.Name = "btnOrdenarMezcla";
            btnOrdenarMezcla.Size = new Size(52, 52);
            btnOrdenarMezcla.Text = "toolStripButton1";
            btnOrdenarMezcla.ToolTipText = "Prdenar por Mezcla";
            btnOrdenarMezcla.Click += btnOrdenarMezcla_Click;
            // 
            // dgvDocumentos
            // 
            dgvDocumentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocumentos.Dock = DockStyle.Fill;
            dgvDocumentos.Location = new Point(0, 55);
            dgvDocumentos.Margin = new Padding(3, 2, 3, 2);
            dgvDocumentos.Name = "dgvDocumentos";
            dgvDocumentos.RowHeadersWidth = 51;
            dgvDocumentos.Size = new Size(701, 463);
            dgvDocumentos.TabIndex = 1;
            // 
            // FrmDocumentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 518);
            Controls.Add(dgvDocumentos);
            Controls.Add(toolStrip1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmDocumentos";
            Text = "Documentos para Créditos";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDocumentos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnOrdenar;
        private DataGridView dgvDocumentos;
        private ToolStripButton btnOrdenarRapido;
        private ToolStripComboBox cmbCriterio;
        private ToolStripTextBox txtTiempo;
        private ToolStripButton btnOrdenarInsercion;
        private ToolStripButton btnOrdenarMezcla;
    }
}
