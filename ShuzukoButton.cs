using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace Labone_UI
{
    public class ShuzukoButton : Button
    {
        // Fields
        private int borderSize = 0;
        private int borderRadius = 20;
        private Color borderColor = Color.PaleVioletRed;

        private int textOffsetX = 0;
        private int textOffsetY = 0;
        private ContentAlignment textAlign = ContentAlignment.MiddleCenter;

        // Constructor
        public ShuzukoButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
            this.Resize += new EventHandler(Button_Resize);
            this.Text = ""; // Ngăn chặn văn bản mặc định
        }

        private void Button_Resize(object sender, EventArgs e)
        {
            if (borderRadius > this.Height)
                borderRadius = this.Height;
        }

        // Properties for Text Offset
        [Category("Shuzuko Code Advance")]
        public int TextOffsetX
        {
            get { return textOffsetX; }
            set { textOffsetX = value; this.Invalidate(); }
        }

        [Category("Shuzuko Code Advance")]
        public int TextOffsetY
        {
            get { return textOffsetY; }
            set { textOffsetY = value; this.Invalidate(); }
        }

        [Category("Shuzuko Code Advance")]
        public ContentAlignment TextAlign
        {
            get { return textAlign; }
            set { textAlign = value; this.Invalidate(); }
        }

        // Overridden OnPaint method
        protected override void OnPaint(PaintEventArgs pevent)
        {
            string originalText = this.Text;
            this.Text = "";

            base.OnPaint(pevent);
            this.Text = originalText;

            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);
            int smoothSize = 2;
            if (borderSize > 0)
                smoothSize = borderSize;

            if (borderRadius > 2) //Rounded button
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penSurface = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    this.Region = new Region(pathSurface);
                    pevent.Graphics.DrawPath(penSurface, pathSurface);

                    if (borderSize >= 1)
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else //Normal button
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.None;
                this.Region = new Region(rectSurface);

                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }

            // Tính toán vị trí văn bản dựa trên thuộc tính TextAlign hoặc các giá trị TextOffsetX, TextOffsetY
            PointF textLocation;
            if (textOffsetX != 0 || textOffsetY != 0)
            {
                // Nếu có TextOffsetX hoặc TextOffsetY, ưu tiên sử dụng chúng
                textLocation = new PointF(textOffsetX, textOffsetY);
            }
            else
            {
                // Nếu TextOffsetX và TextOffsetY đều bằng 0, sử dụng TextAlign
                var textSize = pevent.Graphics.MeasureString(originalText, this.Font);
                textLocation = GetTextLocation(rectSurface, textSize);
            }

            using (SolidBrush textBrush = new SolidBrush(this.ForeColor))
            {
                pevent.Graphics.DrawString(originalText, this.Font, textBrush, textLocation);
            }
        }

        // Phương thức tính toán vị trí văn bản dựa trên TextAlign
        private PointF GetTextLocation(Rectangle rect, SizeF textSize)
        {
            float x = 0;
            float y = 0;

            switch (textAlign)
            {
                case ContentAlignment.TopLeft:
                    x = rect.Left;
                    y = rect.Top;
                    break;
                case ContentAlignment.TopCenter:
                    x = rect.Left + (rect.Width - textSize.Width) / 2;
                    y = rect.Top;
                    break;
                case ContentAlignment.TopRight:
                    x = rect.Right - textSize.Width;
                    y = rect.Top;
                    break;
                case ContentAlignment.MiddleLeft:
                    x = rect.Left;
                    y = rect.Top + (rect.Height - textSize.Height) / 2;
                    break;
                case ContentAlignment.MiddleCenter:
                    x = rect.Left + (rect.Width - textSize.Width) / 2;
                    y = rect.Top + (rect.Height - textSize.Height) / 2;
                    break;
                case ContentAlignment.MiddleRight:
                    x = rect.Right - textSize.Width;
                    y = rect.Top + (rect.Height - textSize.Height) / 2;
                    break;
                case ContentAlignment.BottomLeft:
                    x = rect.Left;
                    y = rect.Bottom - textSize.Height;
                    break;
                case ContentAlignment.BottomCenter:
                    x = rect.Left + (rect.Width - textSize.Width) / 2;
                    y = rect.Bottom - textSize.Height;
                    break;
                case ContentAlignment.BottomRight:
                    x = rect.Right - textSize.Width;
                    y = rect.Bottom - textSize.Height;
                    break;
            }

            return new PointF(x, y);
        }

        // Method to create rounded button
        private GraphicsPath GetFigurePath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        // Other properties for border settings
        [Category("Shuzuko Code Advance")]
        public int BorderSize
        {
            get { return borderSize; }
            set { borderSize = value; this.Invalidate(); }
        }

        [Category("Shuzuko Code Advance")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set { borderRadius = value; this.Invalidate(); }
        }

        [Category("Shuzuko Code Advance")]
        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; this.Invalidate(); }
        }

        [Category("Shuzuko Code Advance")]
        public Color BackgroundColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }

        [Category("Shuzuko Code Advance")]
        public Color TextColor
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }
        }
    }
}
