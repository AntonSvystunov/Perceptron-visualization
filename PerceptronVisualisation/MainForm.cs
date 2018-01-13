using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;

namespace PerceptronVisualisation
{
    public partial class MainForm : Form
    {
        Perceptron perceptron;
        List<Point> points;

        float LINE_A = 1;
        float LINE_B = 0;

        Func<float, float> function;

        int trainings = 0;
        int wrongPoints = 0;
        bool autoTrain = false;

        public MainForm()
        {
            InitializeComponent();

            perceptron = new Perceptron();
            InfoLabel.Text = perceptron.getWeights();

            points = new List<Point>();

            function = new Func<float, float>(x => (LINE_A)*x + LINE_B);
            
            UpdateInfo();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Draw();
        }

        protected void GetLineValues()
        {
            var form = new LineEnterForm();
            var result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                LINE_A = form.a;
                LINE_B = form.b;

                function = new Func<float, float>(x => (LINE_A) * x + LINE_B);

                points = new List<Point>();
                perceptron.ReInit();
                trainings = 0;
            }
        }

        protected void Draw()
        {
            Bitmap bm = new Bitmap(pictureBox.Width, pictureBox.Height);
            Graphics formGraphics = Graphics.FromImage(bm);
            Pen blackPen = new Pen(Color.Black);
            Pen redPen = new Pen(Color.Red);

            wrongPoints = 0;

            foreach (Point p in points)
            {
                float[] inputs = { p.x, p.y, p.bias};
                int target = p.label;

                int guess = perceptron.Guess(inputs);

                Brush brush;

                if (target == guess)
                {
                    brush = new SolidBrush(Color.Green);
                }
                else
                {
                    brush = new SolidBrush(Color.Red);
                    wrongPoints++;
                }

                formGraphics.DrawEllipse(blackPen, pictureBox.Width/2 + p.x, pictureBox.Height / 2 - p.y, 10, 10);
                formGraphics.FillEllipse(brush, pictureBox.Width / 2 + p.x, pictureBox.Height / 2 - p.y, 10, 10);

                brush.Dispose();
            }

            if (autoTrain)
            {
                DoTraining();
            }
            
            formGraphics.DrawLine(blackPen, pictureBox.Width / 2, 0, pictureBox.Width / 2, pictureBox.Width);
            formGraphics.DrawLine(blackPen, 0, pictureBox.Height / 2, pictureBox.Width, pictureBox.Height / 2);
            
            formGraphics.DrawLine(redPen, 0, pictureBox.Height/2 - function(- pictureBox.Width / 2), pictureBox.Width, pictureBox.Height / 2 - function(pictureBox.Width/2));
            
            var pfunction = perceptron.GetPrediction();
            formGraphics.DrawLine(blackPen, 0, pictureBox.Height / 2 - pfunction(-pictureBox.Width / 2), pictureBox.Width, pictureBox.Height / 2 - pfunction(pictureBox.Width / 2));
            
            pictureBox.Image = bm;

            blackPen.Dispose();
            redPen.Dispose();
            formGraphics.Dispose();
        }

        protected void UpdateInfo()
        {
            var sb = new StringBuilder();

            float pr_a = 0, pr_b = 0;
            perceptron.GetPredictedValues(out pr_a, out pr_b);

            sb.AppendFormat("Actual line: {0}x + ({1})\n\nPredictedLine: {2}x + ({3})\n\nError:\n\tA: {4}\n\tB: {5}\n\n", LINE_A, LINE_B, pr_a, pr_b, Math.Abs(LINE_A-pr_a), Math.Abs(LINE_B-pr_b));
            sb.AppendFormat("Number of trainings: {0}\n", trainings);
            sb.AppendFormat("Number of circles: {0} (errors: {1})", points.ToArray().Length, wrongPoints);

            CurrentStatusLabel.Text = sb.ToString();

            ModeLabel.Text = String.Format("AUTO MODE: {0}", autoTrain ? "ON" : "OFF");
        }

        protected void DoTraining()
        {
            foreach (Point p in points)
            {
                float[] inputs = { p.x, p.y, p.bias };
                perceptron.Train(inputs, p.label);
            }
            if (wrongPoints != 0)
            {
                trainings += 1;
            }
            UpdateInfo();
        }


        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            DoTraining();
        }
        
        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            Draw();
            InfoLabel.Text = perceptron.getWeights();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Enter: case Keys.A:
                    points.Add(new Point(function));
                    UpdateInfo();
                    break;
                case Keys.R:
                    points = new List<Point>();
                    UpdateInfo();
                    break;
                case Keys.Q:
                    perceptron.ReInit();
                    trainings = 0;
                    InfoLabel.Text = perceptron.getWeights();
                    UpdateInfo();
                    break;
                case Keys.U:
                    points = new List<Point>();
                    for(int i = 0; i<200; i++)
                    {
                        points.Add(new Point(function));
                        Thread.Sleep(1);
                    }
                    Draw();
                    UpdateInfo();
                    break;
                case Keys.T:
                    DoTraining();
                    break;
                case Keys.B:
                    autoTrain = autoTrain ? false : true;
                    UpdateInfo();
                    break;
                case Keys.L:
                    Task t = new Task(() => { GetLineValues(); });
                    t.Start();
                    break;
                default:
                    break;
            }
        }
    }
}
