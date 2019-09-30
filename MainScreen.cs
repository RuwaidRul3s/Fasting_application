using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;
using System.Runtime.InteropServices;
using TimeClass;
using System.Threading;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Media;
[Serializable]
struct Fasting_Chart
{
   public int  Day;
    public int totalFastedTime;
}
enum Days
{
    Sun,Mon,Tue, Wed, Thu,Fri, Sat
}
namespace Fasting_Application
{

    public partial class MainScreen : Form
    {
         
        public MainScreen()
        {
            FastingWindow = new Rectangle(40,100, 200, 200);
            string user = Path.GetDirectoryName(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
            FileName = user + "Fasting";
            User_Chart_File = user + "Chart";
            if(!File.Exists(User_Chart_File))
            {
                File.Create(User_Chart_File).Dispose();
            }
            InitializeComponent();
           
        }
        private string User_Chart_File;
        private bool Drag = false;
        private Point startpoint = new Point(0, 0);
        private float angle = 10.0f;
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            SolidBrush TextColor = new SolidBrush(Color.FromArgb(204, 24, 65));
            Pen Elipse_Color = new Pen(Color.FromArgb(150, 150, 150), 10.0f);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            DoubleBuffered = true;
            e.Graphics.DrawEllipse(Elipse_Color, 50, 120, 150, 150);
            Elipse_Color.Color = Color.FromArgb(204, 24, 65);
            e.Graphics.DrawArc(Elipse_Color, 50, 120, 150, 150, 265,angle);
            Elipse_Color.Dispose();
            /*DRAW LABELS to indicate the fasting prototype
             the user have reached*/
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(204, 24, 65)),
                625, 59, 20,20);
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(255, 77, 121)),
               525, 59, 20, 20);
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(153, 0, 204)),
              460, 59, 20, 20);
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(102, 51, 255)),
             385, 59, 20, 20);
            //draw Fastd hours Label
            e.Graphics.TranslateTransform(340, 200);
            e.Graphics.RotateTransform(90.0f);
            e.Graphics.DrawString("Fasted Hours", new Font("Arial", 20, FontStyle.Regular
                , GraphicsUnit.Pixel), new SolidBrush(Color.FromArgb(204, 24, 65)),
                5, 0);
            e.Graphics.ResetTransform();
            Elipse_Color.Dispose();
            TextColor.Dispose();
        }
       
        private void TitleBar_MouseClick(object sender, MouseEventArgs e)
        {
          
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            TWO.Checked = false;
            THREE.Checked = false;
        }



        private void ONE_Click(object sender, EventArgs e)
        {
            TWO.Checked = false;
            THREE.Checked = false;
        }

        private void TWO_Click(object sender, EventArgs e)
        {
            ONE.Checked = false;
            THREE.Checked = false;
        }

        private void THREE_Click(object sender, EventArgs e)
        {
            ONE.Checked = false;
            TWO.Checked = false;
        }

        private void STARTFASTING_Click(object sender, EventArgs e)
        {
            Fasting_Time fast_time = new Fasting_Time();
            fast_time.SetTime(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);

            if (ONE.Checked)  // if the user chosse OMAD =current time -1 the other day
            {
                fast_time.Fasting_ProtoType = (int) Fasting_Types.OMAD;
                fast_time.SubtractTime(fast_time, 1, 0, 0);
            }
            else if (TWO.Checked) // 16/8
            {
                fast_time.Fasting_ProtoType = (int)Fasting_Types.SixtennHours;
                fast_time.SubtractTime(fast_time, 8, 0, 0);
            }
            else if (THREE.Checked) // 20/4
            {
                fast_time.Fasting_ProtoType = (int)Fasting_Types.TwentyHours;

                fast_time.SubtractTime(fast_time, 4, 0, 0);
            }
            Save_Date(fast_time);
            timer1.Enabled = true;
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {

        }

        private string FileName;


        private void Save_Date(Fasting_Time TimeObject)
        {

            BinaryFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(FileName, FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, TimeObject);
            stream.Close();
            
        }
        private void Read_Date(ref Fasting_Time TimeObject)
        { 
                BinaryFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(FileName, FileMode.Open, FileAccess.Read);
                TimeObject = (Fasting_Time)formatter.Deserialize(stream);
            stream.Close();
        }
        private Rectangle FastingWindow;
        private void timer1_Tick(object sender, EventArgs e)
        {

            Fasting_Time RemaingTime = new Fasting_Time();

            if (File.Exists(FileName))
            {
                Read_Date(ref RemaingTime);
               
                RemaingTime.SubtractTime(RemaingTime, DateTime.Now.Hour, DateTime.Now.Minute,
                          DateTime.Now.Second);
                if (RemaingTime.Fast_State)
                {
                    PercentLabel.Text = string.Format("{0:F3}", "100.00").ToString() + "%";
                    angle = 360.0f;
                    Fasted_hours.Text = "Fast Complete";
                    Save_Date(RemaingTime);
                    timer1.Enabled = false;

                }
                else
                {
                    Fasted_hours.Text = RemaingTime.Hours.ToString().PadLeft(2, '0') + ":" +
                    RemaingTime.Minutes.ToString().PadLeft(2, '0') + ":" +
                    RemaingTime.Seconds.ToString().PadLeft(2, '0') + " Hours Left";
                    float percentage = Calculate_Percentage(RemaingTime);
                    angle = ProgressBar_Progress(percentage);
                  

                    PercentLabel.Text = string.Format("{0:F3}",percentage).ToString() + "%";
                   
                     
                }
                this.Invalidate(FastingWindow);
            }
        }
        private float Calculate_Percentage(Fasting_Time RemTime)
        {
            float total_Fast_time = 0.0f;
            float remainigTime_Minutes = (RemTime.Hours * 60) + (RemTime.Minutes) + (RemTime.Seconds / 60.0f);
            if (RemTime.Fasting_ProtoType == (int)Fasting_Types.OMAD)
            {
                 total_Fast_time = (22 * 60) + 59 + 59 / 60.0f;
            }
            else if(RemTime.Fasting_ProtoType == (int)Fasting_Types.SixtennHours)
            {
                total_Fast_time = (15 * 60) + 59 + 59 / 60.0f;
            }
            else if (RemTime.Fasting_ProtoType == (int)Fasting_Types.TwentyHours)
            {
                total_Fast_time = (19 * 60) + 59 + 59 / 60.0f;
            }
            return (Math.Abs((remainigTime_Minutes- total_Fast_time)) / total_Fast_time) *100.0f;
        }
        private float ProgressBar_Progress(float percentage)
        {
            double roundedPercentage = Math.Round(percentage,2);
            double Angle_progrss = (roundedPercentage / 100.0f) * 360.0f;
            return (float)Angle_progrss;
        }

        private void TitleBar_MouseMove(object sender, MouseEventArgs e)
        {
           if(Drag)
            {
                this.Left += e.X - startpoint.X;
                this.Top += e.Y - startpoint.Y;
            }
        }

        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            Drag = true;
            startpoint = new Point(e.X, e.Y);
        }

        private void TitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            Drag = false;
        }
        private void Save_Chart_Date(Fasting_Chart fastingChart)
        {
            BinaryFormatter bf = new BinaryFormatter();
            Stream stream = new FileStream(User_Chart_File,
                FileMode.Append, FileAccess.Write);
            bf.Serialize(stream, fastingChart);
            stream.Close();
        }
        private void END_FASTING_Click(object sender, EventArgs e)
        {
             
            Fasting_Time fast_time = new Fasting_Time();
            Fasting_Chart fc;
            Read_Date(ref fast_time);
            if (fast_time.Fast_State == false&&!fast_time.Marked)
            {
                int total_fasted_hours = 0;
                fast_time.SubtractTime(fast_time, DateTime.Now.Hour, DateTime.Now.Minute
                    , DateTime.Now.Second);
                int RemaingTime_minutes = (fast_time.Hours * 60) +
                    (fast_time.Minutes);
                 if (fast_time.Fasting_ProtoType==(int)Fasting_Types.OMAD)
                {
                      total_fasted_hours = ((22 * 60) + 59)- RemaingTime_minutes;
                }
                 else if(fast_time.Fasting_ProtoType == (int)Fasting_Types.SixtennHours)
                {
                    total_fasted_hours = ((15 * 60) + 59) - RemaingTime_minutes;
                }
                 else if(fast_time.Fasting_ProtoType == (int)Fasting_Types.TwentyHours)
                {
                    total_fasted_hours = ((19 * 60) + 59) - RemaingTime_minutes;
                }
                fc.totalFastedTime = total_fasted_hours;
                fc.Day = (int)DateTime.Now.DayOfWeek;
                fast_time.Fast_State = true;
                fast_time.Marked = true;
                Save_Date(fast_time);
                Save_Chart_Date(fc);
            }
        }

        private void Chart_panel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            SolidBrush RectangleColor = new SolidBrush(Color.FromArgb(102, 51, 255));
            Pen LineColor = new Pen(Color.FromArgb(115,115,115));
            SolidBrush TextColor = new SolidBrush(Color.FromArgb(204, 24, 65));
            //draw the axis
            e.Graphics.DrawLine(LineColor, 50,275, 340,275);
            e.Graphics.DrawLine(LineColor, 50, 275, 50, 5);
            int XPos = 50;
            for (int day = 0; day < 7; day++)
            {
                e.Graphics.DrawString(Enum.GetName(typeof(Days),day),new Font("Arial",16,FontStyle.Regular,GraphicsUnit.Pixel), TextColor, XPos, 280);
                XPos += 40;
            }
            // first day is 0
            //and the nday=50*n
            e.Graphics.DrawString("Days", new Font("Arial", 20, FontStyle.Regular, GraphicsUnit.Pixel), TextColor, 150, 335);
            //draw fasted hours Y-Values
            int Y_ = 230;
            int factor = 1;
            int Y = 4;
            while (factor <= 6)
            {
               

                e.Graphics.DrawString((Y * factor).ToString().PadLeft(2, '0'), new Font("Arial", 16, FontStyle.Regular
                   , GraphicsUnit.Pixel), TextColor, 23, Y_);
                Y_ -= 45;

                factor++;
            }
            Fasting_Chart chart;
            BinaryFormatter bf = new BinaryFormatter();
            Stream stream = new FileStream(User_Chart_File,
                FileMode.Open, FileAccess.Read);
            while (stream.Position<stream.Length)
            {
                
                chart = (Fasting_Chart)bf.Deserialize(stream);
                int totalHours = chart.totalFastedTime / 60;
                float Ypos = 275-((chart.totalFastedTime / 60.0f) * 11.25f);
                if (totalHours < 16)
                    RectangleColor.Color = Color.FromArgb(102, 51, 255);
                else if(totalHours>=16&&totalHours<20)
                    RectangleColor.Color = Color.FromArgb(153, 0, 204);
                else if (totalHours >= 20 && totalHours < 23)
                    RectangleColor.Color = Color.FromArgb(255, 77, 121);
                else if (totalHours==24)
                    RectangleColor.Color = Color.FromArgb(204,24,65);
                e.Graphics.FillRectangle(RectangleColor,
                   50 * chart.Day, Ypos, 30,275.0f-Ypos);
            }
            stream.Close();
        }
    }
    }