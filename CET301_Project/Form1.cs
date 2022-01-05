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

        //Constructor
        public Form1()
        {
            InitializeComponent();
            random = new Random();
        }

        //Methods
        private Color SelectColors()
        {
            int index = random.Next(Colors.ColorsList.Count);
            // with while if the color has already been selected, we select again to choose a different one
            while(tempIndex == index)
            {
                random.Next(Colors.ColorsList.Count);
            }
            tempIndex = index;
            string color = Colors.ColorsList[index];
            return ColorTranslator.FromHtml(color);
        }

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
                }
            }
        }

        private void DiactivateButton()
        {
            foreach(Control previousBtn in Menu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = SystemColors.GradientInactiveCaption;
                    previousBtn.ForeColor = Color.Black;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
                    

                
            }
        }

        private void buttonTypes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonBooks_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonAuthors_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonStudents_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
    }
}
