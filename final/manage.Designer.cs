namespace final
{
    partial class manage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.registerBt = new System.Windows.Forms.Button();
            this.askBt = new System.Windows.Forms.Button();
            this.login_grid = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.departCom = new System.Windows.Forms.ComboBox();
            this.positionCom = new System.Windows.Forms.ComboBox();
            this.cdatePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.pnumTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.login_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nameTxt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.departCom);
            this.panel1.Controls.Add(this.positionCom);
            this.panel1.Controls.Add(this.cdatePicker);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pnumTxt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.registerBt);
            this.panel1.Controls.Add(this.askBt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1226, 149);
            this.panel1.TabIndex = 1;
            // 
            // registerBt
            // 
            this.registerBt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.registerBt.AutoSize = true;
            this.registerBt.Location = new System.Drawing.Point(1128, 83);
            this.registerBt.Name = "registerBt";
            this.registerBt.Size = new System.Drawing.Size(75, 25);
            this.registerBt.TabIndex = 30;
            this.registerBt.Text = "등록";
            this.registerBt.UseVisualStyleBackColor = true;
            // 
            // askBt
            // 
            this.askBt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.askBt.AutoSize = true;
            this.askBt.Location = new System.Drawing.Point(1128, 32);
            this.askBt.Name = "askBt";
            this.askBt.Size = new System.Drawing.Size(75, 25);
            this.askBt.TabIndex = 27;
            this.askBt.Text = "검색";
            this.askBt.UseVisualStyleBackColor = true;
            this.askBt.Click += new System.EventHandler(this.askBt_Click);
            // 
            // login_grid
            // 
            this.login_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.login_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.depart,
            this.position,
            this.Cdate});
            this.login_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.login_grid.Location = new System.Drawing.Point(0, 149);
            this.login_grid.Name = "login_grid";
            this.login_grid.RowHeadersWidth = 51;
            this.login_grid.RowTemplate.Height = 27;
            this.login_grid.Size = new System.Drawing.Size(1226, 570);
            this.login_grid.TabIndex = 2;
            // 
            // name
            // 
            this.name.HeaderText = "이름";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 125;
            // 
            // depart
            // 
            this.depart.HeaderText = "부서";
            this.depart.MinimumWidth = 6;
            this.depart.Name = "depart";
            this.depart.Width = 125;
            // 
            // position
            // 
            this.position.HeaderText = "직급";
            this.position.MinimumWidth = 6;
            this.position.Name = "position";
            this.position.Width = 125;
            // 
            // Cdate
            // 
            this.Cdate.HeaderText = "입사일";
            this.Cdate.MinimumWidth = 6;
            this.Cdate.Name = "Cdate";
            this.Cdate.Width = 125;
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(172, 82);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(152, 25);
            this.nameTxt.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 42;
            this.label1.Text = "이름";
            // 
            // departCom
            // 
            this.departCom.FormattingEnabled = true;
            this.departCom.Items.AddRange(new object[] {
            "manage",
            "machine"});
            this.departCom.Location = new System.Drawing.Point(461, 33);
            this.departCom.Name = "departCom";
            this.departCom.Size = new System.Drawing.Size(152, 23);
            this.departCom.TabIndex = 41;
            // 
            // positionCom
            // 
            this.positionCom.FormattingEnabled = true;
            this.positionCom.Items.AddRange(new object[] {
            "PM",
            "EN"});
            this.positionCom.Location = new System.Drawing.Point(461, 83);
            this.positionCom.Name = "positionCom";
            this.positionCom.Size = new System.Drawing.Size(152, 23);
            this.positionCom.TabIndex = 40;
            // 
            // cdatePicker
            // 
            this.cdatePicker.Location = new System.Drawing.Point(756, 32);
            this.cdatePicker.Name = "cdatePicker";
            this.cdatePicker.Size = new System.Drawing.Size(200, 25);
            this.cdatePicker.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(673, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 38;
            this.label5.Text = "입사일";
            // 
            // pnumTxt
            // 
            this.pnumTxt.Location = new System.Drawing.Point(172, 32);
            this.pnumTxt.Name = "pnumTxt";
            this.pnumTxt.Size = new System.Drawing.Size(152, 25);
            this.pnumTxt.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(396, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 36;
            this.label4.Text = "부서";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(396, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 35;
            this.label3.Text = "직급";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 34;
            this.label2.Text = "사원번호";
            // 
            // manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.login_grid);
            this.Controls.Add(this.panel1);
            this.Name = "manage";
            this.Size = new System.Drawing.Size(1226, 719);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.login_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button registerBt;
        private System.Windows.Forms.Button askBt;
        private System.Windows.Forms.DataGridView login_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn depart;
        private System.Windows.Forms.DataGridViewTextBoxColumn position;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cdate;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox departCom;
        private System.Windows.Forms.ComboBox positionCom;
        private System.Windows.Forms.DateTimePicker cdatePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pnumTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
