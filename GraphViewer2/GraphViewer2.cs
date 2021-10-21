using System;
using System.Windows.Forms;

namespace GraphViewer2
{
    public partial class GraphViewer2 : Form
    {
        private readonly GraphDrawer gd;

        public GraphViewer2()
        {
            InitializeComponent();

            gd = new GraphDrawer(graphField);
            gd.ScaleFactor = trackBar.Value;
            gd.ClearField();
        }

        private static float CalcGraph1(float x) => 2;
        private static float CalcGraph2(float x) => (float)Math.Cos(x) * 2;
        private static float CalcGraph3(float x) => (float)Math.Tan(x) * 2;

        private void graph1Button_Click(object sender, EventArgs e)
        {
            gd.DrawGraph(CalcGraph1);
        }

        private void graph2Button_Click(object sender, EventArgs e)
        {
            gd.DrawGraph(CalcGraph2);
        }

        private void graph3Button_Click(object sender, EventArgs e)
        {
            gd.DrawGraph(CalcGraph3);
        }

        private void trackBar_ValueChanged(object sender, EventArgs e)
        {
            gd.ScaleFactor = trackBar.Value;
            gd.Update();
        }
    }
}
