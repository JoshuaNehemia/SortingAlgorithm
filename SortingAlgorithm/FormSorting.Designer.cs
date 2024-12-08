namespace SortingAlgorithm
{
    partial class FormSorting
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
            this.labelInput = new System.Windows.Forms.Label();
            this.comboBoxSortMethod = new System.Windows.Forms.ComboBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.listBoxOutput = new System.Windows.Forms.ListBox();
            this.textBoxInputPathLink = new System.Windows.Forms.TextBox();
            this.labelSortMethod = new System.Windows.Forms.Label();
            this.buttonSort = new System.Windows.Forms.Button();
            this.labelOutput = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelOrder = new System.Windows.Forms.Label();
            this.comboBoxOrder = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelAccuracy = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPecahan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTimeElapsed = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInput.Location = new System.Drawing.Point(25, 22);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(113, 50);
            this.labelInput.TabIndex = 0;
            this.labelInput.Text = "INPUT:";
            // 
            // comboBoxSortMethod
            // 
            this.comboBoxSortMethod.FormattingEnabled = true;
            this.comboBoxSortMethod.Items.AddRange(new object[] {
            "Singly Linked List",
            "Bubble Sort",
            "Heap Sort",
            "Radix Sort",
            "Merge Sort"});
            this.comboBoxSortMethod.Location = new System.Drawing.Point(32, 191);
            this.comboBoxSortMethod.Name = "comboBoxSortMethod";
            this.comboBoxSortMethod.Size = new System.Drawing.Size(444, 28);
            this.comboBoxSortMethod.TabIndex = 1;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonBrowse.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBrowse.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonBrowse.Location = new System.Drawing.Point(339, 69);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(138, 40);
            this.buttonBrowse.TabIndex = 2;
            this.buttonBrowse.Text = "BROWSE";
            this.buttonBrowse.UseVisualStyleBackColor = false;
            // 
            // listBoxOutput
            // 
            this.listBoxOutput.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxOutput.FormattingEnabled = true;
            this.listBoxOutput.ItemHeight = 28;
            this.listBoxOutput.Location = new System.Drawing.Point(558, 75);
            this.listBoxOutput.Name = "listBoxOutput";
            this.listBoxOutput.Size = new System.Drawing.Size(445, 88);
            this.listBoxOutput.TabIndex = 3;
            // 
            // textBoxInputPathLink
            // 
            this.textBoxInputPathLink.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInputPathLink.Location = new System.Drawing.Point(33, 75);
            this.textBoxInputPathLink.Name = "textBoxInputPathLink";
            this.textBoxInputPathLink.Size = new System.Drawing.Size(290, 27);
            this.textBoxInputPathLink.TabIndex = 4;
            this.textBoxInputPathLink.Text = "path link";
            // 
            // labelSortMethod
            // 
            this.labelSortMethod.AutoSize = true;
            this.labelSortMethod.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSortMethod.Location = new System.Drawing.Point(25, 140);
            this.labelSortMethod.Name = "labelSortMethod";
            this.labelSortMethod.Size = new System.Drawing.Size(230, 50);
            this.labelSortMethod.TabIndex = 5;
            this.labelSortMethod.Text = "SORT METHOD:";
            // 
            // buttonSort
            // 
            this.buttonSort.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonSort.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSort.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonSort.Location = new System.Drawing.Point(32, 366);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(445, 55);
            this.buttonSort.TabIndex = 6;
            this.buttonSort.Text = "SORT";
            this.buttonSort.UseVisualStyleBackColor = false;
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOutput.Location = new System.Drawing.Point(551, 25);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(143, 50);
            this.labelOutput.TabIndex = 7;
            this.labelOutput.Text = "OUTPUT:";
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonExit.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonExit.Location = new System.Drawing.Point(793, 366);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(210, 55);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "EXIT";
            this.buttonExit.UseVisualStyleBackColor = false;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonClear.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonClear.Location = new System.Drawing.Point(558, 366);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(210, 55);
            this.buttonClear.TabIndex = 9;
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.UseVisualStyleBackColor = false;
            // 
            // labelOrder
            // 
            this.labelOrder.AutoSize = true;
            this.labelOrder.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrder.Location = new System.Drawing.Point(25, 253);
            this.labelOrder.Name = "labelOrder";
            this.labelOrder.Size = new System.Drawing.Size(123, 50);
            this.labelOrder.TabIndex = 10;
            this.labelOrder.Text = "ORDER:";
            // 
            // comboBoxOrder
            // 
            this.comboBoxOrder.FormattingEnabled = true;
            this.comboBoxOrder.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.comboBoxOrder.Location = new System.Drawing.Point(33, 302);
            this.comboBoxOrder.Name = "comboBoxOrder";
            this.comboBoxOrder.Size = new System.Drawing.Size(444, 28);
            this.comboBoxOrder.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(551, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 50);
            this.label2.TabIndex = 12;
            this.label2.Text = "ACCURACY:";
            // 
            // labelAccuracy
            // 
            this.labelAccuracy.AutoSize = true;
            this.labelAccuracy.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccuracy.Location = new System.Drawing.Point(742, 253);
            this.labelAccuracy.Name = "labelAccuracy";
            this.labelAccuracy.Size = new System.Drawing.Size(69, 50);
            this.labelAccuracy.TabIndex = 13;
            this.labelAccuracy.Text = "100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(802, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 50);
            this.label3.TabIndex = 14;
            this.label3.Text = "% (";
            // 
            // labelPecahan
            // 
            this.labelPecahan.AutoSize = true;
            this.labelPecahan.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPecahan.Location = new System.Drawing.Point(852, 253);
            this.labelPecahan.Name = "labelPecahan";
            this.labelPecahan.Size = new System.Drawing.Size(69, 50);
            this.labelPecahan.TabIndex = 15;
            this.labelPecahan.Text = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(908, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 50);
            this.label1.TabIndex = 16;
            this.label1.Text = "/ 100)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(551, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 50);
            this.label4.TabIndex = 17;
            this.label4.Text = "TIME ELAPSED:";
            // 
            // labelTimeElapsed
            // 
            this.labelTimeElapsed.AutoSize = true;
            this.labelTimeElapsed.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeElapsed.Location = new System.Drawing.Point(777, 302);
            this.labelTimeElapsed.Name = "labelTimeElapsed";
            this.labelTimeElapsed.Size = new System.Drawing.Size(51, 50);
            this.labelTimeElapsed.TabIndex = 18;
            this.labelTimeElapsed.Text = "10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(819, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 50);
            this.label5.TabIndex = 19;
            this.label5.Text = "ms";
            // 
            // buttonDownload
            // 
            this.buttonDownload.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonDownload.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDownload.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonDownload.Location = new System.Drawing.Point(793, 185);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(210, 39);
            this.buttonDownload.TabIndex = 20;
            this.buttonDownload.Text = "DOWNLOAD";
            this.buttonDownload.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(551, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 50);
            this.label6.TabIndex = 21;
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFileName.Location = new System.Drawing.Point(557, 192);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(214, 27);
            this.textBoxFileName.TabIndex = 22;
            this.textBoxFileName.Text = "file name";
            // 
            // FormSorting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 447);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonDownload);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelTimeElapsed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPecahan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelAccuracy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxOrder);
            this.Controls.Add(this.labelOrder);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.labelSortMethod);
            this.Controls.Add(this.textBoxInputPathLink);
            this.Controls.Add(this.listBoxOutput);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.comboBoxSortMethod);
            this.Controls.Add(this.labelInput);
            this.Name = "FormSorting";
            this.Text = "Sorting Your Number Here";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.ComboBox comboBoxSortMethod;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.ListBox listBoxOutput;
        private System.Windows.Forms.TextBox textBoxInputPathLink;
        private System.Windows.Forms.Label labelSortMethod;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelOrder;
        private System.Windows.Forms.ComboBox comboBoxOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelAccuracy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPecahan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTimeElapsed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonDownload;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxFileName;
    }
}