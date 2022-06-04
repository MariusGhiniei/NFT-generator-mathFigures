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
        Graphics graphics;
        Bitmap bmp;
        public Pen p;
        
        public MainWindow()
        {
            InitializeComponent();
            createCanvas();
        }

        void createCanvas()
        {
            bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            graphics = Graphics.FromImage(bmp);
            pictureBox.BackgroundImage = bmp;
            pictureBox.BackgroundImageLayout = ImageLayout.None;

           
           


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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            Line line = new Line();
            line.draw(Color.Red, e);

           Triangle triangle = new Triangle();
            triangle.draw(Color.Blue, e);

            MyRectangle rectangle = new MyRectangle();
            rectangle.draw(Color.Pink, e);

            Ellipse ellipse = new Ellipse();
            ellipse.draw(Color.Green, e);

            Bezier bezier = new Bezier();
            bezier.draw(Color.Black, e);


            
              
        }

        private void inkButton_Click(object sender, EventArgs e)
        {
            Ink ink = new Ink();
            ink.Show();
        }

        private void shapeDrop_SelectedIndexChanged(object sender, PaintEventArgs e)
        {
            if (shapeDrop.Text == "Linii")
            {
               
                pictureBox_Paint(sender,e);
            }
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
    }
}
