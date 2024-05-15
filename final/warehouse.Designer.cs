namespace final
{
    partial class warehouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(warehouse));
            this.panel1 = new System.Windows.Forms.Panel();
            this.numTxt = new System.Windows.Forms.TextBox();
            this.askBt = new System.Windows.Forms.Button();
            this.typeCom = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.lotTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.pcbBt = new System.Windows.Forms.ToolStripButton();
            this.moldBt = new System.Windows.Forms.ToolStripButton();
            this.chipBt = new System.Windows.Forms.ToolStripButton();
            this.goodBt = new System.Windows.Forms.ToolStripButton();
            this.badBt = new System.Windows.Forms.ToolStripButton();
            this.ware_grid = new System.Windows.Forms.DataGridView();
            this.lot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ware_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numTxt);
            this.panel1.Controls.Add(this.askBt);
            this.panel1.Controls.Add(this.typeCom);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lotTxt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1367, 149);
            this.panel1.TabIndex = 0;
            // 
            // numTxt
            // 
            this.numTxt.Location = new System.Drawing.Point(637, 29);
            this.numTxt.Name = "numTxt";
            this.numTxt.Size = new System.Drawing.Size(200, 25);
            this.numTxt.TabIndex = 29;
            // 
            // askBt
            // 
            this.askBt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.askBt.AutoSize = true;
            this.askBt.Location = new System.Drawing.Point(1269, 32);
            this.askBt.Name = "askBt";
            this.askBt.Size = new System.Drawing.Size(75, 25);
            this.askBt.TabIndex = 27;
            this.askBt.Text = "검색";
            this.askBt.UseVisualStyleBackColor = true;
            this.askBt.Click += new System.EventHandler(this.askBt_Click);
            // 
            // typeCom
            // 
            this.typeCom.FormattingEnabled = true;
            this.typeCom.Location = new System.Drawing.Point(197, 85);
            this.typeCom.Name = "typeCom";
            this.typeCom.Size = new System.Drawing.Size(200, 23);
            this.typeCom.TabIndex = 28;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(637, 88);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker1.TabIndex = 26;
            this.dateTimePicker1.Value = new System.DateTime(1989, 1, 1, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(511, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 25;
            this.label5.Text = "생산일자";
            // 
            // lotTxt
            // 
            this.lotTxt.Location = new System.Drawing.Point(197, 29);
            this.lotTxt.Name = "lotTxt";
            this.lotTxt.Size = new System.Drawing.Size(200, 25);
            this.lotTxt.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(511, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "개수";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "유형";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Lot";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pcbBt,
            this.moldBt,
            this.chipBt,
            this.goodBt,
            this.badBt});
            this.toolStrip1.Location = new System.Drawing.Point(0, 149);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1367, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // pcbBt
            // 
            this.pcbBt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.pcbBt.Image = ((System.Drawing.Image)(resources.GetObject("pcbBt.Image")));
            this.pcbBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pcbBt.Name = "pcbBt";
            this.pcbBt.Size = new System.Drawing.Size(73, 24);
            this.pcbBt.Text = "pcb 창고";
            // 
            // moldBt
            // 
            this.moldBt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.moldBt.Image = ((System.Drawing.Image)(resources.GetObject("moldBt.Image")));
            this.moldBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.moldBt.Name = "moldBt";
            this.moldBt.Size = new System.Drawing.Size(78, 24);
            this.moldBt.Text = "몰드 창고";
            // 
            // chipBt
            // 
            this.chipBt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.chipBt.Image = ((System.Drawing.Image)(resources.GetObject("chipBt.Image")));
            this.chipBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.chipBt.Name = "chipBt";
            this.chipBt.Size = new System.Drawing.Size(63, 24);
            this.chipBt.Text = "칩 창고";
            // 
            // goodBt
            // 
            this.goodBt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.goodBt.Image = ((System.Drawing.Image)(resources.GetObject("goodBt.Image")));
            this.goodBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.goodBt.Name = "goodBt";
            this.goodBt.Size = new System.Drawing.Size(93, 24);
            this.goodBt.Text = "완제품 창고";
            // 
            // badBt
            // 
            this.badBt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.badBt.Image = ((System.Drawing.Image)(resources.GetObject("badBt.Image")));
            this.badBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.badBt.Name = "badBt";
            this.badBt.Size = new System.Drawing.Size(93, 24);
            this.badBt.Text = "불량품 창고";
            // 
            // ware_grid
            // 
            this.ware_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ware_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lot,
            this.type,
            this.num,
            this.date});
            this.ware_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ware_grid.Location = new System.Drawing.Point(0, 176);
            this.ware_grid.Name = "ware_grid";
            this.ware_grid.RowHeadersWidth = 51;
            this.ware_grid.RowTemplate.Height = 27;
            this.ware_grid.Size = new System.Drawing.Size(1367, 544);
            this.ware_grid.TabIndex = 3;
            // 
            // lot
            // 
            this.lot.HeaderText = "Lot 넘버";
            this.lot.MinimumWidth = 6;
            this.lot.Name = "lot";
            this.lot.Width = 125;
            // 
            // type
            // 
            this.type.HeaderText = "유형";
            this.type.MinimumWidth = 6;
            this.type.Name = "type";
            this.type.Width = 125;
            // 
            // num
            // 
            this.num.HeaderText = "개수";
            this.num.MinimumWidth = 6;
            this.num.Name = "num";
            this.num.Width = 125;
            // 
            // date
            // 
            this.date.HeaderText = "생산일자";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.Width = 125;
            // 
            // warehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ware_grid);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "warehouse";
            this.Size = new System.Drawing.Size(1367, 720);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ware_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox typeCom;
        private System.Windows.Forms.Button askBt;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numTxt;
        private System.Windows.Forms.TextBox lotTxt;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton pcbBt;
        private System.Windows.Forms.ToolStripButton moldBt;
        private System.Windows.Forms.ToolStripButton chipBt;
        private System.Windows.Forms.ToolStripButton badBt;
        private System.Windows.Forms.ToolStripButton goodBt;
        private System.Windows.Forms.DataGridView ware_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn lot;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
    }
}
