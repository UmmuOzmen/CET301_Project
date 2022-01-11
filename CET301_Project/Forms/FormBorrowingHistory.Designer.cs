
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBorrows)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBorrows
            // 
            this.dataGridViewBorrows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBorrows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBorrows.Location = new System.Drawing.Point(312, 42);
            this.dataGridViewBorrows.Name = "dataGridViewBorrows";
            this.dataGridViewBorrows.RowHeadersWidth = 51;
            this.dataGridViewBorrows.RowTemplate.Height = 24;
            this.dataGridViewBorrows.Size = new System.Drawing.Size(446, 389);
            this.dataGridViewBorrows.TabIndex = 0;
            // 
            // FormBorrowingHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewBorrows);
            this.Name = "FormBorrowingHistory";
            this.Text = "FormBorrowingHistory";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBorrows)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBorrows;
    }
}