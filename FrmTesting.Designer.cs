﻿namespace workWithDelegates
{
    partial class FrmTesting
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
            this.LbxOutput = new System.Windows.Forms.ListBox();
            this.BtnClick = new System.Windows.Forms.Button();
            this.Txt01 = new System.Windows.Forms.TextBox();
            this.Txt02 = new System.Windows.Forms.TextBox();
            this.Txt03 = new System.Windows.Forms.TextBox();
            this.Txt04 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LbxOutput
            // 
            this.LbxOutput.Dock = System.Windows.Forms.DockStyle.Top;
            this.LbxOutput.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbxOutput.FormattingEnabled = true;
            this.LbxOutput.ItemHeight = 21;
            this.LbxOutput.Location = new System.Drawing.Point(0, 0);
            this.LbxOutput.Name = "LbxOutput";
            this.LbxOutput.Size = new System.Drawing.Size(642, 361);
            this.LbxOutput.TabIndex = 0;
            // 
            // BtnClick
            // 
            this.BtnClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClick.Location = new System.Drawing.Point(12, 390);
            this.BtnClick.Name = "BtnClick";
            this.BtnClick.Size = new System.Drawing.Size(115, 34);
            this.BtnClick.TabIndex = 1;
            this.BtnClick.Text = "Click";
            this.BtnClick.UseVisualStyleBackColor = true;
            this.BtnClick.Click += new System.EventHandler(this.BtnClick_Click);
            // 
            // Txt01
            // 
            this.Txt01.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt01.Location = new System.Drawing.Point(156, 393);
            this.Txt01.Name = "Txt01";
            this.Txt01.Size = new System.Drawing.Size(100, 29);
            this.Txt01.TabIndex = 2;
            // 
            // Txt02
            // 
            this.Txt02.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt02.Location = new System.Drawing.Point(280, 393);
            this.Txt02.Name = "Txt02";
            this.Txt02.Size = new System.Drawing.Size(100, 29);
            this.Txt02.TabIndex = 3;
            // 
            // Txt03
            // 
            this.Txt03.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt03.Location = new System.Drawing.Point(404, 393);
            this.Txt03.Name = "Txt03";
            this.Txt03.Size = new System.Drawing.Size(100, 29);
            this.Txt03.TabIndex = 4;
            // 
            // Txt04
            // 
            this.Txt04.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt04.Location = new System.Drawing.Point(528, 393);
            this.Txt04.Name = "Txt04";
            this.Txt04.Size = new System.Drawing.Size(100, 29);
            this.Txt04.TabIndex = 5;
            // 
            // FrmTesting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 450);
            this.Controls.Add(this.Txt04);
            this.Controls.Add(this.Txt03);
            this.Controls.Add(this.Txt02);
            this.Controls.Add(this.Txt01);
            this.Controls.Add(this.BtnClick);
            this.Controls.Add(this.LbxOutput);
            this.Name = "FrmTesting";
            this.Text = "Listbox Output";
            this.Load += new System.EventHandler(this.FrmTesting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LbxOutput;
        private System.Windows.Forms.Button BtnClick;
        private System.Windows.Forms.TextBox Txt01;
        private System.Windows.Forms.TextBox Txt02;
        private System.Windows.Forms.TextBox Txt03;
        private System.Windows.Forms.TextBox Txt04;
    }
}

