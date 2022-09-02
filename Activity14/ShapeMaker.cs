using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity14
{
    public partial class ShapeMaker : Form
    {
        public ShapeMaker()
        {
            InitializeComponent();
        }

        private void shapesList_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        //Button to draw when draw button is clicked
        private void drawButton_Click(object sender, EventArgs e)
        {
            
            //Graphics instance
            Graphics graphics = this.displayShapePanel.CreateGraphics();
            //Pen instance
            Pen pen = new Pen(Color.Red, 10);
            //Solid Brush instance
            SolidBrush solidBrush = new SolidBrush(Color.Red);


            // if shape is Circle
            if (shapesList.SelectedIndex == 0)
            {
                //Set cordinates for a circle
                if (outlineRadioButton.Checked)
                {
                    graphics.DrawEllipse(pen, 70, 70, 250, 250);
                }
                else if (fillRadioButton.Checked)
                {
                    graphics.FillEllipse(solidBrush, 70, 70, 250, 250);
                }
            } 
            
            //If shape is Triangle
            else if (shapesList.SelectedIndex == 1)
            {
                //Create 3 points and add cordinates
                PointF point1 = new PointF(70, 250);
                PointF point2 = new PointF(350, 250);
                PointF point3 = new PointF(250, 70);
                if (outlineRadioButton.Checked)
                {
                    graphics.DrawPolygon(pen, new PointF[] { point1, point2, point3 });
                }
                else if (fillRadioButton.Checked)
                {
                    graphics.FillPolygon(solidBrush, new PointF[] { point1, point2, point3 });
                }
            } 
            
            //If shape is Rectangle, use rectangle cordinates
            else if (shapesList.SelectedIndex == 2)
            {
                if (outlineRadioButton.Checked)
                {
                    graphics.DrawRectangle(pen, 70, 70, 250, 250);
                }
                else if (fillRadioButton.Checked)
                {
                    graphics.FillRectangle(solidBrush, 70, 70, 250, 250);
                }
            } 
            
            //If shape is Pentagon, use below cordinates
            else if (shapesList.SelectedIndex == 3)
            {

                // create 5 points
                PointF point1 = new PointF(110, 160);
                PointF point2 = new PointF(140, 230);
                PointF point3 = new PointF(220, 230);
                PointF point4 = new PointF(240, 160);
                PointF point5 = new PointF(180, 100);

                
                PointF[] curvePoints = { point1, point2, point3, point4, point5 };
                if (outlineRadioButton.Checked)
                {
                    
                    graphics.DrawPolygon(pen, curvePoints);
                }
                else if (fillRadioButton.Checked)
                {
                    
                    graphics.FillPolygon(solidBrush, curvePoints);
                }
            } 
            
            //If shape is Hexagon, use bellow coordinates
            else if (shapesList.SelectedIndex == 4)
            {
                // Get the middle of the panel
                float xCoord = displayShapePanel.Width / 2;
                float yCoord = displayShapePanel.Height / 2;

                PointF[] shape = new PointF[6];

                int value = 80;

                // Create 6 points
                for (int index = 0; index < 6; index++)
                {
                    shape[index] = new PointF(
                        xCoord + value * (float)Math.Cos(index * 60 * Math.PI / 180f),
                        yCoord + value * (float)Math.Sin(index * 60 * Math.PI / 180f));
                }
                if (outlineRadioButton.Checked)
                {
                    graphics.DrawPolygon(pen, shape);
                }
                else if (fillRadioButton.Checked)
                {
                    graphics.FillPolygon(solidBrush, shape);
                }
            }


            //When checkbox is selected for name display the shape name
            if (NameCB.Checked)
            {               
                shapeNameLabel.Text = rtnShapeNames(shapesList.SelectedIndex);
            }

            //When checkbox is selected for date display the date
            if (DateCB.Checked)
            {
                dateLabel.Text = DateTime.Now.ToString("d");
            }
        }

        //Define shape name based on the selected index
        private string rtnShapeNames(int index)
        {
            if (index == 0)
            {
                return "Circle";
            }
            else if (index == 1)
            {
                return "Triangle";
            }
            else if (index == 2)
            {
                return "Rectangle";
            }
            else if (index == 3)
            {
                return "Pentagon";
            }
            else if (index == 4)
            {
                return "Hexagon";
            }
            return "";
        }

        //Clear page content
        private void clearButton_Click(object sender, EventArgs e)
        {
            
            displayShapePanel.Refresh();
            shapesList.SelectedIndex = 0;
            fillRadioButton.Checked = false;
            outlineRadioButton.Checked = false;
            NameCB.Checked = false;
            DateCB.Checked = false;
            dateLabel.Text = "";
            shapeNameLabel.Text = "";
        }
    }
}
