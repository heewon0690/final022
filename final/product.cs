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
            plc.ActLogicalStationNumber = 1;
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

        private void attachUp_MouseDown(object sender, MouseEventArgs e)
        {
            plc.SetDevice("M2", 1);
            attachUp.MouseUp += delegate (object sender1, MouseEventArgs e1)
            {
                plc.SetDevice("M2", 0);
            };
        }

        private void attachDown_MouseDown(object sender, MouseEventArgs e)
        {
            plc.SetDevice("M1", 1);
            attachDown.MouseUp += delegate (object sender1, MouseEventArgs e1)
            {
                plc.SetDevice("M1", 0);
            };
        }
        int con;
        private void conStartBt_Click(object sender, EventArgs e)
        {
            plc.SetDevice("M3", 1);
            plc.GetDevice("Y28",out con);


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
            plc.GetDevice("Y28", out con);

            if(con == 0 && open ==0)
            {
                conTxt.Text = "종료";

            }

        }
    }
}
