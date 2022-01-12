
namespace CET301_Project.Forms
{
    partial class FormAuthors
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
            this.dataGridViewAuthors = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthors)).BeginInit();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Add.Location = new System.Drawing.Point(301, 61);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(100, 32);
            this.Add.TabIndex = 0;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAuthors
            // 
            this.dataGridViewAuthors.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAuthors.Location = new System.Drawing.Point(407, 61);
            this.dataGridViewAuthors.Name = "dataGridViewAuthors";
            this.dataGridViewAuthors.RowHeadersWidth = 51;
            this.dataGridViewAuthors.RowTemplate.Height = 24;
            this.dataGridViewAuthors.Size = new System.Drawing.Size(497, 377);
            this.dataGridViewAuthors.TabIndex = 1;
            // 
            // Delete
            // 
            this.Delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Delete.Location = new System.Drawing.Point(301, 99);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(100, 32);
            this.Delete.TabIndex = 0;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 2;
            // 
            // IdLabel
            // 
            this.IdLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IdLabel.Location = new System.Drawing.Point(101, 66);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(34, 17);
            this.IdLabel.TabIndex = 3;
            this.IdLabel.Text = "ID : ";
            this.IdLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxId
            // 
            this.textBoxId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxId.Location = new System.Drawing.Point(134, 64);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(155, 22);
            this.textBoxId.TabIndex = 4;
            // 
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelName.Location = new System.Drawing.Point(60, 102);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(73, 17);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Name : ";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelSurname
            // 
            this.labelSurname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSurname.Location = new System.Drawing.Point(59, 134);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(74, 17);
            this.labelSurname.TabIndex = 3;
            this.labelSurname.Text = "Surname : ";
            this.labelSurname.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxName.Location = new System.Drawing.Point(134, 99);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(155, 22);
            this.textBoxName.TabIndex = 4;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSurname.Location = new System.Drawing.Point(134, 131);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(155, 22);
            this.textBoxSurname.TabIndex = 4;
            // 
            // FormAuthors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 450);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewAuthors);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Name = "FormAuthors";
            this.Text = "FormAuthors";
            this.Load += new System.EventHandler(this.FormAuthors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.DataGridView dataGridViewAuthors;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
    }
}