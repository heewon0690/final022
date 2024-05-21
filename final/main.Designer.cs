namespace final
{
    partial class main
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Calendar_cal = new Calendar.NET.Calendar();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.09091F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.90909F));
            this.tableLayoutPanel1.Controls.Add(this.Calendar_cal, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1295, 680);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Calendar_cal
            // 
            this.Calendar_cal.AllowEditingEvents = true;
            this.Calendar_cal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Calendar_cal.CalendarDate = new System.DateTime(2024, 2, 14, 23, 10, 54, 584);
            this.Calendar_cal.CalendarView = Calendar.NET.CalendarViews.Month;
            this.Calendar_cal.CausesValidation = false;
            this.Calendar_cal.DateHeaderFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calendar_cal.DayOfWeekFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calendar_cal.DaysFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calendar_cal.DayViewTimeFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calendar_cal.DimDisabledEvents = true;
            this.Calendar_cal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Calendar_cal.HighlightCurrentDay = true;
            this.Calendar_cal.LoadPresetHolidays = true;
            this.Calendar_cal.Location = new System.Drawing.Point(3, 3);
            this.Calendar_cal.Margin = new System.Windows.Forms.Padding(3, 3, 23, 3);
            this.Calendar_cal.Name = "Calendar_cal";
            this.Calendar_cal.ShowArrowControls = true;
            this.Calendar_cal.ShowDashedBorderOnDisabledEvents = true;
            this.Calendar_cal.ShowDateInHeader = true;
            this.Calendar_cal.ShowDisabledEvents = false;
            this.Calendar_cal.ShowEventTooltips = true;
            this.Calendar_cal.ShowTodayButton = true;
            this.Calendar_cal.Size = new System.Drawing.Size(739, 402);
            this.Calendar_cal.TabIndex = 7;
            this.Calendar_cal.TodayFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "main";
            this.Size = new System.Drawing.Size(1295, 680);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Calendar.NET.Calendar Calendar_cal;
    }
}
