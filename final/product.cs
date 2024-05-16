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

        public product()
        {
            InitializeComponent();
        }

        private void startBt_Click(object sender, EventArgs e)
        {
            plc.ActLogicalStationNumber = 1;
            int nRtn = plc.Open();
            if (nRtn == 0)
            {
                statLb.Text = "연결성공";  
            }
        }

        private void finishBt_Click(object sender, EventArgs e)
        {
            plc.ActLogicalStationNumber = 1;
            int nRtn = plc.Close();
            if (nRtn == 0)
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
    }
}
