using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    public class Figure : ICloneable
    {
        public List<SimpleLine> Lines { get; set; }

        public Figure()
        {
            this.Lines = new List<SimpleLine>();
        }

        public Figure(List<SimpleLine> _copy)
        {
            this.Lines = _copy;
        }

        List<SimpleLine> IsVisible(List<SimpleLine> linesPR)
        {

            List<SimpleLine> visLines = new List<SimpleLine>();

            for (int i = 0; i < 6; i++)
            {

                int sum = 0;
                for (int j = i * 4; j < 4 * (i + 1); j++)
                {

                    sum += (int)((linesPR[j].FirstPoint._X - linesPR[j].SecondPoint._X) *
                            (linesPR[j].FirstPoint._Y + linesPR[j].SecondPoint._Y));
                }

                if (sum > 0)
                {
                    for (int j = i * 4; j < 4 * (i + 1); j++)
                        visLines.Add(linesPR[j]);
                }
            }
            return visLines;
        }

        public void TransferFigure(double dx, double dy, double dz)
        {
            foreach(var line in Lines)
            {
                line.TransferLine(dx, dy, dz);
            }
        }

        public void ScalingFigure(double kx, double ky, double kz)
        {
            foreach (var line in Lines)
            {
                line.ScalingLine(kx, ky, kz);
            }
        }

        public void TurnFigureAroundOSX(double x, int y, int z, double time, double vector)
        {
            foreach (var line in Lines)
            {
                line.TurnLineAroundLineOSX(x, y, z, time, vector);
            }
        }
        public void TurnFigureAroundOSY(double x, int y, int z , double  time, double vector)
        {
            foreach (var line in Lines)
            {
                line.TurnLineAroundLineOSY(x, y, z , time, vector );
            }
        }
        public void TurnFigureAroundOSZ(double x, int y, int z, double time, double vector)
        {
            foreach (var line in Lines)
            {
                line.TurnLineAroundLineOSZ(x, y, z, time, vector);
            }
        }

        public void TurnFigureAroundX(double angle)
        {
            foreach (var line in Lines)
            {
                line.TurnLineAroundX(angle);
            }
        }

        public void TurnFigureAroundY(double angle)
        {
            foreach (var line in Lines)
            {
                line.TurnLineAroundY(angle);
            }
        }

        public void TurnFigureAroundZ(double angle)
        {
            foreach (var line in Lines)
            {
                line.TurnLineAroundZ(angle);
            }
        }

        public IEnumerable<SimpleLine> ProectionFigure(double alph, double h, bool coord)
        {

            if (coord == true)
            {
                
                var pr = Lines.Select(line => line.ProectionLine(alph, h));
                return pr;
            }
            else
            {
               
                var pr = Lines.Select(line => line.ProectionLine(alph, h));
                /* without invisible lines for lab 2
                ArrayList<SimpleLine> visLines = isVisible(pr);
                return visLines;
                */
                return pr;
            }
        }

        public void AddLine(Point3D first, Point3D sec)
        {
            SimpleLine jl = new SimpleLine(first, sec);
            Lines.Add(jl);
        }

        public object Clone()
        {
            return new Figure(new List<SimpleLine>(Lines));
        }
    }
}
