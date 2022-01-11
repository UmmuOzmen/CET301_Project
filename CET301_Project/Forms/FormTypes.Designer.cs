
namespace CET301_Project.Forms
{
    partial class FormTypes
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
            this.button1 = new System.Windows.Forms.Button();
            this.ShowTypesLabel = new System.Windows.Forms.Label();
            this.dataGridViewTypes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Types";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ShowTypesLabel
            // 
            this.ShowTypesLabel.AutoSize = true;
            this.ShowTypesLabel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ShowTypesLabel.Location = new System.Drawing.Point(358, 63);
            this.ShowTypesLabel.Name = "ShowTypesLabel";
            this.ShowTypesLabel.Size = new System.Drawing.Size(135, 17);
            this.ShowTypesLabel.TabIndex = 1;
            this.ShowTypesLabel.Text = "Categories of Books";
            this.ShowTypesLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridViewTypes
            // 
            this.dataGridViewTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTypes.Location = new System.Drawing.Point(351, 93);
            this.dataGridViewTypes.Name = "dataGridViewTypes";
            this.dataGridViewTypes.RowHeadersWidth = 51;
            this.dataGridViewTypes.RowTemplate.Height = 24;
            this.dataGridViewTypes.Size = new System.Drawing.Size(428, 345);
            this.dataGridViewTypes.TabIndex = 2;
            // 
            // FormTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewTypes);
            this.Controls.Add(this.ShowTypesLabel);
            this.Controls.Add(this.button1);
            this.Name = "FormTypes";
            this.Text = "FormTypes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTypes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ShowTypesLabel;
        private System.Windows.Forms.DataGridView dataGridViewTypes;
    }
}