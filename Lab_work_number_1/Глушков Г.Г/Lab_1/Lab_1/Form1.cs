using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class Form1 : Form
    {
        public Figure figure;
        public Figure coordinate;
        Graphics graphic;
        private int timer = 1;
        private int timerY = 1;
        private int timerZ = 1;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            figure = new Figure();
            coordinate = new Figure();
            graphic = MainPanel.CreateGraphics();
            // координаты
            coordinate.AddLine(new Point3D(-30, 0, 0), new Point3D(30, 0, 0));
            coordinate.AddLine(new Point3D(0, -30, 0), new Point3D(0, 30, 0));
            coordinate.AddLine(new Point3D(0, 0, -30), new Point3D(0, 0, 30));


            #region Coub
            //figure.AddLine(new Point3D(-5, -5, -5), new Point3D(-5, -5, 5));
            //figure.AddLine(new Point3D(-5, -5, 5), new Point3D(5, -5, 5));
            //figure.AddLine(new Point3D(5, -5, 5), new Point3D(5, -5, -5));
            //figure.AddLine(new Point3D(5, -5, -5), new Point3D(-5, -5, -5));

            //figure.AddLine(new Point3D(-5, -5, -5), new Point3D(5, -5, -5));
            //figure.AddLine(new Point3D(5, -5, -5), new Point3D(5, 5, -5));
            //figure.AddLine(new Point3D(5, 5, -5), new Point3D(-5, 5, -5));
            //figure.AddLine(new Point3D(-5, 5, -5), new Point3D(-5, -5, -5));

            //figure.AddLine(new Point3D(-5, -5, -5), new Point3D(-5, 5, -5));
            //figure.AddLine(new Point3D(-5, 5, -5), new Point3D(-5, 5, 5));
            //figure.AddLine(new Point3D(-5, 5, 5), new Point3D(-5, -5, 5));
            //figure.AddLine(new Point3D(-5, -5, 5), new Point3D(-5, -5, -5));

            //figure.AddLine(new Point3D(5, -5, 5), new Point3D(-5, -5, 5));
            //figure.AddLine(new Point3D(-5, -5, 5), new Point3D(-5, 5, 5));
            //figure.AddLine(new Point3D(-5, 5, 5), new Point3D(5, 5, 5));
            //figure.AddLine(new Point3D(5, 5, 5), new Point3D(5, -5, 5));

            //figure.AddLine(new Point3D(5, -5, -5), new Point3D(5, -5, 5));
            //figure.AddLine(new Point3D(5, -5, 5), new Point3D(5, 5, 5));
            //figure.AddLine(new Point3D(5, 5, 5), new Point3D(5, 5, -5));
            //figure.AddLine(new Point3D(5, 5, -5), new Point3D(5, -5, -5));

            //figure.AddLine(new Point3D(5, 5, -5), new Point3D(5, 5, 5));
            //figure.AddLine(new Point3D(5, 5, 5), new Point3D(-5, 5, 5));
            //figure.AddLine(new Point3D(-5, 5, 5), new Point3D(-5, 5, -5));
            //figure.AddLine(new Point3D(-5, 5, -5), new Point3D(5, 5, -5)); 
            #endregion

            figure.AddLine(new Point3D(0, 0, 0), new Point3D(5, 0, 0));
            figure.AddLine(new Point3D(5, 0, 0), new Point3D(5, 8, 0));
            figure.AddLine(new Point3D(5, 8, 0), new Point3D(12, 8, 0));
            figure.AddLine(new Point3D(12, 8, 0), new Point3D(12, 20, 0));
            figure.AddLine(new Point3D(12, 20, 0), new Point3D(7, 20, 0));
            figure.AddLine(new Point3D(7, 20, 0), new Point3D(7, 12, 0));
            figure.AddLine(new Point3D(7, 12, 0), new Point3D(0, 12, 0));
            figure.AddLine(new Point3D(0, 12, 0), new Point3D(0, 0, 0));

            figure.AddLine(new Point3D(0, 0, -4), new Point3D(5, 0, -4));
            figure.AddLine(new Point3D(5, 0, -4), new Point3D(5, 8, -4));
            figure.AddLine(new Point3D(5, 8, -4), new Point3D(12, 8, -4));
            figure.AddLine(new Point3D(12, 8, -4), new Point3D(12, 20, -4));
            figure.AddLine(new Point3D(12, 20, -4), new Point3D(7, 20, -4));
            figure.AddLine(new Point3D(7, 20, -4), new Point3D(7, 12, -4));
            figure.AddLine(new Point3D(7, 12, -4), new Point3D(0, 12, -4));
            figure.AddLine(new Point3D(0, 12, -4), new Point3D(0, 0, -4));

            figure.AddLine(new Point3D(0, 0, 0), new Point3D(0, 0, -4));
            figure.AddLine(new Point3D(5, 0, 0), new Point3D(5, 0, -4));
            figure.AddLine(new Point3D(5, 8, 0), new Point3D(5, 8, -4));
            figure.AddLine(new Point3D(12, 8, 0), new Point3D(12, 8, -4));
            figure.AddLine(new Point3D(12, 20, 0), new Point3D(12, 20, -4));
            figure.AddLine(new Point3D(7, 20, 0), new Point3D(7, 20, -4));
            figure.AddLine(new Point3D(7, 12, 0), new Point3D(7, 12, -4));
            figure.AddLine(new Point3D(0, 12, 0), new Point3D(0, 12, -4));



            



        }
        private void drawFigure()
        {
            List<SimpleLine> proec = figure.ProectionFigure(30, 500, false).ToList();
            
            foreach (var line in proec)
            {
                line.DrawLine(graphic);
            }
            proec = coordinate.ProectionFigure(30, 500, true).ToList();
            foreach (var line in proec)
            {
                line.DrawLine(graphic);
            }
        }
        private void RefreshCanvas()
        {
            List<SimpleLine> proec = figure.ProectionFigure(30, 500, false).ToList();

            foreach (var line in proec)
            {
                line.DrawLine(graphic);
            }
            proec = coordinate.ProectionFigure(30, 500, true).ToList();
            foreach (var line in proec)
            {
                line.DrawLine(graphic);
            }
        }

        private void MainPanel_MouseClick(object sender, MouseEventArgs e)
        {
            RefreshCanvas();
        }

        private void buttonAdd_X_Click(object sender, EventArgs e)
        {
            MainPanel.Refresh();
            figure.TransferFigure(-1, 0, 0);
            this.drawFigure();
        }

       

        private void buttonSub_X_Click(object sender, EventArgs e)
        {
            MainPanel.Refresh();
            figure.TransferFigure(1, 0, 0);
            this.drawFigure();
        }

        private void buttonAdd_Y_Click(object sender, EventArgs e)
        {
            MainPanel.Refresh();
            figure.TransferFigure(0, -1, 0);
            this.drawFigure();
        }

        private void buttonSub_Y_Click(object sender, EventArgs e)
        {
            MainPanel.Refresh();
            figure.TransferFigure(0, 1, 0);
            this.drawFigure();
        }

        private void buttonAdd_Z_Click(object sender, EventArgs e)
        {
            MainPanel.Refresh();
            figure.TransferFigure(0, 0, -1);
            this.drawFigure();
        }

        private void buttonSub_Z_Click(object sender, EventArgs e)
        {
            MainPanel.Refresh();
            figure.TransferFigure(0, 0, 1);
            this.drawFigure();
        }

        private void buttonAdd_Scale_Click(object sender, EventArgs e)
        {
            MainPanel.Refresh();
            figure.ScalingFigure(1.25, 1.25, 1.25);
            this.drawFigure();
        }

        private void buttonSub_Scale_Click(object sender, EventArgs e)
        {
            MainPanel.Refresh();
            figure.ScalingFigure(0.75, 0.75, 0.75);
            this.drawFigure();
        }

        private void buttonRotation_X_Click(object sender, EventArgs e)
        {
            MainPanel.Refresh();
            figure.TurnFigureAroundX(-5);
            this.drawFigure();
        }

        private void buttonRotation_Y_Click(object sender, EventArgs e)
        {
            MainPanel.Refresh();
            figure.TurnFigureAroundY(-5);
            this.drawFigure();
        }

        private void buttonRotation_Z_Click(object sender, EventArgs e)
        {
            MainPanel.Refresh();
            figure.TurnFigureAroundZ(-5);
            this.drawFigure();
        }

        private void buttonAddRotation_X_Click(object sender, EventArgs e)
        {
            MainPanel.Refresh();
            figure.TurnFigureAroundX(5);
            this.drawFigure();
        }

        private void buttonAddRotation_Y_Click(object sender, EventArgs e)
        {
            MainPanel.Refresh();
            figure.TurnFigureAroundY(5);
            this.drawFigure();
        }

        private void buttonAddRotation_Z_Click(object sender, EventArgs e)
        {
            MainPanel.Refresh();
            figure.TurnFigureAroundZ(5);
            this.drawFigure();

           
        }

        private void MainPanel_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.Control && e.Alt && e.KeyCode == Keys.X)
            {
                MainPanel.Refresh();
                timer++;
                figure.TurnFigureAroundOSX(1, 0, 0, timer, 1);
                this.drawFigure();
            }
            if (e.Control && e.Shift && e.KeyCode == Keys.X)
            {
                MainPanel.Refresh();
                if (timer > 1) timer--;
                figure.TurnFigureAroundOSX(-1, 0, 0, timer, -1);
                this.drawFigure();
            }
            if (e.Control && e.Alt && e.KeyCode == Keys.C)
            {
                MainPanel.Refresh();
                timerY++;
                figure.TurnFigureAroundOSY(0, 1, 0, timerY,1);
                this.drawFigure();
            }
            if (e.Control && e.Shift && e.KeyCode == Keys.C)
            {
                MainPanel.Refresh();
                if (timerY > 1) timerY--;
                figure.TurnFigureAroundOSY(0, -1, 0, timerY, -1);
                this.drawFigure();
            }

            if (e.Control && e.Alt && e.KeyCode == Keys.Z)
            {
                MainPanel.Refresh();
                timerZ++;
                figure.TurnFigureAroundOSZ(0, 0, 1, timerZ, 1);
                this.drawFigure();
            }
            if (e.Control && e.Shift && e.KeyCode == Keys.Z)
            {
                MainPanel.Refresh();
                if (timerZ > 1) timerZ--;
                figure.TurnFigureAroundOSZ(0, 0, -1, timerZ, -1);
                this.drawFigure();
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {

            Form1_Load(sender, e);
            MainPanel.Refresh();
            drawFigure();
        }
    }
}
