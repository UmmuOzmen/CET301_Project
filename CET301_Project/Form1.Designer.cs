
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
            this.IconsList = new System.Windows.Forms.ImageList(this.components);
            this.MenuHeading = new System.Windows.Forms.Panel();
            this.appLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pagePanel = new System.Windows.Forms.Panel();
            this.CloseForm = new System.Windows.Forms.Button();
            this.pagePanelLabel = new System.Windows.Forms.Label();
            this.MainPagePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonStudents = new System.Windows.Forms.Button();
            this.buttonHistory = new System.Windows.Forms.Button();
            this.buttonAuthors = new System.Windows.Forms.Button();
            this.buttonBooks = new System.Windows.Forms.Button();
            this.buttonTypes = new System.Windows.Forms.Button();
            this.Menu.SuspendLayout();
            this.MenuHeading.SuspendLayout();
            this.pagePanel.SuspendLayout();
            this.MainPagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Menu.Controls.Add(this.buttonStudents);
            this.Menu.Controls.Add(this.buttonHistory);
            this.Menu.Controls.Add(this.buttonAuthors);
            this.Menu.Controls.Add(this.buttonBooks);
            this.Menu.Controls.Add(this.buttonTypes);
            this.Menu.Controls.Add(this.MenuHeading);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(200, 552);
            this.Menu.TabIndex = 0;
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
            // MenuHeading
            // 
            this.MenuHeading.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.MenuHeading.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MenuHeading.Controls.Add(this.appLabel);
            this.MenuHeading.Controls.Add(this.panel1);
            this.MenuHeading.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuHeading.Location = new System.Drawing.Point(0, 0);
            this.MenuHeading.Name = "MenuHeading";
            this.MenuHeading.Size = new System.Drawing.Size(200, 80);
            this.MenuHeading.TabIndex = 1;
            // 
            // appLabel
            // 
            this.appLabel.AutoSize = true;
            this.appLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.appLabel.Location = new System.Drawing.Point(58, 26);
            this.appLabel.Name = "appLabel";
            this.appLabel.Size = new System.Drawing.Size(92, 20);
            this.appLabel.TabIndex = 2;
            this.appLabel.Text = "LibManSys";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(196, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 80);
            this.panel1.TabIndex = 1;
            // 
            // pagePanel
            // 
            this.pagePanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pagePanel.Controls.Add(this.CloseForm);
            this.pagePanel.Controls.Add(this.pagePanelLabel);
            this.pagePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pagePanel.Location = new System.Drawing.Point(200, 0);
            this.pagePanel.Name = "pagePanel";
            this.pagePanel.Size = new System.Drawing.Size(695, 80);
            this.pagePanel.TabIndex = 1;
            // 
            // CloseForm
            // 
            this.CloseForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseForm.Location = new System.Drawing.Point(650, 0);
            this.CloseForm.Name = "CloseForm";
            this.CloseForm.Size = new System.Drawing.Size(45, 80);
            this.CloseForm.TabIndex = 1;
            this.CloseForm.Text = "X";
            this.CloseForm.UseVisualStyleBackColor = true;
            this.CloseForm.Click += new System.EventHandler(this.CloseForm_Click);
            // 
            // pagePanelLabel
            // 
            this.pagePanelLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pagePanelLabel.AutoSize = true;
            this.pagePanelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pagePanelLabel.Location = new System.Drawing.Point(291, 26);
            this.pagePanelLabel.Name = "pagePanelLabel";
            this.pagePanelLabel.Size = new System.Drawing.Size(88, 29);
            this.pagePanelLabel.TabIndex = 0;
            this.pagePanelLabel.Text = "HOME";
            // 
            // MainPagePanel
            // 
            this.MainPagePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MainPagePanel.Controls.Add(this.panel2);
            this.MainPagePanel.Controls.Add(this.label1);
            this.MainPagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPagePanel.Location = new System.Drawing.Point(200, 80);
            this.MainPagePanel.Name = "MainPagePanel";
            this.MainPagePanel.Size = new System.Drawing.Size(695, 472);
            this.MainPagePanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(122, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 130);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to\r\n Library Management System of CET\r\n\r\nAdmin: Ümmühan Özmen\r\n\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "logo-en_0.png");
            this.ımageList1.Images.SetKeyName(1, "logo-en_0.png");
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackgroundImage = global::CET301_Project.Properties.Resources.logo_en_0;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(127, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(473, 114);
            this.panel2.TabIndex = 1;
            // 
            // buttonStudents
            // 
            this.buttonStudents.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
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
            this.buttonStudents.UseVisualStyleBackColor = false;
            this.buttonStudents.Click += new System.EventHandler(this.buttonStudents_Click);
            // 
            // buttonHistory
            // 
            this.buttonHistory.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHistory.ForeColor = System.Drawing.Color.Black;
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
            this.buttonHistory.UseVisualStyleBackColor = false;
            this.buttonHistory.Click += new System.EventHandler(this.buttonHistory_Click);
            // 
            // buttonAuthors
            // 
            this.buttonAuthors.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonAuthors.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAuthors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAuthors.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAuthors.ForeColor = System.Drawing.Color.Black;
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
            this.buttonAuthors.UseVisualStyleBackColor = false;
            this.buttonAuthors.Click += new System.EventHandler(this.buttonAuthors_Click);
            // 
            // buttonBooks
            // 
            this.buttonBooks.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonBooks.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBooks.ForeColor = System.Drawing.Color.Black;
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
            this.buttonBooks.UseVisualStyleBackColor = false;
            this.buttonBooks.Click += new System.EventHandler(this.buttonBooks_Click);
            // 
            // buttonTypes
            // 
            this.buttonTypes.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonTypes.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTypes.ForeColor = System.Drawing.Color.Black;
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
            this.buttonTypes.UseVisualStyleBackColor = false;
            this.buttonTypes.Click += new System.EventHandler(this.buttonTypes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(895, 552);
            this.Controls.Add(this.MainPagePanel);
            this.Controls.Add(this.pagePanel);
            this.Controls.Add(this.Menu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Menu.ResumeLayout(false);
            this.MenuHeading.ResumeLayout(false);
            this.MenuHeading.PerformLayout();
            this.pagePanel.ResumeLayout(false);
            this.pagePanel.PerformLayout();
            this.MainPagePanel.ResumeLayout(false);
            this.MainPagePanel.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pagePanel;
        private System.Windows.Forms.Label pagePanelLabel;
        private System.Windows.Forms.Label appLabel;
        private System.Windows.Forms.Panel MainPagePanel;
        private System.Windows.Forms.Button CloseForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Panel panel2;
    }
}

