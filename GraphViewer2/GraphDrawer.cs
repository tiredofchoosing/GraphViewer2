using System;
using System.Drawing;
using System.Windows.Forms;

namespace GraphViewer2
{
    class GraphDrawer
    {
        private readonly Color gridLineColor = Color.LightGray;
        private readonly Color axisLineColor = Color.Gray;
        private readonly Color graphLineColor = Color.DeepPink;

        private readonly PictureBox graphField;

        public delegate float Calculate(float x);

        private bool IsClear { get; set; }
        private Calculate LastGraph { get; set; }
        public int ScaleFactor { get; set; }

        public GraphDrawer(PictureBox pictureBox)
        {
            graphField = pictureBox;
            graphField.Image = new Bitmap(graphField.Width, graphField.Height);
            ScaleFactor = 1;
            LastGraph = null;
            IsClear = false;
        }

        public void ClearField()
        {
            var width = graphField.Width;
            var height = graphField.Height;

            var graphScale = ScaleFactor;
            var gridLen = 5 * graphScale;
            var axisPen = new Pen(axisLineColor, 1);
            var gridPen = new Pen(gridLineColor, 1);

            axisPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            gridPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;

            using (Graphics graphics = Graphics.FromImage(graphField.Image))
            {
                graphics.Clear(Color.White);
                graphics.DrawLine(axisPen, 0, height / 2, width, height / 2);
                graphics.DrawLine(axisPen, width / 2, 0, width / 2, height);

                for (var i = gridLen; i < width / 2; i += gridLen)
                {
                    graphics.DrawLine(gridPen, width / 2 + i, 0, width / 2 + i, height);
                    graphics.DrawLine(gridPen, width / 2 - i, 0, width / 2 - i, height);
                }
                for (var i = gridLen; i < height / 2; i += gridLen)
                {
                    graphics.DrawLine(gridPen, 0, height / 2 + i, width, height / 2 + i);
                    graphics.DrawLine(gridPen, 0, height / 2 - i, width, height / 2 - i);
                }
            }
            IsClear = true;
        }

        public void DrawGraph(Calculate calc)
        {
            //if (LastGraph != calc)
            //{
                if (!IsClear)
                    ClearField();

                var points = GetPoints(calc);
                var graphPen = new Pen(graphLineColor, 2);

                graphField.Invalidate();
                using (Graphics graphics = Graphics.FromImage(graphField.Image))
                {
                    graphics.DrawBeziers(graphPen, points);
                }
                graphField.Update();
                IsClear = false;
                LastGraph = calc;
            //}
        }

        private PointF[] GetPoints(Calculate calc)
        {
            int width = graphField.Width;
            int height = graphField.Height;
            int graphScale = ScaleFactor;
            int count = width;

            var points = new PointF[count];
            for (var i = 0; i < count; i++)
            {
                //float x = (i * width / (float)count - width / 2f) / graphScale;
                float x = (i - width / 2f) / graphScale;
                float y = -calc(x);
                points[i] = new PointF(x * graphScale + width / 2, y * graphScale + height / 2);
            }

            return points;
        }

        public void Update()
        {
            if (LastGraph != null)
            {
                DrawGraph(LastGraph);
            }
        }
    }
}
