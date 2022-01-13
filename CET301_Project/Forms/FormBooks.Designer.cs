
namespace CET301_Project.Forms
{
    partial class FormBooks
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxıd = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelpcount = new System.Windows.Forms.Label();
            this.textBoxPageCount = new System.Windows.Forms.TextBox();
            this.labelpoint = new System.Windows.Forms.Label();
            this.textBoxPoint = new System.Windows.Forms.TextBox();
            this.labelauthor = new System.Windows.Forms.Label();
            this.textBoxAuthorId = new System.Windows.Forms.TextBox();
            this.labelTypeId = new System.Windows.Forms.Label();
            this.textBoxTypeId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAdd.Location = new System.Drawing.Point(245, 84);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(90, 23);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Location = new System.Drawing.Point(602, 101);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.RowHeadersWidth = 51;
            this.dataGridViewBooks.RowTemplate.Height = 24;
            this.dataGridViewBooks.Size = new System.Drawing.Size(438, 311);
            this.dataGridViewBooks.TabIndex = 1;
            this.dataGridViewBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBooks_CellContentClick);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDelete.Location = new System.Drawing.Point(245, 113);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(90, 23);
            this.buttonDelete.TabIndex = 0;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // labelId
            // 
            this.labelId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(66, 87);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(29, 17);
            this.labelId.TabIndex = 2;
            this.labelId.Text = "ID :";
            this.labelId.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxıd
            // 
            this.textBoxıd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxıd.Location = new System.Drawing.Point(101, 87);
            this.textBoxıd.Name = "textBoxıd";
            this.textBoxıd.Size = new System.Drawing.Size(124, 22);
            this.textBoxıd.TabIndex = 3;
            // 
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(43, 116);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(53, 17);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name :";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxName.Location = new System.Drawing.Point(101, 115);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(124, 22);
            this.textBoxName.TabIndex = 3;
            // 
            // labelpcount
            // 
            this.labelpcount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelpcount.AutoSize = true;
            this.labelpcount.Location = new System.Drawing.Point(6, 143);
            this.labelpcount.Name = "labelpcount";
            this.labelpcount.Size = new System.Drawing.Size(90, 17);
            this.labelpcount.TabIndex = 2;
            this.labelpcount.Text = "Page Count :";
            this.labelpcount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxPageCount
            // 
            this.textBoxPageCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPageCount.Location = new System.Drawing.Point(101, 143);
            this.textBoxPageCount.Name = "textBoxPageCount";
            this.textBoxPageCount.Size = new System.Drawing.Size(124, 22);
            this.textBoxPageCount.TabIndex = 3;
            // 
            // labelpoint
            // 
            this.labelpoint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelpoint.AutoSize = true;
            this.labelpoint.Location = new System.Drawing.Point(47, 172);
            this.labelpoint.Name = "labelpoint";
            this.labelpoint.Size = new System.Drawing.Size(48, 17);
            this.labelpoint.TabIndex = 2;
            this.labelpoint.Text = "Point :";
            this.labelpoint.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxPoint
            // 
            this.textBoxPoint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPoint.Location = new System.Drawing.Point(101, 171);
            this.textBoxPoint.Name = "textBoxPoint";
            this.textBoxPoint.Size = new System.Drawing.Size(124, 22);
            this.textBoxPoint.TabIndex = 3;
            // 
            // labelauthor
            // 
            this.labelauthor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelauthor.AutoSize = true;
            this.labelauthor.Location = new System.Drawing.Point(21, 200);
            this.labelauthor.Name = "labelauthor";
            this.labelauthor.Size = new System.Drawing.Size(75, 17);
            this.labelauthor.TabIndex = 2;
            this.labelauthor.Text = "Author ID :";
            this.labelauthor.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxAuthorId
            // 
            this.textBoxAuthorId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAuthorId.Location = new System.Drawing.Point(101, 199);
            this.textBoxAuthorId.Name = "textBoxAuthorId";
            this.textBoxAuthorId.Size = new System.Drawing.Size(124, 22);
            this.textBoxAuthorId.TabIndex = 3;
            // 
            // labelTypeId
            // 
            this.labelTypeId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTypeId.AutoSize = true;
            this.labelTypeId.Location = new System.Drawing.Point(35, 228);
            this.labelTypeId.Name = "labelTypeId";
            this.labelTypeId.Size = new System.Drawing.Size(61, 17);
            this.labelTypeId.TabIndex = 2;
            this.labelTypeId.Text = "Type ID:";
            this.labelTypeId.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxTypeId
            // 
            this.textBoxTypeId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTypeId.Location = new System.Drawing.Point(101, 227);
            this.textBoxTypeId.Name = "textBoxTypeId";
            this.textBoxTypeId.Size = new System.Drawing.Size(124, 22);
            this.textBoxTypeId.TabIndex = 3;
            // 
            // FormBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 450);
            this.Controls.Add(this.textBoxTypeId);
            this.Controls.Add(this.textBoxAuthorId);
            this.Controls.Add(this.textBoxPoint);
            this.Controls.Add(this.textBoxPageCount);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelTypeId);
            this.Controls.Add(this.labelauthor);
            this.Controls.Add(this.labelpoint);
            this.Controls.Add(this.labelpcount);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxıd);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.dataGridViewBooks);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Name = "FormBooks";
            this.Text = "FormBooks";
            this.Load += new System.EventHandler(this.FormBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBoxıd;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelpcount;
        private System.Windows.Forms.TextBox textBoxPageCount;
        private System.Windows.Forms.Label labelpoint;
        private System.Windows.Forms.TextBox textBoxPoint;
        private System.Windows.Forms.Label labelauthor;
        private System.Windows.Forms.TextBox textBoxAuthorId;
        private System.Windows.Forms.Label labelTypeId;
        private System.Windows.Forms.TextBox textBoxTypeId;
    }
}