using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;




namespace CometDustAndIceDistribution_Simulation
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

        private void button1_Click(object sender, EventArgs e)
        {
         //   Graphics g = CreateGraphics();

            pictureBox1.Size = new Size(1000, 800);
            Bitmap simulation = new Bitmap(1000, 800);
            CreateBackground(simulation);

            var accValue = calculateAccValue(double.Parse(TextBoxAccValue.Text), double.Parse(TextBox_AVGdist.Text));
            
            var initialSpeed = double.Parse(TextBoxSpeed.Text);
           
            var dt = double.Parse(TextBoxDeltaT.Text);
            var rawAngles = File.ReadAllLines("angles.txt");
            int step = int.Parse(TextBoxStep.Text);
            List<TimeAnglePair> angles = new List<TimeAnglePair>(rawAngles.Length);
            foreach (var raw in rawAngles)
            {
                var currPair = raw.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                angles.Add(new TimeAnglePair(int.Parse(currPair[0]), double.Parse(currPair[1])*Math.PI/180));
               
            }

            // DrawComet(simulation, accValue, dt, initialSpeed, step, angles, Color.White, false);

            //central part of the comet
            //not in a function due to a specific occasion
            //
            //
            var time = int.Parse(TextBoxTime.Text);
           
            List<Vertex> particlesPositions = new List<Vertex>(1000);
            //START
            for (double index = 0; index<time; index+=dt)
            {

                int currX = simulation.Size.Width / 2 - 30;
                int currY = 240;
                double currSpeedX = 0;
                double currSpeedY = 0;
                double currAccX = 0;
                double currAccY = 0;
                int currdX = 0;
                int currdY = 0;
                int lastT = 0;
                double currTime = 0;
                double currAngle = 0;

                for (double i = index  ; i < time; i += dt)
                {
                    currTime += dt;

                    for (int a = lastT; a < angles.Count; a++)
                    {
                        if (angles[a].Time >= currTime+index)
                        {
                            currAngle = angles[a].Angle;
                            lastT = a;
                            break;
                        }
                    }


                    currAccX = Math.Sin(currAngle) * accValue;
                    currAccY = Math.Cos(currAngle) * accValue;

                    currSpeedX += currAccX * dt * 24 * 3600;
                    currSpeedY += currAccY * dt * 24 * 3600;

                    currdX = (int)(currSpeedX * dt * 24 * 3600)/8000000;
                    currdY = (int)(currSpeedY * dt * 24 * 3600)/8000000;

                    currX += currdX;
                    currY += currdY;
                    //draw samo gi slaga v masiva za risuvane
                    
                    if(time-i <= dt)
                    {
                        DrawCircle(currX, currY, currTime, initialSpeed, step, simulation, particlesPositions);
                    }
                   
                }

            }

            //STOP
            foreach (var item in particlesPositions)
            {
                item.SetPix(item.X, item.Y, simulation, Color.WhiteSmoke);
            }
            //
            //
            //
            //ION tail making
            if (extraCheckBox.Checked)
                {
                     double accMul = double.Parse(accMulTb.Text);
                     DrawComet(simulation, accValue * accMul, dt/2, initialSpeed/1.3, step, angles, Color.RoyalBlue, true);
                }

            //PRINT it and SAVE it

            pictureBox1.Image = simulation;
            DateTime timeNow = DateTime.Now;
            var count = timeNow.Year.ToString() + timeNow.Month.ToString() + timeNow.Day.ToString() + timeNow.Hour.ToString() + timeNow.Minute.ToString() + timeNow.Second.ToString();
            simulation.Save("simulatioN"+ count + ".png");
        }

        private double calculateAccValue(double R, double r)
        {
            R *= 1E-6;
            double acc;
            const double density = 917; // ICE density
            const double sunLum = 3.8E26;
            double E = sunLum / (4 * Math.PI * r * r * (149600000000)*(149600000000));
            double area = Math.PI * R * R;
            double mass = (Math.PI * R * R * R * 4 / 3) * density;
            const double c = 3E8;

            acc = ((E/c) * area * 2)/ mass;
            //MessageBox.Show(acc.ToString());
            return acc;
        }

        void DrawComet(Bitmap simulation, double accValue, double dt, double initialSpeed, int step, 
                       List<TimeAnglePair> angles, Color color, bool useLastOnly)
        {
            var Time = int.Parse(TextBoxTime.Text);
            int currX = simulation.Size.Width / 2 - 30;
            int currY = 240;
            double currSpeedX = 0;
            double currSpeedY = 0;
            double currAccX = 0;
            double currAccY = 0;
            int currdX = 0;
            int currdY = 0;
            int lastT = 0;
            double currTime = 0;
            double currAngle = 0;
            List<Vertex> particlesPositions = new List<Vertex>(1000);
            for (double i = 0; i < Time; i += dt)
            {
                currTime += dt;
                if (useLastOnly) currAngle = angles.Last().Angle;
                else
                {
                    for (int a = lastT; a < angles.Count; a++)
                    {
                        if (angles[a].Time >= currTime)
                        {
                            currAngle = angles[a].Angle;
                            lastT = a;
                            break;
                        }
                    }
                }                

                currAccX = Math.Sin(currAngle) * accValue;
                currAccY = Math.Cos(currAngle) * accValue;

                currSpeedX += currAccX * dt * 24 * 3600;
                currSpeedY += currAccY * dt * 24 * 3600;

                currdX = (int)(currSpeedX * dt * 24 * 3600)/8000000;
                currdY = (int)(currSpeedY * dt * 24 * 3600)/8000000;

                currX += currdX;
                currY += currdY;
                //draw samo gi slaga v masiva za risuvane
                DrawCircle(currX, currY, currTime, initialSpeed, step, simulation, particlesPositions);

                //  g.DrawImage(simulation, 40, 30);
                // System.Threading.Thread.Sleep(100);
            }
            foreach (var item in particlesPositions)
            {
                item.SetPix(item.X, item.Y, simulation, color);
            }
        }

        private void DrawCircle(int currX, int currY, double currTime, double initialSpeed, int step, Bitmap simulation , List<Vertex> pos)
        {
            double radius = currTime * initialSpeed * 24 * 3600 / 8000000;
            double dAngle =  step*Math.PI / 180;
            int numberOfPoints =(int)(2*Math.PI / dAngle);
            double currAngle = 0;
            for (int i = 0; i <= numberOfPoints+1; i++)
            {
                var x = (int)(currX + radius * Math.Sin(currAngle));
                var y = (int)(currY - radius * Math.Cos(currAngle));
                if (x>4 && x<simulation.Width-4 && y>4 && y<simulation.Height-4)
                  
                {
                    if (checkBlur.Checked == true)
                    {
                        Blur(x, y, simulation);
                    }
                    pos.Add(new Vertex(x, y));
                  
                   
                }
               
                currAngle += dAngle;

            }
        }

        private void Blur(int x, int y, Bitmap simulation)
        {
            Color blLev1 = new Color();
            Color blLev2 = new Color();
            Color blLev3 = new Color();
            Color blLev4 = new Color();

            blLev4 = Color.FromArgb(40, 40, 40);
            blLev3 = Color.FromArgb(60, 60, 60);
            blLev2 = Color.FromArgb(80, 80, 80);
            blLev1 = Color.FromArgb(100, 100, 100);

            simulation.SetPixel(x-1,y,blLev1);
            simulation.SetPixel(x+1, y, blLev1);
            simulation.SetPixel(x, y-1, blLev1);
            simulation.SetPixel(x, y+1, blLev1);

            simulation.SetPixel(x-1, y-1, blLev2);
            simulation.SetPixel(x+1, y+1, blLev2);
            simulation.SetPixel(x-1, y+1, blLev2);
            simulation.SetPixel(x+1, y-1, blLev2);

            simulation.SetPixel(x-2, y, blLev2);
            simulation.SetPixel(x+2, y, blLev2);
            simulation.SetPixel(x, y-2, blLev2);
            simulation.SetPixel(x, y+2, blLev2);

            simulation.SetPixel(x+3, y, blLev3);
            simulation.SetPixel(x-3, y, blLev3);
            simulation.SetPixel(x, y+3, blLev3);
            simulation.SetPixel(x, y-3, blLev3);

            simulation.SetPixel(x+2, y+1, blLev3);
            simulation.SetPixel(x-2, y+1, blLev3);
            simulation.SetPixel(x+2, y-1, blLev3);
            simulation.SetPixel(x-2, y-1, blLev3);
            
            simulation.SetPixel(x + 1, y + 2, blLev3);
            simulation.SetPixel(x - 1, y + 2, blLev3);
            simulation.SetPixel(x + 1, y - 2, blLev3);
            simulation.SetPixel(x - 1, y - 2, blLev3);

            
        }

        private void CreateBackground(Bitmap simulation)
        {
            for (int i = 0; i <simulation.Size.Width; i++)
            {
                for (int j = 0; j < simulation.Size.Height; j++)
                {
                    simulation.SetPixel(i,j, Color.Black);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                button1.PerformClick();
            }
        }

        private void TextBoxSpeed_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void TextBoxDeltaT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void TextBoxAccValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void TextBoxTime_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void TextBoxStep_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void checkBlur_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxDeltaT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
