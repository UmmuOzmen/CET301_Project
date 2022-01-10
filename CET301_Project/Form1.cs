using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CET301_Project
{
    public partial class Form1 : Form
    {
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        //Constructor
        public Form1()
        {
            InitializeComponent();
            random = new Random();
            CloseForm.Visible = false;
        }

        //Methods
        private Color SelectColors()
        {
            int index = random.Next(Colors.ColorsList.Count);
            // with while if the color has already been selected, we select again to choose a different one
            while (tempIndex == index)
            {
                index = random.Next(Colors.ColorsList.Count); //by adding index = we create infinite loop
            }
            tempIndex = index;
            string color = Colors.ColorsList[index];
            return ColorTranslator.FromHtml(color);
        }

        // activatebutton:
        // 1. select random color for the theme. 
        //change the background color of the button
        // change the font color of the button
        // change the font size o the button

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DiactivateButton();
                    Color color = SelectColors();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))); // by activating we highlighting the button font size bigger.
                    pagePanel.BackColor = color;
                    MenuHeading.BackColor = color;
                    CloseForm.Visible = true;

                }
            }
        }

        //change button back to default value
        private void DiactivateButton()
        {
            foreach (Control previousBtn in Menu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = SystemColors.GradientInactiveCaption;
                    previousBtn.ForeColor = Color.Black;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }



            }
        }

        // a method to open the forms in the container panel
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender); //highlight the button
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.MainPagePanel.Controls.Add(childForm);
            this.MainPagePanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            pagePanelLabel.Text = childForm.Text;
        }

        private void buttonTypes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormTypes(), sender);
        }

        private void buttonBooks_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormBooks(), sender);
        }

        private void buttonAuthors_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAuthors(), sender);
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormBorrowingHistory(), sender);
        }

        private void buttonStudents_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormStudents(), sender);
        }

        private void CloseForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            Reset();
        }
        private void Reset()
        {
            DiactivateButton();
            pagePanelLabel.Text = "HOME";
            pagePanel.BackColor = SystemColors.GradientActiveCaption;
            MenuHeading.BackColor = SystemColors.GradientActiveCaption;
            currentButton = null;
            CloseForm.Visible = false;
        }
    }
}
