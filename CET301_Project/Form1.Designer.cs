
namespace CET301_Project
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Menu = new System.Windows.Forms.Panel();
            this.buttonStudents = new System.Windows.Forms.Button();
            this.IconsList = new System.Windows.Forms.ImageList(this.components);
            this.buttonHistory = new System.Windows.Forms.Button();
            this.buttonAuthors = new System.Windows.Forms.Button();
            this.buttonBooks = new System.Windows.Forms.Button();
            this.buttonTypes = new System.Windows.Forms.Button();
            this.MenuHeading = new System.Windows.Forms.Panel();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Menu.Controls.Add(this.buttonStudents);
            this.Menu.Controls.Add(this.buttonHistory);
            this.Menu.Controls.Add(this.buttonAuthors);
            this.Menu.Controls.Add(this.buttonBooks);
            this.Menu.Controls.Add(this.buttonTypes);
            this.Menu.Controls.Add(this.MenuHeading);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(200, 450);
            this.Menu.TabIndex = 0;
            // 
            // buttonStudents
            // 
            this.buttonStudents.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStudents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStudents.ImageIndex = 3;
            this.buttonStudents.ImageList = this.IconsList;
            this.buttonStudents.Location = new System.Drawing.Point(0, 320);
            this.buttonStudents.Name = "buttonStudents";
            this.buttonStudents.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonStudents.Size = new System.Drawing.Size(200, 60);
            this.buttonStudents.TabIndex = 6;
            this.buttonStudents.Text = " Students";
            this.buttonStudents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStudents.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonStudents.UseVisualStyleBackColor = true;
            // 
            // IconsList
            // 
            this.IconsList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IconsList.ImageStream")));
            this.IconsList.TransparentColor = System.Drawing.Color.Transparent;
            this.IconsList.Images.SetKeyName(0, "authors.png");
            this.IconsList.Images.SetKeyName(1, "books.png");
            this.IconsList.Images.SetKeyName(2, "history.png");
            this.IconsList.Images.SetKeyName(3, "students.png");
            this.IconsList.Images.SetKeyName(4, "types.png");
            // 
            // buttonHistory
            // 
            this.buttonHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHistory.ImageIndex = 2;
            this.buttonHistory.ImageList = this.IconsList;
            this.buttonHistory.Location = new System.Drawing.Point(0, 260);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonHistory.Size = new System.Drawing.Size(200, 60);
            this.buttonHistory.TabIndex = 5;
            this.buttonHistory.Text = " Borrowing History";
            this.buttonHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonHistory.UseVisualStyleBackColor = true;
            // 
            // buttonAuthors
            // 
            this.buttonAuthors.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAuthors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAuthors.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAuthors.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAuthors.ImageIndex = 0;
            this.buttonAuthors.ImageList = this.IconsList;
            this.buttonAuthors.Location = new System.Drawing.Point(0, 200);
            this.buttonAuthors.Name = "buttonAuthors";
            this.buttonAuthors.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonAuthors.Size = new System.Drawing.Size(200, 60);
            this.buttonAuthors.TabIndex = 4;
            this.buttonAuthors.Text = " Authors";
            this.buttonAuthors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAuthors.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAuthors.UseVisualStyleBackColor = true;
            // 
            // buttonBooks
            // 
            this.buttonBooks.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBooks.ImageIndex = 1;
            this.buttonBooks.ImageList = this.IconsList;
            this.buttonBooks.Location = new System.Drawing.Point(0, 140);
            this.buttonBooks.Name = "buttonBooks";
            this.buttonBooks.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonBooks.Size = new System.Drawing.Size(200, 60);
            this.buttonBooks.TabIndex = 3;
            this.buttonBooks.Text = " Books";
            this.buttonBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBooks.UseVisualStyleBackColor = true;
            // 
            // buttonTypes
            // 
            this.buttonTypes.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTypes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTypes.ImageIndex = 4;
            this.buttonTypes.ImageList = this.IconsList;
            this.buttonTypes.Location = new System.Drawing.Point(0, 80);
            this.buttonTypes.Name = "buttonTypes";
            this.buttonTypes.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonTypes.Size = new System.Drawing.Size(200, 60);
            this.buttonTypes.TabIndex = 2;
            this.buttonTypes.Text = " Types";
            this.buttonTypes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTypes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTypes.UseVisualStyleBackColor = true;
            // 
            // MenuHeading
            // 
            this.MenuHeading.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.MenuHeading.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuHeading.Location = new System.Drawing.Point(0, 0);
            this.MenuHeading.Name = "MenuHeading";
            this.MenuHeading.Size = new System.Drawing.Size(200, 80);
            this.MenuHeading.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Menu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Menu;
        private System.Windows.Forms.Panel MenuHeading;
        private System.Windows.Forms.Button buttonStudents;
        private System.Windows.Forms.ImageList IconsList;
        private System.Windows.Forms.Button buttonHistory;
        private System.Windows.Forms.Button buttonAuthors;
        private System.Windows.Forms.Button buttonBooks;
        private System.Windows.Forms.Button buttonTypes;
    }
}

