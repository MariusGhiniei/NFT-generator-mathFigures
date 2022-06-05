using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace NFT
{
    abstract class Figure
    {
        //variables 
        public int minCanvasValue = 0;
        public int maxCanvasValue = 400;
        public int numberOfFigures = 7;

        //abstract methods
        public abstract List<Point> getRandomPoints();
        public abstract void draw(Color color, DrawItemEventArgs drawItemEventArgs);

        //public static readonly Random rand = new Random();
        //int numberOfFigures = rand.Next(1,7); ///////// not random number of figures

    }

    class Line : Figure
    {
        List<Point> _points = new List<Point>();

        public override List<Point> getRandomPoints()
        {
            //Line -> 2 points to generate 
            Random rand = new Random();

            for (int i = 0; i < numberOfFigures; i++)
            {
                _points.Add(new Point(
                    rand.Next(minCanvasValue, maxCanvasValue),
                    rand.Next(minCanvasValue, maxCanvasValue)
                    ));

                _points.Add(new Point(
                    rand.Next(minCanvasValue, maxCanvasValue),
                    rand.Next(minCanvasValue, maxCanvasValue)
                    ));
            }

            return _points;
        }

        public override void draw(Color color, DrawItemEventArgs drawItemEventArgs)
        {
            Pen pen = new Pen(color, 2);
            int indexPoint = 0;

            _points = getRandomPoints(); // get all points for line
            for (int i = 0; i < numberOfFigures; i++)
            {

                drawItemEventArgs.Graphics.DrawLine(pen, _points[indexPoint], _points[indexPoint + 1]); //draw the line

                indexPoint += 2; // 2 points -> increase with 2
            }

        }
    }

    class Triangle : Figure
    {
        private List<Point> _points = new List<Point>();

        public override List<Point> getRandomPoints()
        {
            //Triangle -> 3 points to generate 
            Random rand = new Random();

            for (int i = 0; i < 7; i++)
            {
                _points.Add(new Point(
                    rand.Next(minCanvasValue, maxCanvasValue),
                    rand.Next(minCanvasValue, maxCanvasValue)
                    ));

                _points.Add(new Point(
                    rand.Next(minCanvasValue, maxCanvasValue),
                    rand.Next(minCanvasValue, maxCanvasValue)
                    ));

                _points.Add(new Point(
                   rand.Next(minCanvasValue, maxCanvasValue),
                   rand.Next(minCanvasValue, maxCanvasValue)
                   ));
            }

            return _points;
        }

        public override void draw(Color color, DrawItemEventArgs drawItemEventArgs)
        {
            Pen pen = new Pen(color, 2);
            int indexPoint = 0;

            _points = getRandomPoints(); //get all the points for triangle

            for (int i = 0; i < numberOfFigures; i++)
            {
                Point[] trianglePoints = { _points[indexPoint], _points[indexPoint + 1], _points[indexPoint + 2] }; // put points in a vector

                drawItemEventArgs.Graphics.DrawPolygon(pen, trianglePoints); // draw the triangle
                indexPoint += 3;// 3 points => +3
            }

        }

    }

    class MyRectangle : Figure
    {
        private List<Point> _points = new List<Point>();

        public override List<Point> getRandomPoints()
        {
            //Rectangle -> generate origin( 1 point), width + length( 1 point) 
            Random rand = new Random();

            for (int i = 0; i < numberOfFigures; i++)
            {
                //origin
                _points.Add(new Point
                    (rand.Next(minCanvasValue, maxCanvasValue),
                    rand.Next(minCanvasValue, maxCanvasValue)));

                //width + length
                _points.Add(new Point
                    (rand.Next(minCanvasValue, maxCanvasValue),
                    rand.Next(minCanvasValue, maxCanvasValue)));
            }

            return _points;
        }

        public override void draw(Color color, DrawItemEventArgs drawItemEventArgs)
        {
            Pen pen = new Pen(color, 2);
            int indexPoint = 0;

            _points = getRandomPoints(); // get all the points for MyRectangle
            for (int i = 0; i < numberOfFigures; i++)
            {
                // set the rectangle object 
                Rectangle rectangle = new Rectangle(_points[indexPoint].X, _points[indexPoint].Y, 
                    _points[indexPoint + 1].X, _points[indexPoint + 1].Y); 

                drawItemEventArgs.Graphics.DrawRectangle(pen, rectangle); //draw rectangle
                indexPoint += 2; //2 "points" -> +2
            }
        }
    }

    class Ellipse : Figure
    {
        private List<Point> _points = new List<Point>();

        public override List<Point> getRandomPoints()
        {
            //Ellipse -> generate origin( 1 point), width + length( 1 point) of a rectangle 
            Random rand = new Random();

            for (int i = 0; i < numberOfFigures; i++)
            {
                //origin
                _points.Add(new Point
                    (rand.Next(minCanvasValue, maxCanvasValue),
                    rand.Next(minCanvasValue, maxCanvasValue)));

                //width + length
                _points.Add(new Point
                    (rand.Next(minCanvasValue, maxCanvasValue),
                    rand.Next(minCanvasValue, maxCanvasValue)));
            }


            return _points;
        }

        public override void draw(Color color, DrawItemEventArgs drawItemEventArgs)
        {
            Pen pen = new Pen(color, 1);
            int indexPoint = 0;

            _points = getRandomPoints();
            for (int i = 0; i < numberOfFigures; i++)
            {
                // Rectangle object 
                Rectangle rectangle = new Rectangle(_points[indexPoint].X, _points[indexPoint].Y,
                    _points[indexPoint + 1].X, _points[indexPoint + 1].Y);

                drawItemEventArgs.Graphics.DrawEllipse(pen, rectangle);

                indexPoint += 2;
            }
        }
    }

    class Bezier : Figure
    {
        private List<Point> _points = new List<Point>();

        public override List<Point> getRandomPoints()
        {
            //Bezier -> 4 points to generate
            Random rand = new Random();

            for (int i = 0; i < numberOfFigures; i++)
            {

                _points.Add(new Point
                (rand.Next(minCanvasValue, maxCanvasValue),
                rand.Next(minCanvasValue, maxCanvasValue)));

                _points.Add(new Point
                    (rand.Next(minCanvasValue, maxCanvasValue),
                    rand.Next(minCanvasValue, maxCanvasValue)));

                _points.Add(new Point
                    (rand.Next(minCanvasValue, maxCanvasValue),
                    rand.Next(minCanvasValue, maxCanvasValue)));

                _points.Add(new Point
                    (rand.Next(minCanvasValue, maxCanvasValue),
                    rand.Next(minCanvasValue, maxCanvasValue)));

            }

            return _points;
        }

        public override void draw(Color color, DrawItemEventArgs drawItemEventArgs)
        {
            Pen pen = new Pen(color, 2);
            int indexPoint = 0;

            _points = getRandomPoints();

            for (int i = 0; i < numberOfFigures; i++)
            {
                drawItemEventArgs.Graphics.DrawBezier(pen, _points[indexPoint], _points[indexPoint+1],
                    _points[indexPoint + 2], _points[indexPoint+3]);

                indexPoint += 4;
            }
        }
    }

}
