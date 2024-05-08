namespace final
{
    partial class Navigation
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.slidePanel = new System.Windows.Forms.Panel();
            this.manageCk = new System.Windows.Forms.CheckBox();
            this.productCk = new System.Windows.Forms.CheckBox();
            this.OutBt = new System.Windows.Forms.Button();
            this.InBt = new System.Windows.Forms.Button();
            this.warehouseCk = new System.Windows.Forms.CheckBox();
            this.slideCk = new System.Windows.Forms.CheckBox();
            this.panelTimer = new System.Windows.Forms.Timer(this.components);
            this.input = new final.Input();
            this.slidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // slidePanel
            // 
            this.slidePanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.slidePanel.Controls.Add(this.manageCk);
            this.slidePanel.Controls.Add(this.productCk);
            this.slidePanel.Controls.Add(this.OutBt);
            this.slidePanel.Controls.Add(this.InBt);
            this.slidePanel.Controls.Add(this.warehouseCk);
            this.slidePanel.Controls.Add(this.slideCk);
            this.slidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.slidePanel.Location = new System.Drawing.Point(0, 0);
            this.slidePanel.Name = "slidePanel";
            this.slidePanel.Size = new System.Drawing.Size(200, 1033);
            this.slidePanel.TabIndex = 0;
            // 
            // manageCk
            // 
            this.manageCk.Appearance = System.Windows.Forms.Appearance.Button;
            this.manageCk.Dock = System.Windows.Forms.DockStyle.Top;
            this.manageCk.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.manageCk.Location = new System.Drawing.Point(0, 250);
            this.manageCk.Name = "manageCk";
            this.manageCk.Size = new System.Drawing.Size(200, 50);
            this.manageCk.TabIndex = 19;
            this.manageCk.Text = "관리";
            this.manageCk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.manageCk.UseVisualStyleBackColor = true;
            // 
            // productCk
            // 
            this.productCk.Appearance = System.Windows.Forms.Appearance.Button;
            this.productCk.Dock = System.Windows.Forms.DockStyle.Top;
            this.productCk.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.productCk.Location = new System.Drawing.Point(0, 200);
            this.productCk.Name = "productCk";
            this.productCk.Size = new System.Drawing.Size(200, 50);
            this.productCk.TabIndex = 18;
            this.productCk.Text = "생산";
            this.productCk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.productCk.UseVisualStyleBackColor = true;
            // 
            // OutBt
            // 
            this.OutBt.Dock = System.Windows.Forms.DockStyle.Top;
            this.OutBt.Location = new System.Drawing.Point(0, 150);
            this.OutBt.Name = "OutBt";
            this.OutBt.Size = new System.Drawing.Size(200, 50);
            this.OutBt.TabIndex = 16;
            this.OutBt.Text = "출고 창고";
            this.OutBt.UseVisualStyleBackColor = true;
            // 
            // InBt
            // 
            this.InBt.Dock = System.Windows.Forms.DockStyle.Top;
            this.InBt.Location = new System.Drawing.Point(0, 100);
            this.InBt.Name = "InBt";
            this.InBt.Size = new System.Drawing.Size(200, 50);
            this.InBt.TabIndex = 15;
            this.InBt.Text = "입고 창고";
            this.InBt.UseVisualStyleBackColor = true;
            // 
            // warehouseCk
            // 
            this.warehouseCk.Appearance = System.Windows.Forms.Appearance.Button;
            this.warehouseCk.Dock = System.Windows.Forms.DockStyle.Top;
            this.warehouseCk.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.warehouseCk.Location = new System.Drawing.Point(0, 50);
            this.warehouseCk.Name = "warehouseCk";
            this.warehouseCk.Size = new System.Drawing.Size(200, 50);
            this.warehouseCk.TabIndex = 14;
            this.warehouseCk.Text = "창고";
            this.warehouseCk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.warehouseCk.UseVisualStyleBackColor = true;
            this.warehouseCk.CheckedChanged += new System.EventHandler(this.warehouseCk_CheckedChanged);
            // 
            // slideCk
            // 
            this.slideCk.Appearance = System.Windows.Forms.Appearance.Button;
            this.slideCk.Dock = System.Windows.Forms.DockStyle.Top;
            this.slideCk.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.slideCk.Location = new System.Drawing.Point(0, 0);
            this.slideCk.Name = "slideCk";
            this.slideCk.Size = new System.Drawing.Size(200, 50);
            this.slideCk.TabIndex = 6;
            this.slideCk.Text = ">";
            this.slideCk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.slideCk.UseVisualStyleBackColor = true;
            this.slideCk.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panelTimer
            // 
            this.panelTimer.Tick += new System.EventHandler(this.panelTimer_Tick);
            // 
            // input
            // 
            this.input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.input.Location = new System.Drawing.Point(200, 0);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(1702, 1033);
            this.input.TabIndex = 1;
            // 
            // Navigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.input);
            this.Controls.Add(this.slidePanel);
            this.Name = "Navigation";
            this.Text = "반도체 생산";
            this.Load += new System.EventHandler(this.Navigation_Load);
            this.slidePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel slidePanel;
        private System.Windows.Forms.Timer panelTimer;
        private System.Windows.Forms.CheckBox manageCk;
        private System.Windows.Forms.CheckBox productCk;
        private System.Windows.Forms.Button OutBt;
        private System.Windows.Forms.Button InBt;
        private System.Windows.Forms.CheckBox warehouseCk;
        private System.Windows.Forms.CheckBox slideCk;
        private Input input;
    }
}

