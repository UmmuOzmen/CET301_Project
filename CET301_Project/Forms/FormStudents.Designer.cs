
namespace CET301_Project.Forms
{
    partial class FormStudents
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
            this.Add = new System.Windows.Forms.Button();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.Button();
            this.labelSId = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelClass = new System.Windows.Forms.Label();
            this.labelPoint = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxPoint = new System.Windows.Forms.TextBox();
            this.textBoxClass = new System.Windows.Forms.TextBox();
            this.textBoxBirthdate = new System.Windows.Forms.TextBox();
            this.textBoxGender = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Add.Location = new System.Drawing.Point(278, 95);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(113, 23);
            this.Add.TabIndex = 0;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewStudents.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Location = new System.Drawing.Point(397, 95);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.RowHeadersWidth = 51;
            this.dataGridViewStudents.RowTemplate.Height = 24;
            this.dataGridViewStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStudents.Size = new System.Drawing.Size(756, 295);
            this.dataGridViewStudents.TabIndex = 1;
            // 
            // Delete
            // 
            this.Delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Delete.Location = new System.Drawing.Point(278, 124);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(113, 23);
            this.Delete.TabIndex = 0;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // labelSId
            // 
            this.labelSId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSId.Location = new System.Drawing.Point(57, 95);
            this.labelSId.Name = "labelSId";
            this.labelSId.Size = new System.Drawing.Size(37, 17);
            this.labelSId.TabIndex = 2;
            this.labelSId.Text = "ID :";
            // 
            // textBoxID
            // 
            this.textBoxID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxID.Location = new System.Drawing.Point(100, 94);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 22);
            this.textBoxID.TabIndex = 3;
            // 
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelName.Location = new System.Drawing.Point(34, 130);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(60, 17);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name :";
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // labelSurname
            // 
            this.labelSurname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSurname.Location = new System.Drawing.Point(12, 158);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(75, 17);
            this.labelSurname.TabIndex = 2;
            this.labelSurname.Text = "Surname :";
            this.labelSurname.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelBirthDate.Location = new System.Drawing.Point(7, 187);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(87, 17);
            this.labelBirthDate.TabIndex = 2;
            this.labelBirthDate.Text = "Birth Date :";
            this.labelBirthDate.Click += new System.EventHandler(this.labelBirthDate_Click);
            // 
            // labelGender
            // 
            this.labelGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(23, 214);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(64, 17);
            this.labelGender.TabIndex = 2;
            this.labelGender.Text = "Gender :";
            // 
            // labelClass
            // 
            this.labelClass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelClass.Location = new System.Drawing.Point(23, 241);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(64, 17);
            this.labelClass.TabIndex = 2;
            this.labelClass.Text = "Class :";
            this.labelClass.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelPoint
            // 
            this.labelPoint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPoint.Location = new System.Drawing.Point(23, 270);
            this.labelPoint.Name = "labelPoint";
            this.labelPoint.Size = new System.Drawing.Size(64, 17);
            this.labelPoint.TabIndex = 2;
            this.labelPoint.Text = "Point :";
            this.labelPoint.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxName.Location = new System.Drawing.Point(100, 127);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 22);
            this.textBoxName.TabIndex = 3;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSurname.Location = new System.Drawing.Point(100, 155);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(100, 22);
            this.textBoxSurname.TabIndex = 3;
            // 
            // textBoxPoint
            // 
            this.textBoxPoint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPoint.Location = new System.Drawing.Point(100, 267);
            this.textBoxPoint.Name = "textBoxPoint";
            this.textBoxPoint.Size = new System.Drawing.Size(100, 22);
            this.textBoxPoint.TabIndex = 3;
            // 
            // textBoxClass
            // 
            this.textBoxClass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxClass.Location = new System.Drawing.Point(100, 239);
            this.textBoxClass.Name = "textBoxClass";
            this.textBoxClass.Size = new System.Drawing.Size(100, 22);
            this.textBoxClass.TabIndex = 3;
            // 
            // textBoxBirthdate
            // 
            this.textBoxBirthdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxBirthdate.Location = new System.Drawing.Point(100, 183);
            this.textBoxBirthdate.Name = "textBoxBirthdate";
            this.textBoxBirthdate.Size = new System.Drawing.Size(100, 22);
            this.textBoxBirthdate.TabIndex = 3;
            // 
            // textBoxGender
            // 
            this.textBoxGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxGender.Location = new System.Drawing.Point(100, 211);
            this.textBoxGender.Name = "textBoxGender";
            this.textBoxGender.Size = new System.Drawing.Size(100, 22);
            this.textBoxGender.TabIndex = 3;
            // 
            // FormStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 450);
            this.Controls.Add(this.textBoxGender);
            this.Controls.Add(this.textBoxBirthdate);
            this.Controls.Add(this.textBoxClass);
            this.Controls.Add(this.textBoxPoint);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelPoint);
            this.Controls.Add(this.labelClass);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelBirthDate);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelSId);
            this.Controls.Add(this.dataGridViewStudents);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Name = "FormStudents";
            this.Text = "FormStudents";
            this.Load += new System.EventHandler(this.FormStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label labelSId;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelBirthDate;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.Label labelPoint;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxPoint;
        private System.Windows.Forms.TextBox textBoxClass;
        private System.Windows.Forms.TextBox textBoxBirthdate;
        private System.Windows.Forms.TextBox textBoxGender;
    }
}