namespace Programming
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.matrixN = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.matrixM = new System.Windows.Forms.NumericUpDown();
            this.buttonProceed = new System.Windows.Forms.Button();
            this.originMatrixDGV = new System.Windows.Forms.DataGridView();
            this.resultMatrixDGV = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.matrixN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.originMatrixDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultMatrixDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Размерность матрицы:";
            // 
            // matrixN
            // 
            this.matrixN.Location = new System.Drawing.Point(174, 12);
            this.matrixN.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.matrixN.Name = "matrixN";
            this.matrixN.Size = new System.Drawing.Size(48, 23);
            this.matrixN.TabIndex = 1;
            this.matrixN.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.matrixN.ValueChanged += new System.EventHandler(this.matrixN_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "&N";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "&M";
            // 
            // matrixM
            // 
            this.matrixM.Location = new System.Drawing.Point(260, 12);
            this.matrixM.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.matrixM.Name = "matrixM";
            this.matrixM.Size = new System.Drawing.Size(48, 23);
            this.matrixM.TabIndex = 4;
            this.matrixM.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.matrixM.ValueChanged += new System.EventHandler(this.matrixM_ValueChanged);
            // 
            // buttonProceed
            // 
            this.buttonProceed.Location = new System.Drawing.Point(680, 12);
            this.buttonProceed.Name = "buttonProceed";
            this.buttonProceed.Size = new System.Drawing.Size(75, 23);
            this.buttonProceed.TabIndex = 5;
            this.buttonProceed.Text = "&Расчёт";
            this.buttonProceed.UseVisualStyleBackColor = true;
            this.buttonProceed.Click += new System.EventHandler(this.buttonProceed_Click);
            // 
            // originMatrixDGV
            // 
            this.originMatrixDGV.AllowUserToAddRows = false;
            this.originMatrixDGV.AllowUserToDeleteRows = false;
            this.originMatrixDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.originMatrixDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.originMatrixDGV.ColumnHeadersVisible = false;
            this.originMatrixDGV.Location = new System.Drawing.Point(12, 56);
            this.originMatrixDGV.Name = "originMatrixDGV";
            this.originMatrixDGV.RowHeadersVisible = false;
            this.originMatrixDGV.RowTemplate.Height = 25;
            this.originMatrixDGV.Size = new System.Drawing.Size(364, 279);
            this.originMatrixDGV.TabIndex = 7;
            // 
            // resultMatrixDGV
            // 
            this.resultMatrixDGV.AllowUserToAddRows = false;
            this.resultMatrixDGV.AllowUserToDeleteRows = false;
            this.resultMatrixDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.resultMatrixDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultMatrixDGV.ColumnHeadersVisible = false;
            this.resultMatrixDGV.Location = new System.Drawing.Point(391, 56);
            this.resultMatrixDGV.Name = "resultMatrixDGV";
            this.resultMatrixDGV.RowHeadersVisible = false;
            this.resultMatrixDGV.RowTemplate.Height = 25;
            this.resultMatrixDGV.Size = new System.Drawing.Size(364, 279);
            this.resultMatrixDGV.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Исходная матрица";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(391, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Полученный массив";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 348);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.resultMatrixDGV);
            this.Controls.Add(this.originMatrixDGV);
            this.Controls.Add(this.buttonProceed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.matrixM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.matrixN);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Куницин Д.С. - задание 7 - вариант 12";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.matrixN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.originMatrixDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultMatrixDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private NumericUpDown matrixN;
        private Label label2;
        private Label label3;
        private NumericUpDown matrixM;
        private Button buttonProceed;
        private DataGridView originMatrixDGV;
        private DataGridView resultMatrixDGV;
        private Label label4;
        private Label label5;
    }
}