using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1
{
    public class SimpleLine
    {
        public Point3D FirstPoint;
        public Point3D SecondPoint;
        private double coff = 0.5f;
        private double radius = 1;

        public void SetSecond(Point3D second)
        {
            this.SecondPoint = second;
        }

        public void Setfirst(Point3D first)
        {
            this.FirstPoint = first;
        }
        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="first">Начальная точка линии</param>
        /// <param name="second">Конечная точка линии</param>
        public SimpleLine(Point3D first, Point3D second)
        {
            this.FirstPoint = first;
            this.SecondPoint = second;
        }
        public SimpleLine()
        {
            this.FirstPoint = new Point3D(0, 0, 0);
            this.SecondPoint = new Point3D(0, 0, 0);
        }

        private Point3D TransferPoint(TupleCoordinate tuple)
        {
            double[,] corP = new double[4, 1];
            double[,] tM = new double[4, 4];
            corP[0, 0] = tuple._x;
            corP[1, 0] = tuple._y;
            corP[2, 0] = tuple._z;
            corP[3, 0] = 1;
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    if (i == j)
                        tM[i, j] = 1;
                    if (j == 3)
                    {
                        switch (i)
                        {
                            case 0:
                                tM[i, j] = -tuple._dx;
                                break;
                            case 1:
                                tM[i, j] = -tuple._dy;
                                break;
                            case 2:
                                tM[i, j] = -tuple._dz;
                                break;
                        }
                    }
                }

            double[,] corNewP = new double[4, 1];
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    corNewP[i, 0] += tM[i, j] * corP[j, 0];
                }
            return new Point3D(corNewP[0, 0], corNewP[1, 0], corNewP[2, 0]);
        }

        public void TransferLine(double dx, double dy, double dz)
        {
            var fTuple = new TupleCoordinate()
            {
                _x = this.FirstPoint._X,
                _y = this.FirstPoint._Y,
                _z = this.FirstPoint._Z,
                _dx = dx,
                _dy = dy,
                _dz = dz
            };
            var sTuple = new TupleCoordinate()
            {
                _x = this.SecondPoint._X,
                _y = this.SecondPoint._Y,
                _z = this.SecondPoint._Z,
                _dx = dx,
                _dy = dy,
                _dz = dz
            };
            this.FirstPoint = this.TransferPoint(fTuple);
            this.SecondPoint = this.TransferPoint(sTuple);
        }

        private Point3D ScalingPoint(TupleCoordinate tuple)
        {
            double[,] corP = new double[4, 1];
            double[,] corNewP = new double[4, 1];
            corP[0, 0] = tuple._x;
            corP[1, 0] = tuple._y;
            corP[2, 0] = tuple._z;
            corP[3, 0] = 1;
            double[,] tM = new double[4, 4];
            for (int i = 0; i < 4; i++)
                switch (i)
                {
                    case 0: tM[i, i] = tuple._dx; break;
                    case 1: tM[i, i] = tuple._dy; break;
                    case 2: tM[i, i] = tuple._dz; break;
                    case 3: tM[i, i] = 1; break;
                }
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    corNewP[i, 0] += tM[i, j] * corP[j, 0];
                }
            return new Point3D(corNewP[0, 0], corNewP[1, 0], corNewP[2, 0]);
        }

        public void ScalingLine(double dx, double dy, double dz)
        {
            var fTuple = new TupleCoordinate()
            {
                _x = this.FirstPoint._X,
                _y = this.FirstPoint._Y,
                _z = this.FirstPoint._Z,
                _dx = dx,
                _dy = dy,
                _dz = dz
            };
            var sTuple = new TupleCoordinate()
            {
                _x = this.SecondPoint._X,
                _y = this.SecondPoint._Y,
                _z = this.SecondPoint._Z,
                _dx = dx,
                _dy = dy,
                _dz = dz
            };
            this.FirstPoint = this.ScalingPoint(fTuple);
            this.SecondPoint = this.ScalingPoint(sTuple);
        }

        private double DegreeToRadian(double angle)
        {
            return Math.PI * angle / 180.0;
        }



        private Point3D TurnPointAroundOSX(TupleCoordinate tuple, double time, double vector)
        {
            radius = 100 - time;
            var rad = coff * (Math.PI / 27 * (radius + time) / time);
            double[,] corP = new double[4, 1];
            corP[0, 0] = tuple._x;
            corP[1, 0] = tuple._y;
            corP[2, 0] = tuple._z;
            corP[3, 0] = 1;
            double[,] tM = new double[4, 4];

            tM[0, 0] = 1;
            tM[1, 1] = Math.Cos(rad);
            tM[1, 2] = -Math.Sin(rad);
            tM[2, 1] = Math.Sin(rad);
            tM[2, 2] = Math.Cos(rad);
            tM[3, 3] = 1;
          
            tM[3, 0] = vector;
            tM[3, 1] = vector * 100 / time;
            tM[3, 2] = vector * 100 / time;
            tM[0, 3] = -tuple._dx;
            tM[1, 3] = -tuple._dy;
            tM[2, 3] = -tuple._dz;

            double[,] corNewP = new double[4, 1];
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    corNewP[i, 0] += tM[i, j] * corP[j, 0];
                }
            return new Point3D(corNewP[0, 0], corNewP[1, 0], corNewP[2, 0]);
        }

        public void TurnLineAroundLineOSX(double dx, int dy, int dz, double time, double vector)
        {
            var fTuple = new TupleCoordinate()
            {
                _x = this.FirstPoint._X,
                _y = this.FirstPoint._Y,
                _z = this.FirstPoint._Z,
                _dx = dx,
                _dy = dy,
                _dz = dz
            };
            var sTuple = new TupleCoordinate()
            {
                _x = this.SecondPoint._X,
                _y = this.SecondPoint._Y,
                _z = this.SecondPoint._Z,
                _dx = dx,
                _dy = dy,
                _dz = dz
            };

            this.FirstPoint = this.TurnPointAroundOSX(fTuple, time, vector);
            this.SecondPoint = this.TurnPointAroundOSX(sTuple, time, vector);

        }





        private Point3D TurnPointAroundOSY(TupleCoordinate tuple, double time, double vector)
        {
            radius = 300 - time;
            var rad = coff * (Math.PI / 45  * (radius + time) / time);
            double[,] corP = new double[4, 1];
            corP[0, 0] = tuple._x;
            corP[1, 0] = tuple._y;
            corP[2, 0] = tuple._z;
            corP[3, 0] = 1;
            double[,] tM = new double[4, 4];

            tM[0, 0] = Math.Cos(rad);
            tM[0, 2] = -Math.Sin(rad);
            tM[1, 1] = 1;
            tM[2, 0] = Math.Sin(rad);
            tM[2, 2] = Math.Cos(rad);
            tM[3, 3] = 1;

            tM[3, 0] = vector;
            tM[3, 1] = vector * 100 / time;
            tM[3, 2] = vector * 100 / time;
            tM[0, 3] = -tuple._dx;
            tM[1, 3] = -tuple._dy;
            tM[2, 3] = -tuple._dz;
            

            double[,] corNewP = new double[4, 1];
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    corNewP[i, 0] += tM[i, j] * corP[j, 0];
                }
            return new Point3D(corNewP[0, 0], corNewP[1, 0], corNewP[2, 0]);

        }

        public void TurnLineAroundLineOSY(double dx, int dy, int dz , double time, double vector)
        {

            var fTuple = new TupleCoordinate()
            {
                _x = this.FirstPoint._X,
                _y = this.FirstPoint._Y,
                _z = this.FirstPoint._Z,
                _dx = dx,
                _dy = dy,
                _dz = dz
            };
            var sTuple = new TupleCoordinate()
            {
                _x = this.SecondPoint._X,
                _y = this.SecondPoint._Y,
                _z = this.SecondPoint._Z,
                _dx = dx,
                _dy = dy,
                _dz = dz
            };

            this.FirstPoint = this.TurnPointAroundOSY(fTuple, time,vector);
            this.SecondPoint = this.TurnPointAroundOSY(sTuple, time, vector);
        }



        private Point3D TurnPointAroundOSZ(TupleCoordinate tuple, double time, double vector)
        {
            radius = 300 - time;
            var rad = coff * (Math.PI / 45 * (radius + time) / time);
            double[,] corP = new double[4, 1];
            corP[0, 0] = tuple._x;
            corP[1, 0] = tuple._y;
            corP[2, 0] = tuple._z;
            corP[3, 0] = 1;
            double[,] tM = new double[4, 4];

            tM[0, 0] = Math.Cos(rad);
            tM[0, 1] = -Math.Sin(rad);
            tM[1, 0] = Math.Sin(rad);
            tM[1, 1] = Math.Cos(rad);
            tM[2, 2] = 1;
            tM[3, 3] = 1;

            tM[3, 0] = vector;
            tM[3, 1] = vector * 100 / time;
            tM[3, 2] = vector * 100 / time;
            tM[0, 3] = -tuple._dx;
            tM[1, 3] = -tuple._dy;
            tM[2, 3] = -tuple._dz;

            double[,] corNewP = new double[4, 1];
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    corNewP[i, 0] += tM[i, j] * corP[j, 0];
                }
            return new Point3D(corNewP[0, 0], corNewP[1, 0], corNewP[2, 0]);
        }

        public void TurnLineAroundLineOSZ(double dx, int dy, int dz, double time, double vector)
        {
            var fTuple = new TupleCoordinate()
            {
                _x = this.FirstPoint._X,
                _y = this.FirstPoint._Y,
                _z = this.FirstPoint._Z,
                _dx = dx,
                _dy = dy,
                _dz = dz
            };
            var sTuple = new TupleCoordinate()
            {
                _x = this.SecondPoint._X,
                _y = this.SecondPoint._Y,
                _z = this.SecondPoint._Z,
                _dx = dx,
                _dy = dy,
                _dz = dz
            };

            this.FirstPoint = this.TurnPointAroundOSZ(fTuple, time, vector);
            this.SecondPoint = this.TurnPointAroundOSZ(sTuple, time, vector);

        }


        private Point3D TurnPointAroundX(double x, double y, double z, double rad)
        {
            double[,] corP = new double[4, 1];
            corP[0, 0] = x;
            corP[1, 0] = y;
            corP[2, 0] = z;
            corP[3, 0] = 1;
            double[,] tM = new double[4, 4];
            tM[0, 0] = 1;
            tM[1, 1] = Math.Cos(rad);
            tM[1, 2] = -Math.Sin(rad);
            tM[2, 1] = Math.Sin(rad);
            tM[2, 2] = Math.Cos(rad);
            tM[3, 3] = 1;

            double[,] corNewP = new double[4, 1];
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    corNewP[i, 0] += tM[i, j] * corP[j, 0];
                }
            return new Point3D(corNewP[0, 0], corNewP[1, 0], corNewP[2, 0]);

        }
        public void  TurnLineAroundX(double angle)
        {
            double rad = DegreeToRadian(angle);
            this.FirstPoint = this.TurnPointAroundX(this.FirstPoint._X, this.FirstPoint._Y, this.FirstPoint._Z, rad);
            this.SecondPoint = this.TurnPointAroundX(this.SecondPoint._X, this.SecondPoint._Y, this.SecondPoint._Z, rad);
        }
        private Point3D TurnPointAroundY(double x, double y, double z, double rad)
        {
            double[,] corP = new double[4, 1];
            corP[0, 0] = x;
            corP[1, 0] = y;
            corP[2, 0] = z;
            corP[3, 0] = 1;
            double[,] tM = new double[4, 4];
            tM[0, 0] = Math.Cos(rad);
            tM[0, 2] = -Math.Sin(rad);
            tM[1, 1] = 1;
            tM[2, 0] = Math.Sin(rad);
            tM[2, 2] = Math.Cos(rad);
            tM[3, 3] = 1;

            double[,] corNewP = new double[4, 1];
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    corNewP[i, 0] += tM[i, j] * corP[j, 0];
                }
            return new Point3D(corNewP[0, 0], corNewP[1, 0], corNewP[2, 0]);

        }
        public void TurnLineAroundY(double angle)
        {
            double rad = DegreeToRadian(angle);
            this.FirstPoint = this.TurnPointAroundY(this.FirstPoint._X, this.FirstPoint._Y, this.FirstPoint._Z, rad);
            this.SecondPoint = this.TurnPointAroundY(this.SecondPoint._X, this.SecondPoint._Y, this.SecondPoint._Z, rad);
        }
        private Point3D TurnPointAroundZ(double x, double y, double z, double rad)
        {
            double[,] corP = new double[4, 1];
            corP[0, 0] = x;
            corP[1, 0] = y;
            corP[2, 0] = z;
            corP[3, 0] = 1;
            double[,] tM = new double[4, 4];
            tM[0, 0] = Math.Cos(rad);
            tM[0, 1] = -Math.Sin(rad);
            tM[1, 0] = Math.Sin(rad);
            tM[1, 1] = Math.Cos(rad);
            tM[2, 2] = 1;
            tM[3, 3] = 1;

            double[,] corNewP = new double[4, 1];
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    corNewP[i, 0] += tM[i, j] * corP[j, 0];
                }
            return new Point3D(corNewP[0, 0], corNewP[1, 0], corNewP[2, 0]);

        }
        public void TurnLineAroundZ(double angle)
        {
            double rad = DegreeToRadian(angle);
            this.FirstPoint = this.TurnPointAroundZ(this.FirstPoint._X, this.FirstPoint._Y, this.FirstPoint._Z, rad);
            this.SecondPoint = this.TurnPointAroundZ(this.SecondPoint._X, this.SecondPoint._Y, this.SecondPoint._Z, rad);
        }





        private Point3D ProectionPoint(double x, double y, double z, double rad, double h)
        {
            double[,] corP = new double[4, 1];
            corP[0, 0] = x;
            corP[1, 0] = y;
            corP[2, 0] = z;
            corP[3, 0] = 1;
            double[,] tM = new double[4, 4];
            tM[0, 0] = Math.Cos(rad);
            tM[0, 1] = -Math.Sin(rad);
            tM[1, 2] = -1;
            tM[1, 3] = h;
            tM[2, 0] = Math.Sin(rad);
            tM[2, 1] = Math.Cos(rad);
            tM[3, 3] = 1;

            double[,] corNewP = new double[4, 1];
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    corNewP[i, 0] += tM[i, j] * corP[j, 0];
                }
            double X = corNewP[0, 0] * (2000 - 700) / (2000 - corNewP[2, 0]);
            double Y = corNewP[1, 0] * (2000 - 700) / (2000 - corNewP[2, 0]);
            Y -= 325;
            return new Point3D(20 * X + 300, 20 * Y + 300, 0);
        }

        public SimpleLine ProectionLine(double alph, double h)
        {
            SimpleLine newLine = new SimpleLine();
            double rad = DegreeToRadian(alph);
            newLine.Setfirst(this.ProectionPoint(this.FirstPoint._X, this.FirstPoint._Z, this.FirstPoint._Y, rad, h));
            newLine.SetSecond(this.ProectionPoint(this.SecondPoint._X, this.SecondPoint._Z, this.SecondPoint._Y, rad, h));
            return newLine;
        }

        public void DrawLine(Graphics graphic)
        {
            graphic.DrawLine(new Pen(Color.Black, 1), (float)this.FirstPoint._X, (float)this.FirstPoint._Y, (float)this.SecondPoint._X, (float)this.SecondPoint._Y);
        }


    }
    public struct Point3D
    {
        public double _X;
        public double _Y;
        public double _Z;
        /// <summary>
        /// Точка в прямоугольной системе координат
        /// </summary>
        /// <param name="_x">OX</param>
        /// <param name="_y">OY</param>
        /// <param name="_z">OZ</param>
        public Point3D(double _x, double _y, double _z)
        {
            this._X = _x;
            this._Y = _y;
            this._Z = _z;
        }

    }
}





