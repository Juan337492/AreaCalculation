using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/****************************************************************
    Juan Rodriguez
    CIST 2341
    C# Programming 1
    Lab #6
This is my code....
*****************************************************************/


namespace Area
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        const double PI = 3.1415926535897931;
        // Radio's and Form Buttons
        //Radio's
        private void circleRadio_CheckedChanged(object sender, EventArgs e)
        {
            radiusName.Text = "Radius";
            widthTextBox.Visible = false;
            areaTextBox.Visible = false;
        
            On_Cal();
        }

        private void squareRadio_CheckedChanged(object sender, EventArgs e)
        {
            widthTextBox.Visible = false;
            areaTextBox.Visible = false;
            radiusName.Text = "Side";
  
            On_Cal();
        }

        private void rectRadio_CheckedChanged(object sender, EventArgs e)
        {
            radiusName.Text = "Height";
            areaTextBox.Visible = false;
            // will make width textBox visible user clicks another radio button that makes it invisible
            widthTextBox.Visible = true;
 
            On_Cal();

        }
        //Buttons
        private void calAreaBtn_Click(object sender, EventArgs e)
        {
            On_Cal();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Exit();
        }
        private void clearBtn_Click(object sender, EventArgs e)
        {
            On_Clear();
        }
   
        // Menu " File " - SubMenu - Clear , Exit
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            On_Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exit();
        }


   
        // Menu Choice - SubMenu - circle ,rectangle, square
        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            On_Cal();
        }

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            On_Cal();
        }
        private void SquareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            widthTextBox.Visible = false;
            areaTextBox.Visible = false;
            On_Cal();
        }
        //Combo Box with 3 items circle, square and rectangle  
        private void ComboBox_Selection_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox();
        }
        //List box with 3 items circle, square and rectangle  
        private void ListBox_Selection_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox();
        }
        
        public void On_Cal()
        // If no number is entered nothing happens. If number is entered do calculation.
        {

            areaTextBox.Visible = true;

            if (circleRadio.Checked == true)
            {
                if  (radiusTextBox.Text == "")
                {

                }
                 else
                {                  
                    double answer = Double.Parse(radiusTextBox.Text);
                    Circle(answer);
                }
                      
            }
            if (squareRadio.Checked == true)
            {
               if (radiusTextBox.Text == "")
                {
                
                }
                 else
                {
                   
                    double answer = Double.Parse(radiusTextBox.Text);
                    Square(answer);
                }
                
            }
           if (rectRadio.Checked == true)
            {
                if(radiusTextBox.Text == "" & widthTextBox.Text == "")
                {
  
                }
                else
                {               
                    double answer = Double.Parse(radiusTextBox.Text);
                    double answerWidth = Double.Parse(widthTextBox.Text);
                    Rectangle(answer, answerWidth);
                }

            }
        }

        public void On_Clear()
        {
            radiusTextBox.Text = "";
            widthTextBox.Text = "";
            areaTextBox.Text = "";
        }
        public void Exit()
        {
            String message = "Are you sure you want to exit?";
            String caption = "Form closing";
            DialogResult answer = MessageBox.Show(message, caption, MessageBoxButtons.YesNo);

            if (answer == DialogResult.Yes)
            {
                Application.Exit();
            }
            if (answer == DialogResult.No)
            {

            }

        }

        public void Circle(double answer)
        {
            double area = PI * (answer * answer);

            areaTextBox.Text = "" + area;
        }
        public void Square(double answer)
        {
            double area = (answer * answer);

            areaTextBox.Text = "" + area;
        }
       public void Rectangle(double answer, double answerWidth)
        {         
            Double area = answer * answerWidth;

            areaTextBox.Text = "" + area;
        }

        public void ComboBox()
        {
            int selectedIndex = ComboBox_Selection.SelectedIndex;
            Object selectedItem = ComboBox_Selection.SelectedItem;

            if(selectedIndex == 0)
            {
                squareRadio.Checked = true;
                On_Cal();
                
            }
            else if(selectedIndex == 1)
            {
                rectRadio.Checked = true;
                On_Cal();
                
            }
            else if (selectedIndex == 2)
            {
                circleRadio.Checked = true;
                On_Cal();
                
            }
        }

        public void ListBox()
        {
            // Get the currently selected item in the ListBox.
            string currentItem = ListBox_Selection.SelectedItem.ToString();

            if (currentItem == "Square")
            {
                
                squareRadio.Checked = true;
                On_Cal();
            }
            else if(currentItem == "Rectangle"){
                
                rectRadio.Checked = true;
                On_Cal();
            }
            else if (currentItem == "Circle")
            {
               
                circleRadio.Checked = true;
                On_Cal();
            }
            
        }
    }
}
