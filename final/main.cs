using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using FFmpeg;
using System.Diagnostics;
using Calendar.NET;

namespace final
{
    public partial class main : UserControl
    {
       

        public main()
        {
            InitializeComponent();
            AddCalendar();

        }
        private void AddCalendar()
        {
            Calendar_cal.CalendarDate = DateTime.Now;
            Calendar_cal.CalendarView = CalendarViews.Month;
            Calendar_cal.LoadPresetHolidays = false;
            Calendar_cal.AllowEditingEvents = true;
            // 이벤트 생성
            var groundhogEvent = new HolidayEvent
            {
                Date = DateTime.Now,
                RecurringFrequency = RecurringFrequencies.EveryWeekend,
                EventTextColor = Color.Red
            };
            Calendar_cal.AddEvent(groundhogEvent);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            /*string path = "rtsp://10.10.32.212:8554/mjpeg/1";
            VideoCapture vc = new VideoCapture();
            vc.Open(path);

            Mat image = new Mat();
            vc.Read(image);*/

        }



        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void main_Load(object sender, EventArgs e)
        {

        }
    }
}
