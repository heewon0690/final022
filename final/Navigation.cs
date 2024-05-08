using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final
{
    public partial class Navigation : Form
    {
        const int MAX_WIDTH = 200;
        const int MIN_WIDTH = 50;
        const int STEP_WIDTH = 30;
        int Sliding = 200;

        public Navigation()
        {
            InitializeComponent();
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(slideCk.Checked==true)
            {
                warehouseCk.Text = "1";
                productCk.Text = "2";
                manageCk.Text = "3";
                slideCk.Text = "=";
                InBt.Visible = false;
                OutBt.Visible = false;
            }
            else
            {
                warehouseCk.Text = "창고";
                productCk.Text = "생산";
                manageCk.Text = "관리";
                slideCk.Text = "=";
            }
            panelTimer.Start();
        }

        private void Navigation_Load(object sender, EventArgs e)
        {

        }


        private void warehouseBt_Click(object sender, EventArgs e)
        {

        }

        private void panelTimer_Tick(object sender, EventArgs e)
        {
            if (slideCk.Checked == true)
            {
                //슬라이딩 메뉴를 숨기는 동작
                Sliding -= STEP_WIDTH;
                if (Sliding <= MIN_WIDTH)
                    panelTimer.Stop();
            }
            else
            {
                //슬라이딩 메뉴를 보이는 동작
                Sliding += STEP_WIDTH;
                if (Sliding >= MAX_WIDTH)
                    panelTimer.Stop();
            }
            slidePanel.Width = Sliding;
        }

        private void warehouseCk_CheckedChanged(object sender, EventArgs e)
        {

            if(warehouseCk.Checked == true)
            {
                InBt.Visible = true;
                OutBt.Visible = true;
            }
            else
            {
                InBt.Visible = false;
                OutBt.Visible = false;
            }
        }
    }
}
