﻿namespace TI_FINAL_AED
{
    partial class ListarVeiculosConduziuLevouMulta
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
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.veiculosComMultaPorCondutorlistView = new System.Windows.Forms.ListView();
            this.cnhMaskTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "CNH: ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(186, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "Listar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // veiculosComMultaPorCondutorlistView
            // 
            this.veiculosComMultaPorCondutorlistView.Location = new System.Drawing.Point(16, 78);
            this.veiculosComMultaPorCondutorlistView.Name = "veiculosComMultaPorCondutorlistView";
            this.veiculosComMultaPorCondutorlistView.Size = new System.Drawing.Size(421, 360);
            this.veiculosComMultaPorCondutorlistView.TabIndex = 3;
            this.veiculosComMultaPorCondutorlistView.UseCompatibleStateImageBehavior = false;
            // 
            // cnhMaskTextBox
            // 
            this.cnhMaskTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnhMaskTextBox.Location = new System.Drawing.Point(66, 35);
            this.cnhMaskTextBox.Mask = "00000000000";
            this.cnhMaskTextBox.Name = "cnhMaskTextBox";
            this.cnhMaskTextBox.Size = new System.Drawing.Size(114, 26);
            this.cnhMaskTextBox.TabIndex = 4;
            this.cnhMaskTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.cnhMaskTextBox_MaskInputRejected);
            // 
            // ListarVeiculosConduziuLevouMulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(447, 450);
            this.Controls.Add(this.cnhMaskTextBox);
            this.Controls.Add(this.veiculosComMultaPorCondutorlistView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Name = "ListarVeiculosConduziuLevouMulta";
            this.Text = "ListarVeiculosConduziuLevouMulta";
            this.Load += new System.EventHandler(this.ListarVeiculosConduziuLevouMulta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView veiculosComMultaPorCondutorlistView;
        private System.Windows.Forms.MaskedTextBox cnhMaskTextBox;
    }
}