using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Labone_UI
{
    public class ShuzukoPanel : Panel
    {
        // Fields (thuộc tính riêng)
        private int borderRadius = 30;
        private float gradientAngle = 90F;
        private Color gradientTopColor = Color.DodgerBlue;
        private Color gradientBottomColor = Color.DodgerBlue;

        // Constructor (hàm khởi tạo)
        public ShuzukoPanel()
        {
            this.BackColor = Color.White; // Màu nền mặc định
            this.ForeColor = Color.Black; // Màu chữ mặc định
            this.DoubleBuffered = true;   // Bật DoubleBuffered để tránh flicker
            this.Resize += new EventHandler(OnResize); // Gọi lại khi kích thước thay đổi
        }

        // Properties (thuộc tính công khai)
        public int BorderRadius
        {
            get => borderRadius;
            set
            {
                borderRadius = value;
                UpdateRegion(); // Cập nhật bo góc khi giá trị thay đổi
            }
        }

        public float GradientAngle
        {
            get => gradientAngle;
            set
            {
                gradientAngle = value;
                this.Invalidate();
            }
        }

        public Color GradientTopColor
        {
            get => gradientTopColor;
            set
            {
                gradientTopColor = value;
                this.Invalidate();
            }
        }

        public Color GradientBottomColor
        {
            get => gradientBottomColor;
            set
            {
                gradientBottomColor = value;
                this.Invalidate();
            }
        }

        // Method: Tạo vùng góc bo tròn
        private GraphicsPath GetShuzukoPath(RectangleF rectangle, float radius)
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            float curveSize = radius * 2F;

            graphicsPath.StartFigure();
            graphicsPath.AddArc(rectangle.X, rectangle.Y, curveSize, curveSize, 180, 90); // Top-left
            graphicsPath.AddArc(rectangle.Right - curveSize, rectangle.Y, curveSize, curveSize, 270, 90); // Top-right
            graphicsPath.AddArc(rectangle.Right - curveSize, rectangle.Bottom - curveSize, curveSize, curveSize, 0, 90); // Bottom-right
            graphicsPath.AddArc(rectangle.X, rectangle.Bottom - curveSize, curveSize, curveSize, 90, 90); // Bottom-left
            graphicsPath.CloseFigure();

            return graphicsPath;
        }

        // Method: Cập nhật vùng bo tròn (Region) khi kích thước thay đổi
        private void UpdateRegion()
        {
            if (borderRadius > 2)
            {
                using (GraphicsPath path = GetShuzukoPath(new RectangleF(0, 0, this.Width, this.Height), borderRadius))
                {
                    this.Region = new Region(path);
                }
            }
            else
            {
                this.Region = new Region(new RectangleF(0, 0, this.Width, this.Height));
            }
            this.Invalidate(); // Yêu cầu vẽ lại
        }

        // Override sự kiện Resize để cập nhật lại bo góc
        private void OnResize(object sender, EventArgs e)
        {
            UpdateRegion(); // Gọi lại khi kích thước thay đổi
        }

        // Override sự kiện OnPaint để vẽ gradient và border
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Vẽ gradient
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, gradientTopColor, gradientBottomColor, gradientAngle))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }

            // Vẽ bo tròn border
            if (borderRadius > 2)
            {
                using (GraphicsPath path = GetShuzukoPath(ClientRectangle, borderRadius))
                using (Pen pen = new Pen(this.Parent?.BackColor ?? SystemColors.Control, 2))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        // Override sự kiện OnParentChanged để đảm bảo khi Parent thay đổi, giao diện cũng được vẽ lại
        protected override void OnParentChanged(EventArgs e)
        {
            base.OnParentChanged(e);
            this.Invalidate(); // Gọi lại vẽ khi Parent thay đổi
        }
    }
}
