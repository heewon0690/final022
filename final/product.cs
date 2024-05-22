using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ActUtlTypeLib;
namespace final
{
    public partial class product : UserControl
    {
        ActUtlType plc = new ActUtlType();
        int open;
        int close;
        PictureBox process;
        public product()
        {
            InitializeComponent();

            process=new PictureBox();
            process.Image = Properties.Resources.process;
            process.SizeMode = PictureBoxSizeMode.StretchImage;
            process.Anchor = AnchorStyles.None;
            process.Size = new Size(800, 300);
            tablePanel.Controls.Add(process,1,1);
        }

        private void startBt_Click(object sender, EventArgs e)
        {
            plc.ActLogicalStationNumber = 2;
            open = plc.Open();
            if (open == 0)
            {
                statLb.Text = "연결성공";

            }

        }


        private void finishBt_Click(object sender, EventArgs e)
        {
            plc.ActLogicalStationNumber = 1;
            close = plc.Close();
            if (close == 0)
            {
                statLb.Text = "종료";
            }
        }

        int con;
        private void conStartBt_Click(object sender, EventArgs e)
        {
            plc.SetDevice("M3", 1);
            plc.GetDevice("Y30",out con);


            if (con == 1)
            {
                PictureBox pcb = new PictureBox();
                pcb.Image = Properties.Resources.pcb2;
                pcb.SizeMode = PictureBoxSizeMode.StretchImage;
                pcb.Size = new Size(30, 15);
                pcb.Location = new Point(520, 120);
                process.Controls.Add(pcb);

                conTxt.Text = "동작";

            }
            

        }

        private void conStopBt_Click(object sender, EventArgs e)
        {
            plc.SetDevice("M3", 0);
            plc.GetDevice("Y30", out con);

            if(con == 0 && open ==0)
            {
                conTxt.Text = "종료";

            }

        }


        private void attachUp_Click(object sender, EventArgs e)
        {
            plc.SetDevice("M61", 1);
            attach_lb.Text = "어태치 업";
        }

        private void attachDown_Click(object sender, EventArgs e)
        {
            plc.SetDevice("M61", 0);
            attach_lb.Text = "어태치 다운";
        }

        private void visionUp_Click(object sender, EventArgs e)
        {
            plc.SetDevice("M62", 1);
            vision_lb.Text = "비전 업";
        }

        private void visionDown_Click(object sender, EventArgs e)
        {
            plc.SetDevice("M62", 0);
            vision_lb.Text = "비전 다운";
        }

        private void moldUp_Click(object sender, EventArgs e)
        {
            plc.SetDevice("M63", 1);
            mold_lb.Text = "멀드 업";
        }

        private void moldDown_Click(object sender, EventArgs e)
        {
            plc.SetDevice("M63", 0);
            mold_lb.Text = "멀드 다운";
        }
    }
}
