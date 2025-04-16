using System.Windows.Forms;
using System;

namespace _2laboop
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtRows, txtCols, txtMin, txtMax;
        private Button btnGenerateMatrix;
        private DataGridView dataGridViewMatrix;
        private TextBox textBoxSum, textBoxSaddles;
        private Label lblRows, lblCols, lblMin, lblMax, lblSum, lblSaddles;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtRows = new System.Windows.Forms.TextBox();
            this.txtCols = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.btnGenerateMatrix = new System.Windows.Forms.Button();
            this.dataGridViewMatrix = new System.Windows.Forms.DataGridView();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.textBoxSaddles = new System.Windows.Forms.TextBox();
            this.lblRows = new System.Windows.Forms.Label();
            this.lblCols = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.lblSaddles = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRows
            // 
            this.txtRows.Location = new System.Drawing.Point(149, 42);
            this.txtRows.Name = "txtRows";
            this.txtRows.Size = new System.Drawing.Size(34, 22);
            this.txtRows.TabIndex = 0;
            this.txtRows.TextChanged += new System.EventHandler(this.txtRows_TextChanged);
            // 
            // txtCols
            // 
            this.txtCols.Location = new System.Drawing.Point(149, 8);
            this.txtCols.Name = "txtCols";
            this.txtCols.Size = new System.Drawing.Size(34, 22);
            this.txtCols.TabIndex = 1;
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(187, 79);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(34, 22);
            this.txtMin.TabIndex = 2;
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(187, 115);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(34, 22);
            this.txtMax.TabIndex = 3;
            // 
            // btnGenerateMatrix
            // 
            this.btnGenerateMatrix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGenerateMatrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGenerateMatrix.Location = new System.Drawing.Point(6, 168);
            this.btnGenerateMatrix.Name = "btnGenerateMatrix";
            this.btnGenerateMatrix.Size = new System.Drawing.Size(206, 30);
            this.btnGenerateMatrix.TabIndex = 4;
            this.btnGenerateMatrix.Text = "Згенерувати матрицю";
            this.btnGenerateMatrix.UseVisualStyleBackColor = false;
            this.btnGenerateMatrix.Click += new System.EventHandler(this.btnGenerateMatrix_Click);
            // 
            // dataGridViewMatrix
            // 
            this.dataGridViewMatrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMatrix.ColumnHeadersHeight = 29;
            this.dataGridViewMatrix.Location = new System.Drawing.Point(344, 27);
            this.dataGridViewMatrix.Name = "dataGridViewMatrix";
            this.dataGridViewMatrix.RowHeadersWidth = 51;
            this.dataGridViewMatrix.Size = new System.Drawing.Size(409, 195);
            this.dataGridViewMatrix.TabIndex = 5;
            // 
            // textBoxSum
            // 
            this.textBoxSum.Location = new System.Drawing.Point(529, 265);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.Size = new System.Drawing.Size(100, 22);
            this.textBoxSum.TabIndex = 6;
            // 
            // textBoxSaddles
            // 
            this.textBoxSaddles.Location = new System.Drawing.Point(125, 301);
            this.textBoxSaddles.Name = "textBoxSaddles";
            this.textBoxSaddles.Size = new System.Drawing.Size(228, 22);
            this.textBoxSaddles.TabIndex = 7;
            // 
            // lblRows
            // 
            this.lblRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRows.Location = new System.Drawing.Point(3, 45);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(140, 23);
            this.lblRows.TabIndex = 8;
            this.lblRows.Text = "Кількість рядків:";
            // 
            // lblCols
            // 
            this.lblCols.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCols.Location = new System.Drawing.Point(3, 9);
            this.lblCols.Name = "lblCols";
            this.lblCols.Size = new System.Drawing.Size(140, 23);
            this.lblCols.TabIndex = 9;
            this.lblCols.Text = "Кількість стовпців:";
            // 
            // lblMin
            // 
            this.lblMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMin.Location = new System.Drawing.Point(3, 80);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(169, 23);
            this.lblMin.TabIndex = 10;
            this.lblMin.Text = "Мінімальний елемент:";
            this.lblMin.Click += new System.EventHandler(this.lblMin_Click);
            // 
            // lblMax
            // 
            this.lblMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMax.Location = new System.Drawing.Point(3, 116);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(187, 23);
            this.lblMax.TabIndex = 11;
            this.lblMax.Text = "Максимальний елемент:";
            // 
            // lblSum
            // 
            this.lblSum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSum.Location = new System.Drawing.Point(3, 266);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(520, 23);
            this.lblSum.TabIndex = 12;
            this.lblSum.Text = "Сума елементів у тих рядках, які містять хоча б один від’ємний елемент:";
            this.lblSum.Click += new System.EventHandler(this.lblSum_Click);
            // 
            // lblSaddles
            // 
            this.lblSaddles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblSaddles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSaddles.Location = new System.Drawing.Point(3, 302);
            this.lblSaddles.Name = "lblSaddles";
            this.lblSaddles.Size = new System.Drawing.Size(116, 23);
            this.lblSaddles.TabIndex = 13;
            this.lblSaddles.Text = "Сідлові точки:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(501, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Матриця";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(792, 334);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRows);
            this.Controls.Add(this.txtCols);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.btnGenerateMatrix);
            this.Controls.Add(this.dataGridViewMatrix);
            this.Controls.Add(this.textBoxSum);
            this.Controls.Add(this.textBoxSaddles);
            this.Controls.Add(this.lblRows);
            this.Controls.Add(this.lblCols);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.lblSaddles);
            this.Name = "Form1";
            this.Text = "Робота з матрицею";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label label1;
    }
}
