using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void circleRadio_CheckedChanged(object sender, EventArgs e)
        {
            radiusName.Text = "Radius";
            widthTextBox.Visible = false;
            areaTextBox.Visible = false;
   
        }

        private void squareRadio_CheckedChanged(object sender, EventArgs e)
        {
            radiusName.Text = "Side";
            widthTextBox.Visible = false;
            areaTextBox.Visible = false;

        }

        private void rectRadio_CheckedChanged(object sender, EventArgs e)
        {
            radiusName.Text = "Height";
            areaTextBox.Visible = false;
            // will make width textBox visible user clicks another radio button that makes it invisible
            widthTextBox.Visible = true;

        }

        private void calAreaBtn_Click(object sender, EventArgs e)
        {
            const double PI = 3.1415926535897931;
            areaTextBox.Visible = true;
            
        if (circleRadio.Checked == true){
                double answer;
                answer = Double.Parse(radiusTextBox.Text);
               double area = PI * (answer*answer);
                
                areaTextBox.Text = ""+area;
                }
        if(squareRadio.Checked == true)
            {
                double answer;
                answer = Double.Parse(radiusTextBox.Text);
                double area = (answer * answer);

                areaTextBox.Text = "" + area;
            }
        if(rectRadio.Checked == true)
            {
                double answer;
                double answerWidth;
                answer = Double.Parse(radiusTextBox.Text);
                answerWidth = Double.Parse(widthTextBox.Text);
                Double area = answer * answerWidth;

                areaTextBox.Text = "" + area ;
            }
        }

       
    }
}
