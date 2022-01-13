
namespace CET301_Project.Forms
{
    partial class FormBorrowingHistory
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
            this.dataGridViewBorrows = new System.Windows.Forms.DataGridView();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.labelStudentId = new System.Windows.Forms.Label();
            this.labelBookId = new System.Windows.Forms.Label();
            this.labelTakenDate = new System.Windows.Forms.Label();
            this.labelBroughtdate = new System.Windows.Forms.Label();
            this.textBoxStudId = new System.Windows.Forms.TextBox();
            this.textBoxBookId = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttondelete = new System.Windows.Forms.Button();
            this.dateTimePickerTaken = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBrought = new System.Windows.Forms.DateTimePicker();
            this.buttonClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBorrows)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBorrows
            // 
            this.dataGridViewBorrows.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewBorrows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBorrows.Location = new System.Drawing.Point(440, 30);
            this.dataGridViewBorrows.Name = "dataGridViewBorrows";
            this.dataGridViewBorrows.RowHeadersWidth = 51;
            this.dataGridViewBorrows.RowTemplate.Height = 24;
            this.dataGridViewBorrows.Size = new System.Drawing.Size(758, 389);
            this.dataGridViewBorrows.TabIndex = 0;
            // 
            // textBoxId
            // 
            this.textBoxId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxId.Location = new System.Drawing.Point(119, 33);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(127, 22);
            this.textBoxId.TabIndex = 1;
            this.textBoxId.TextChanged += new System.EventHandler(this.textBoxId_TextChanged);
            // 
            // labelId
            // 
            this.labelId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelId.Location = new System.Drawing.Point(36, 37);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(77, 23);
            this.labelId.TabIndex = 2;
            this.labelId.Text = "ID :";
            this.labelId.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelId.Click += new System.EventHandler(this.labelId_Click);
            // 
            // labelStudentId
            // 
            this.labelStudentId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelStudentId.Location = new System.Drawing.Point(4, 64);
            this.labelStudentId.Name = "labelStudentId";
            this.labelStudentId.Size = new System.Drawing.Size(109, 23);
            this.labelStudentId.TabIndex = 2;
            this.labelStudentId.Text = "Student ID :";
            this.labelStudentId.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelStudentId.Click += new System.EventHandler(this.labelStudentId_Click);
            // 
            // labelBookId
            // 
            this.labelBookId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelBookId.Location = new System.Drawing.Point(22, 87);
            this.labelBookId.Name = "labelBookId";
            this.labelBookId.Size = new System.Drawing.Size(91, 23);
            this.labelBookId.TabIndex = 2;
            this.labelBookId.Text = "Book ID :";
            this.labelBookId.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelBookId.Click += new System.EventHandler(this.labelBookId_Click);
            // 
            // labelTakenDate
            // 
            this.labelTakenDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTakenDate.Location = new System.Drawing.Point(-2, 114);
            this.labelTakenDate.Name = "labelTakenDate";
            this.labelTakenDate.Size = new System.Drawing.Size(115, 23);
            this.labelTakenDate.TabIndex = 2;
            this.labelTakenDate.Text = "Taken Date :";
            this.labelTakenDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelTakenDate.Click += new System.EventHandler(this.labelTakenDate_Click);
            // 
            // labelBroughtdate
            // 
            this.labelBroughtdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelBroughtdate.Location = new System.Drawing.Point(-11, 141);
            this.labelBroughtdate.Name = "labelBroughtdate";
            this.labelBroughtdate.Size = new System.Drawing.Size(124, 23);
            this.labelBroughtdate.TabIndex = 2;
            this.labelBroughtdate.Text = "Brought Date :";
            this.labelBroughtdate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelBroughtdate.Click += new System.EventHandler(this.labelBroughtdate_Click);
            // 
            // textBoxStudId
            // 
            this.textBoxStudId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxStudId.Location = new System.Drawing.Point(119, 60);
            this.textBoxStudId.Name = "textBoxStudId";
            this.textBoxStudId.Size = new System.Drawing.Size(127, 22);
            this.textBoxStudId.TabIndex = 1;
            this.textBoxStudId.TextChanged += new System.EventHandler(this.textBoxStudId_TextChanged);
            // 
            // textBoxBookId
            // 
            this.textBoxBookId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxBookId.Location = new System.Drawing.Point(119, 87);
            this.textBoxBookId.Name = "textBoxBookId";
            this.textBoxBookId.Size = new System.Drawing.Size(127, 22);
            this.textBoxBookId.TabIndex = 1;
            this.textBoxBookId.TextChanged += new System.EventHandler(this.textBoxBookId_TextChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAdd.Location = new System.Drawing.Point(324, 34);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(106, 23);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttondelete
            // 
            this.buttondelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttondelete.Location = new System.Drawing.Point(324, 63);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(106, 23);
            this.buttondelete.TabIndex = 3;
            this.buttondelete.Text = "Delete";
            this.buttondelete.UseVisualStyleBackColor = true;
            this.buttondelete.Click += new System.EventHandler(this.buttondelete_Click);
            // 
            // dateTimePickerTaken
            // 
            this.dateTimePickerTaken.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerTaken.Location = new System.Drawing.Point(119, 115);
            this.dateTimePickerTaken.Name = "dateTimePickerTaken";
            this.dateTimePickerTaken.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerTaken.TabIndex = 4;
            this.dateTimePickerTaken.ValueChanged += new System.EventHandler(this.dateTimePickerTaken_ValueChanged);
            // 
            // dateTimePickerBrought
            // 
            this.dateTimePickerBrought.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerBrought.Location = new System.Drawing.Point(119, 143);
            this.dateTimePickerBrought.Name = "dateTimePickerBrought";
            this.dateTimePickerBrought.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerBrought.TabIndex = 5;
            this.dateTimePickerBrought.ValueChanged += new System.EventHandler(this.dateTimePickerBrought_ValueChanged);
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonClear.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonClear.Location = new System.Drawing.Point(339, 128);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 25);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // FormBorrowingHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 450);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.dateTimePickerBrought);
            this.Controls.Add(this.dateTimePickerTaken);
            this.Controls.Add(this.buttondelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelBroughtdate);
            this.Controls.Add(this.labelTakenDate);
            this.Controls.Add(this.labelBookId);
            this.Controls.Add(this.labelStudentId);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.textBoxBookId);
            this.Controls.Add(this.textBoxStudId);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.dataGridViewBorrows);
            this.Name = "FormBorrowingHistory";
            this.Text = "FormBorrowingHistory";
            this.Load += new System.EventHandler(this.FormBorrow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBorrows)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBorrows;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelStudentId;
        private System.Windows.Forms.Label labelBookId;
        private System.Windows.Forms.Label labelTakenDate;
        private System.Windows.Forms.Label labelBroughtdate;
        private System.Windows.Forms.TextBox textBoxStudId;
        private System.Windows.Forms.TextBox textBoxBookId;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttondelete;
        private System.Windows.Forms.DateTimePicker dateTimePickerTaken;
        private System.Windows.Forms.DateTimePicker dateTimePickerBrought;
        private System.Windows.Forms.Button buttonClear;
    }
}