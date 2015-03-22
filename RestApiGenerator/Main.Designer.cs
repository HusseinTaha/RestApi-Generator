﻿namespace RestApiGenerator
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.richJsonText = new System.Windows.Forms.RichTextBox();
            this.modelNameText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.generate = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.projectNameText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Model Name :";
            // 
            // richJsonText
            // 
            this.richJsonText.Location = new System.Drawing.Point(90, 109);
            this.richJsonText.Name = "richJsonText";
            this.richJsonText.Size = new System.Drawing.Size(385, 164);
            this.richJsonText.TabIndex = 1;
            this.richJsonText.Text = "";
            this.richJsonText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richJsonText_KeyDown);
            // 
            // modelNameText
            // 
            this.modelNameText.Location = new System.Drawing.Point(90, 31);
            this.modelNameText.Name = "modelNameText";
            this.modelNameText.Size = new System.Drawing.Size(385, 20);
            this.modelNameText.TabIndex = 2;
            this.modelNameText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.modelNameText_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Json Object :";
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(359, 279);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(116, 59);
            this.generate.TabIndex = 4;
            this.generate.Text = "Generate";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Please chose where to save your files.";
            // 
            // projectNameText
            // 
            this.projectNameText.Location = new System.Drawing.Point(90, 70);
            this.projectNameText.Name = "projectNameText";
            this.projectNameText.Size = new System.Drawing.Size(385, 20);
            this.projectNameText.TabIndex = 6;
            this.projectNameText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.projectNameText_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Project Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "® Copyright 2015 | Created by CoMrEd :) ";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 350);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.projectNameText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.modelNameText);
            this.Controls.Add(this.richJsonText);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "RestApi Generator";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richJsonText;
        private System.Windows.Forms.TextBox modelNameText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox projectNameText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}