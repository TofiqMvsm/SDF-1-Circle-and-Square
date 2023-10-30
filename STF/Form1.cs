using System.Windows.Forms;

namespace STDF
{
    public partial class Form1 : Form
    {
        int CordinateX = 200, CordinateY = 200;
        double SideOfSquare;
        double RadiusOfCircle;
        bool IsFilledOfSquare = true;
        bool IsFilledOfCircle = true;
        string ColorOfSquare;
        string ColorOfCircle;
        string ClickedButton;

        public Form1()
        {
            InitializeComponent();


        }

        private void Circle_Click(object sender, EventArgs e)
        {
            ClickedButton = "Circle";
            Circle c = new Circle();
            if (textbox.Text.Length != 0)
            {


                string text = textbox.Text;
                string[] parts = text.Split(' ').Select(part => part.Trim()).ToArray();
                Console.WriteLine(parts);
                if (parts.Length == 3)
                {
                    if (double.TryParse(parts[0], out double radius))
                    {
                        string color = parts[1];

                        if (bool.TryParse(parts[2], out bool filled))
                        {
                            c.radius = radius;
                            c.color = color;
                            c.filled = filled;
                        }
                    }
                }
                else if (parts.Length == 2)
                {

                    if (bool.TryParse(parts[1], out bool IsFilled))
                    {
                        c.radius = double.Parse(parts[0]);
                        c.filled = IsFilled;
                    }
                    else if (int.TryParse(parts[0], out int radius))
                    {
                        c.radius = radius;
                        c.color = parts[1];
                    }


                }

                else
                {
                    c.radius = Convert.ToDouble(textbox.Text);
                }

            }
           
            ColorOfCircle = c.color;
            RadiusOfCircle = c.radius;
            IsFilledOfCircle = c.filled;

            Invalidate();
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            ClickedButton = "Square";
            Square s = new Square();
            if (textbox.Text.Length != 0)
            {
                string text = textbox.Text;
                string[] parts = text.Split(' ').Select(part => part.Trim()).ToArray();

                if (parts.Length == 3)
                {
                    if (double.TryParse(parts[0], out double side))
                    {
                        string color = parts[1];

                        if (bool.TryParse(parts[2], out bool filled))
                        {
                            s.side = side;
                            s.color = color;
                            s.filled = filled;
                        }
                    }
                }
               else if (parts.Length == 2)
                {

                    if (bool.TryParse(parts[1], out bool IsFilled))
                    {
                        s.side = double.Parse(parts[0]);
                        s.filled = IsFilled;
                    }
                    else if (int.TryParse(parts[0], out int side))
                    {
                        s.side = side;
                        s.color = parts[1];
                    }


                }
                else
                {
                    s.side = Convert.ToDouble(textbox.Text);
                }
            }
           

            ColorOfSquare = s.color;
            SideOfSquare = s.side;
            IsFilledOfSquare = s.filled;
            Invalidate();
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (ClickedButton == "Square")
            {
                string colorNameForSquare = ColorOfSquare;
                Color customColor = Color.FromName(colorNameForSquare);
                Pen customPen = new Pen(customColor, 2);

                if (IsFilledOfSquare)
                {
                    Brush customBrush = new SolidBrush(customColor);
                    e.Graphics.FillRectangle(customBrush, CordinateX, CordinateY, (int)SideOfSquare, (int)SideOfSquare);
                    customBrush.Dispose();
                }
                else
                {
                    e.Graphics.DrawRectangle(customPen, CordinateX, CordinateY, (int)SideOfSquare, (int)SideOfSquare);
                }

                customPen.Dispose();
            }
            else if (ClickedButton == "Circle")
            {
                string colorNameForCircle = ColorOfCircle;
                Color customColor = Color.FromName(colorNameForCircle);
                Pen customPen = new Pen(customColor, 2);

                if (IsFilledOfCircle)
                {
                    Brush customBrush = new SolidBrush(customColor);
                    e.Graphics.FillEllipse(customBrush, CordinateX, CordinateY, (int)RadiusOfCircle, (int)RadiusOfCircle);
                    customBrush.Dispose();
                }
                else
                {
                    e.Graphics.DrawEllipse(customPen, CordinateX, CordinateY, (int)RadiusOfCircle, (int)RadiusOfCircle);
                }

                customPen.Dispose();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (ClickedButton == "Circle")
            {
                Move(RadiusOfCircle, RadiusOfCircle);

            }
            else if (ClickedButton == "Square")
            {
                Move(SideOfSquare, SideOfSquare);

            }
            void Move(double num1, double num2)
            {
                if (e.KeyData == Keys.Right)
                {
                    CordinateX += 10;
                    if (CordinateX >= 290 - (int)num1)
                    {
                        CordinateX = 290 - (int)num2;
                    }
                }
                if (e.KeyData == Keys.Left)
                {
                    CordinateX -= 10;
                    if (CordinateX <= 45)
                    {
                        CordinateX = 45;
                    }
                }
                if (e.KeyData == Keys.Up)
                {
                    CordinateY -= 10;
                    if (CordinateY <= 130)
                    {
                        CordinateY = 130;
                    }
                }
                if (e.KeyData == Keys.Down)
                {
                    CordinateY += 10;
                    if (CordinateY >= 380 - (int)num1)
                    {
                        CordinateY = 380 - (int)num2;
                    }
                }
            }
            Invalidate();

        }

       
    }

}