﻿namespace CalculadoraDeMatrizes
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_GerarMatriz2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.col_Matriz2 = new System.Windows.Forms.NumericUpDown();
            this.line_Matriz2 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_GerarMatriz1 = new System.Windows.Forms.Button();
            this.col_Matriz1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.line_Matriz1 = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.col_Matriz2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line_Matriz2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.col_Matriz1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line_Matriz1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1270, 629);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.btn_GerarMatriz2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.col_Matriz2);
            this.tabPage1.Controls.Add(this.line_Matriz2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btn_GerarMatriz1);
            this.tabPage1.Controls.Add(this.col_Matriz1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.line_Matriz1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1262, 603);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Matriz 1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.splitContainer1);
            this.groupBox2.Location = new System.Drawing.Point(555, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(508, 491);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Matriz 2";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Location = new System.Drawing.Point(6, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(496, 466);
            this.panel2.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(514, 233);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Size = new System.Drawing.Size(150, 100);
            this.splitContainer1.TabIndex = 9;
            // 
            // btn_GerarMatriz2
            // 
            this.btn_GerarMatriz2.Location = new System.Drawing.Point(717, 52);
            this.btn_GerarMatriz2.Name = "btn_GerarMatriz2";
            this.btn_GerarMatriz2.Size = new System.Drawing.Size(97, 28);
            this.btn_GerarMatriz2.TabIndex = 8;
            this.btn_GerarMatriz2.Text = "Gerar Matriz 2";
            this.btn_GerarMatriz2.UseVisualStyleBackColor = true;
            this.btn_GerarMatriz2.Click += new System.EventHandler(this.btn_GerarMatriz2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(755, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "x";
            // 
            // col_Matriz2
            // 
            this.col_Matriz2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col_Matriz2.Location = new System.Drawing.Point(784, 5);
            this.col_Matriz2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.col_Matriz2.Name = "col_Matriz2";
            this.col_Matriz2.Size = new System.Drawing.Size(43, 38);
            this.col_Matriz2.TabIndex = 6;
            this.col_Matriz2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // line_Matriz2
            // 
            this.line_Matriz2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.line_Matriz2.Location = new System.Drawing.Point(706, 8);
            this.line_Matriz2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.line_Matriz2.Name = "line_Matriz2";
            this.line_Matriz2.Size = new System.Drawing.Size(43, 38);
            this.line_Matriz2.TabIndex = 5;
            this.line_Matriz2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(9, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(508, 491);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Matriz 1";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 466);
            this.panel1.TabIndex = 0;
            // 
            // btn_GerarMatriz1
            // 
            this.btn_GerarMatriz1.Location = new System.Drawing.Point(147, 49);
            this.btn_GerarMatriz1.Name = "btn_GerarMatriz1";
            this.btn_GerarMatriz1.Size = new System.Drawing.Size(97, 28);
            this.btn_GerarMatriz1.TabIndex = 3;
            this.btn_GerarMatriz1.Text = "Gerar Matriz 1";
            this.btn_GerarMatriz1.UseVisualStyleBackColor = true;
            this.btn_GerarMatriz1.Click += new System.EventHandler(this.btn_GerarMatriz1_Click);
            // 
            // col_Matriz1
            // 
            this.col_Matriz1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col_Matriz1.Location = new System.Drawing.Point(209, 2);
            this.col_Matriz1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.col_Matriz1.Name = "col_Matriz1";
            this.col_Matriz1.Size = new System.Drawing.Size(43, 38);
            this.col_Matriz1.TabIndex = 2;
            this.col_Matriz1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "x";
            // 
            // line_Matriz1
            // 
            this.line_Matriz1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.line_Matriz1.Location = new System.Drawing.Point(131, 5);
            this.line_Matriz1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.line_Matriz1.Name = "line_Matriz1";
            this.line_Matriz1.Size = new System.Drawing.Size(43, 38);
            this.line_Matriz1.TabIndex = 0;
            this.line_Matriz1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1262, 603);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1267, 627);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculadora de Matrizes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.col_Matriz2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line_Matriz2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.col_Matriz1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line_Matriz1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_GerarMatriz2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown col_Matriz2;
        private System.Windows.Forms.NumericUpDown line_Matriz2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_GerarMatriz1;
        private System.Windows.Forms.NumericUpDown col_Matriz1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown line_Matriz1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

