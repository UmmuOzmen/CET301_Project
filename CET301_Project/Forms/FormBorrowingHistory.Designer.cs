
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttondelete = new System.Windows.Forms.Button();
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
            this.textBoxId.Location = new System.Drawing.Point(142, 30);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(127, 22);
            this.textBoxId.TabIndex = 1;
            // 
            // labelId
            // 
            this.labelId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelId.Location = new System.Drawing.Point(59, 34);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(77, 23);
            this.labelId.TabIndex = 2;
            this.labelId.Text = "ID :";
            this.labelId.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelStudentId
            // 
            this.labelStudentId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelStudentId.Location = new System.Drawing.Point(27, 61);
            this.labelStudentId.Name = "labelStudentId";
            this.labelStudentId.Size = new System.Drawing.Size(109, 23);
            this.labelStudentId.TabIndex = 2;
            this.labelStudentId.Text = "Student ID :";
            this.labelStudentId.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelBookId
            // 
            this.labelBookId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelBookId.Location = new System.Drawing.Point(45, 84);
            this.labelBookId.Name = "labelBookId";
            this.labelBookId.Size = new System.Drawing.Size(91, 23);
            this.labelBookId.TabIndex = 2;
            this.labelBookId.Text = "Book ID :";
            this.labelBookId.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelTakenDate
            // 
            this.labelTakenDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTakenDate.Location = new System.Drawing.Point(21, 111);
            this.labelTakenDate.Name = "labelTakenDate";
            this.labelTakenDate.Size = new System.Drawing.Size(115, 23);
            this.labelTakenDate.TabIndex = 2;
            this.labelTakenDate.Text = "Taken Date :";
            this.labelTakenDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelBroughtdate
            // 
            this.labelBroughtdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelBroughtdate.Location = new System.Drawing.Point(12, 138);
            this.labelBroughtdate.Name = "labelBroughtdate";
            this.labelBroughtdate.Size = new System.Drawing.Size(124, 23);
            this.labelBroughtdate.TabIndex = 2;
            this.labelBroughtdate.Text = "Brought Date :";
            this.labelBroughtdate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(142, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Location = new System.Drawing.Point(142, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(127, 22);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox3.Location = new System.Drawing.Point(142, 111);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(127, 22);
            this.textBox3.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox4.Location = new System.Drawing.Point(142, 138);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(127, 22);
            this.textBox4.TabIndex = 1;
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
            // 
            // FormBorrowingHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 450);
            this.Controls.Add(this.buttondelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelBroughtdate);
            this.Controls.Add(this.labelTakenDate);
            this.Controls.Add(this.labelBookId);
            this.Controls.Add(this.labelStudentId);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttondelete;
    }
}