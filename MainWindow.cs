using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing.Printing;



namespace NFT
{
    public partial class MainWindow : Form
    {
         int[] shape = new int[] { 0, 0, 0, 0, 0 };
        Color color = Color.Black;
        int drawWidth = 2;
        Color colorFill = Color.White;
       
        
        
        

        public MainWindow()
        {
            InitializeComponent();
            Point location = pictureBox.Location;
            
        }

        

        private void closeButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();

            saveFile.Filter = "PNG(*.PNG)|*.png";
            saveFile.FileName = "NFT";

            if(saveFile.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image.Save(saveFile.FileName);
            }
        }
        private void printButton_Click(object sender, EventArgs e)
        {
            //do it later
        }
           

        private void inkButton_Click(object sender, EventArgs e)
        {
            Ink ink = new Ink();
            ink.Show();
        }


        private void startDrawingButton_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox.CreateGraphics();
            

            //create list for points
            List<Point> _pointsLine = new List<Point>();
            List<Point> _pointsTriangle = new List<Point>();
            List<Point> _pointsRectangle = new List<Point>();
            List<Point> _pointsEllipse = new List<Point>();
            List<Point> _pointsBezier = new List<Point>();
            
            //generate the figure objects
            Line line = new Line();
            Triangle triangle = new Triangle();
            MyRectangle myRectangle = new MyRectangle();
            Ellipse ellipse = new Ellipse();
            Bezier bezier = new Bezier();

            if (shape[0] == 1)
            {
                _pointsLine = line.getRandomPoints(); //get all the line points

                Pen pen = new Pen(color, drawWidth);
                int indexPoint = 0;

                for (int i = 0; i < line.numberOfFigures; i++)
                {

                    g.DrawLine(pen, _pointsLine[indexPoint], _pointsLine[indexPoint + 1]); //draw the line

                    indexPoint += 2; // 2 points -> increase with 2
                }
                shape[0] = 0; // reset the shape selected;
            }

            if(shape[1] == 1)
            {
                _pointsTriangle = triangle.getRandomPoints(); //get all the points for triangle

                Pen pen = new Pen(color, drawWidth);
                int indexPoint = 0;


                for (int i = 0; i < triangle.numberOfFigures; i++)
                {
                    Point[] trianglePoints = { _pointsTriangle[indexPoint],
                        _pointsTriangle[indexPoint + 1], _pointsTriangle[indexPoint + 2] }; // put points in a vector

                    g.DrawPolygon(pen, trianglePoints); // draw the triangle

                    indexPoint += 3;// 3 points => +3
                }

                shape[1] = 0;// reset the shape selected
            }

            if(shape[2] == 1)
            {
                _pointsRectangle = myRectangle.getRandomPoints(); //get all the points for MyRectangle

                Pen pen = new Pen(color, drawWidth);
                int indexPoint = 0;

                for (int i = 0; i < myRectangle.numberOfFigures; i++)
                {
                    // set the rectangle object 
                    Rectangle rectangle = new Rectangle(_pointsRectangle[indexPoint].X, _pointsRectangle[indexPoint].Y,
                        _pointsRectangle[indexPoint + 1].X, _pointsRectangle[indexPoint + 1].Y);

                    g.DrawRectangle(pen, rectangle); //draw rectangle
                    indexPoint += 2; //2 "points" -> +2
                }

                shape[2] = 0;// reset the shape selected
            }

            if(shape[3] == 1)
            {
                Pen pen = new Pen(color, drawWidth);
                int indexPoint = 0;

                _pointsEllipse = ellipse.getRandomPoints(); //get all the points for ellipse

                for (int i = 0; i < ellipse.numberOfFigures; i++)
                {
                    // Rectangle object 
                    Rectangle rectangle = new Rectangle(_pointsEllipse[indexPoint].X, _pointsEllipse[indexPoint].Y,
                        _pointsEllipse[indexPoint + 1].X, _pointsEllipse[indexPoint + 1].Y);

                    g.DrawEllipse(pen, rectangle); //draw ellipse

                    indexPoint += 2;// 2 points -> +2
                }
                shape[3] = 0;// reset the shape selected
            }

            if(shape[4] == 1)
            {
                Pen pen = new Pen(color, drawWidth);
                int indexPoint = 0;

                _pointsBezier = bezier.getRandomPoints();//get all the points for bezier

                for (int i = 0; i < bezier.numberOfFigures; i++)
                {
                    g.DrawBezier(pen, _pointsBezier[indexPoint], _pointsBezier[indexPoint + 1],
                        _pointsBezier[indexPoint + 2], _pointsBezier[indexPoint + 3]);

                    indexPoint += 4;//4 points -> +4
                }

                shape[4] = 0;// reset the shape selected
            }

        }

        private void fillButton_Click(object sender, EventArgs e)
        {

        }

        private void infoButton_Click(object sender, EventArgs e)
        {

        }
   
        public void shapeDrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(shapeDrop.Text == "Linii")
            {
                shape[0] = 1;
            }

            if(shapeDrop.Text == "Triunghiuri")
            {
                shape[1] = 1;
            }

            if(shapeDrop.Text == "Dreptunghiuri")
            {
                shape[2] = 1;
            }

            if(shapeDrop.Text == "Elipse")
            {
                shape[3] = 1;
            }

            if(shapeDrop.Text == "Curbe Bezier")
            {
                shape[4] = 1;
            }
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
            colorFill = colorDialog.Color;
            
        }
    }
}
