﻿namespace TI_FINAL_AED
{
    partial class RelatorioDeVeiculoSemMulta
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
            this.veiculosSemMultalistView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // veiculosSemMultalistView
            // 
            this.veiculosSemMultalistView.Location = new System.Drawing.Point(13, 33);
            this.veiculosSemMultalistView.Name = "veiculosSemMultalistView";
            this.veiculosSemMultalistView.Size = new System.Drawing.Size(358, 405);
            this.veiculosSemMultalistView.TabIndex = 0;
            this.veiculosSemMultalistView.UseCompatibleStateImageBehavior = false;
            // 
            // RelatorioDeVeiculoSemMulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 450);
            this.Controls.Add(this.veiculosSemMultalistView);
            this.Name = "RelatorioDeVeiculoSemMulta";
            this.Text = "RelatorioDeVeiculoSemMulta";
            this.Load += new System.EventHandler(this.RelatorioDeVeiculoSemMulta_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView veiculosSemMultalistView;
    }
}