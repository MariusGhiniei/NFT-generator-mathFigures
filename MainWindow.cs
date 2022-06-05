using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Windows.Forms;



namespace NFT
{
    public partial class MainWindow : Form
    {
        int[] shape = new int[] { 0, 0, 0, 0, 0 };
        Color color = Color.Black;
        int drawWidth = 2;
        Color colorFill = Color.White;
        bool fillPressed = false;


        Graphics g;

        public int canvasWidth = 400, canvasHeight = 400;
        Bitmap bmp = new Bitmap(400, 400);


        public MainWindow()
        {
            InitializeComponent();
            canvas(); //delete later 
        }

        public void canvas()
        {
            Bitmap bmp = new Bitmap(canvasWidth, canvasHeight);
            pictureBox.Image = bmp;

        }


        private void closeButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Image image = new Bitmap(canvasWidth, canvasHeight);

            Graphics imageSave = Graphics.FromImage(image);
            imageSave.DrawImage(bmp, 0, 0, canvasWidth, canvasHeight);

            SaveFileDialog saveFile = new SaveFileDialog();

            saveFile.Filter = "PNG(*.PNG)|*.png|JPEG files (*.jpeg)|*.jpeg|All files (*.*)|*.*";
            saveFile.FileName = "NFT";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                image.Save(saveFile.FileName, ImageFormat.Png);
            }
        }
        private void printButton_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();

            printDocument.PrintPage += PrintDocument_PrintPage;
            printDialog.Document = printDocument;
            if (printDialog.ShowDialog() == DialogResult.OK)
                printDocument.Print();
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
            bmp.Dispose();

        }

        private void drawPixel(int x, int y, Color color)
        {
            int copyX = x;
            int copyY = y;

            if (color != Color.White && fillPressed == true)
            {
                if (pictureBox.Image != null)
                {
                    Bitmap fillBmp = new Bitmap(pictureBox.Image);

                    Color colorPicture = Color.Red;

                    //draw just on black points -> beautiful :)) 
                    /*  for (int i = 0; i < 400; i++)
                          for (int j = 0; j < 400; j++)
                          {
                              if (x + i < 399 && y + j < 399)
                              {
                                  colorPicture = fillBmp.GetPixel(x + i, y + j);
                                  if (colorPicture == Color.FromArgb(0, 0, 0))
                                  {
                                      fillBmp.SetPixel(x + i , y + j, colorFill);
                                      pictureBox.Image = fillBmp;
                                  } 

                              }

                          }*/

                    //draw just some lines 
                    for (int i = 0; i < 400; i++)
                    {
                        if (x + i < 399 && y + i < 399)
                        {
                            colorPicture = fillBmp.GetPixel(x + i, y + i);
                            if (colorPicture != Color.FromArgb(0, 0, 0))
                            {
                                fillBmp.SetPixel(x + i, y + i, colorFill);
                                pictureBox.Image = fillBmp;
                            }

                        }
                        else if (x + i < 399 && (y - i > 0 && y - i < 399))
                        {
                            colorPicture = fillBmp.GetPixel(x + i, y - i);
                            if (colorPicture != Color.FromArgb(0, 0, 0))
                            {
                                fillBmp.SetPixel(x + i, y - i, colorFill);
                                pictureBox.Image = fillBmp;
                            }
                        }

                    }
                    //draw just rectangles :))
                    /* for (int i = 0; i < 400; i++)
                         for (int j = 0; j < 400; j++)
                         {
                             if (x + i < 399 && y + j < 399)
                             {
                                 colorPicture = fillBmp.GetPixel(x + i, y + j);
                                 if (colorPicture != Color.FromArgb(0, 0, 0))
                                 {
                                     fillBmp.SetPixel(x + i, y + j, colorFill);
                                     pictureBox.Image = fillBmp;
                                 }

                             }
                             else if (x + i < 399 && (y - j > 0 && y - j < 399))
                             {
                                 colorPicture = fillBmp.GetPixel(x + i, y - j);
                                 if (colorPicture != Color.FromArgb(0, 0, 0))
                                 {
                                     fillBmp.SetPixel(x + i, y - j, colorFill);
                                     pictureBox.Image = fillBmp;
                                 }
                             }
                         }*/
                }
            }
        }
        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            //List<Tuple<Point, Color>> pointsFill = new List<Tuple<Point, Color>>();

            //MessageBox.Show(Cursor.Position.X.ToString());
            //MessageBox.Show((Cursor.Position.Y).ToString()); => find the coordinates of corners
            //Point leftUp = new Point(758, 337);
            //Point rightUp = new Point(1157, 337);
            //Point leftDown = new Point(758, 735);
            //Point rigthDown = new Point(1157, 735);

            Point start = new Point(e.X, e.Y);

            drawPixel(start.X, start.Y, colorFill);

        }


        private void inkButton_Click(object sender, EventArgs e)
        {
            Ink ink = new Ink();
            ink.Show();
            //do it later later
        }


        private void startDrawingButton_Click(object sender, EventArgs e)
        {

            g = Graphics.FromImage(bmp);

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
                    pictureBox.Image = bmp;
                    indexPoint += 2; // 2 points -> increase with 2
                }
                shape[0] = 0; // reset the shape selected;
            }

            if (shape[1] == 1)
            {
                _pointsTriangle = triangle.getRandomPoints(); //get all the points for triangle

                Pen pen = new Pen(color, drawWidth);
                int indexPoint = 0;


                for (int i = 0; i < triangle.numberOfFigures; i++)
                {
                    Point[] trianglePoints = { _pointsTriangle[indexPoint],
                        _pointsTriangle[indexPoint + 1], _pointsTriangle[indexPoint + 2] }; // put points in a vector

                    g.DrawPolygon(pen, trianglePoints); // draw the triangle
                    pictureBox.Image = bmp;
                    indexPoint += 3;// 3 points => +3
                }

                shape[1] = 0;// reset the shape selected
            }

            if (shape[2] == 1)
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
                    pictureBox.Image = bmp;
                    indexPoint += 2; //2 "points" -> +2
                }

                shape[2] = 0;// reset the shape selected
            }

            if (shape[3] == 1)
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
                    pictureBox.Image = bmp;

                    indexPoint += 2;// 2 points -> +2
                }
                shape[3] = 0;// reset the shape selected
            }

            if (shape[4] == 1)
            {
                Pen pen = new Pen(color, drawWidth);
                int indexPoint = 0;

                _pointsBezier = bezier.getRandomPoints();//get all the points for bezier

                for (int i = 0; i < bezier.numberOfFigures; i++)
                {
                    g.DrawBezier(pen, _pointsBezier[indexPoint], _pointsBezier[indexPoint + 1],
                        _pointsBezier[indexPoint + 2], _pointsBezier[indexPoint + 3]);

                    pictureBox.Image = bmp;

                    indexPoint += 4;//4 points -> +4
                }

                shape[4] = 0;// reset the shape selected
            }

        }

        private void fillButton_Click(object sender, EventArgs e)
        {
            fillPressed = true;
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                 "Proiect realizat de Ghiniei Marius Iulian M525" +
                 "\nCodul sursa este pe GitHub, apasa Yes pentru link", "Info",
                 MessageBoxButtons.YesNoCancel,
                 MessageBoxIcon.Information
                ) == DialogResult.Yes)
            {
                System.Diagnostics.Process.
                    Start("https://github.com/MariusGhiniei/NFT-generator-mathFigures");
            }

        }

        public void shapeDrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (shapeDrop.Text == "Linii")
            {
                shape[0] = 1;
            }

            if (shapeDrop.Text == "Triunghiuri")
            {
                shape[1] = 1;
            }

            if (shapeDrop.Text == "Dreptunghiuri")
            {
                shape[2] = 1;
            }

            if (shapeDrop.Text == "Elipse")
            {
                shape[3] = 1;
            }

            if (shapeDrop.Text == "Curbe Bezier")
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
