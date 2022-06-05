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

            if(saveFile.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image.Save(saveFile.FileName); // check later 
            }
        }
        private void printButton_Click(object sender, EventArgs e)
        {
            //do it later
        }


      /*  private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (shape[0] == 1)
            {
                Line line = new Line();
                line.draw(Color.Black, e);
            }

            if (shape[1] == 1)
            {
                Triangle triangle = new Triangle();
                triangle.draw(Color.Black, e);
            }

            if (shape[2] == 1)
            {
                MyRectangle myRectangle = new MyRectangle();
                myRectangle.draw(Color.Black, e);
            }
            if (shape[3] == 1)
            {
                Ellipse ellipse = new Ellipse();
                ellipse.draw(Color.Black, e);
            }

            if(shape[4] == 1)
            {
                Bezier bezier = new Bezier();
                bezier.draw(Color.Black, e);
            }
        }
*/
        private void inkButton_Click(object sender, EventArgs e)
        {
            Ink ink = new Ink();
            ink.Show();
        }


        private void startDrawingButton_Click(object sender, EventArgs e)
        {
            
        }

        private void fillButton_Click(object sender, EventArgs e)
        {

        }

        private void infoButton_Click(object sender, EventArgs e)
        {

        }
        private void shapeDrop_DrawItem(object sender, DrawItemEventArgs e)
        {
          
            
            switch (shapeDrop.Text)
            {
                case "Linii":
                    Line line = new Line();
                    line.draw(Color.Black, e);
                    break;
                case "Triunghiuri":
                    Triangle triangle = new Triangle();
                    triangle.draw(Color.Black, e);
                    break;
                case "Dreptunghiuri":
                    MyRectangle myRectangle = new MyRectangle();
                    myRectangle.draw(Color.Black, e);
                    break;
                case "Elipse":
                    Ellipse ellipse = new Ellipse();
                    ellipse.draw(Color.Black, e);
                    break;
                case "Curbe Bezier":
                    Bezier bezier = new Bezier();
                    bezier.draw(Color.Black, e);
                    break;
            }

            //e.DrawBackground();
        }
        private void shapeDrop_SelectedIndexChanged(object sender, EventArgs e)
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
    }
}
