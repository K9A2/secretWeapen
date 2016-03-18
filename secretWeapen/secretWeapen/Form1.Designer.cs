namespace secretWeapen
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_input = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.rdo_bts = new System.Windows.Forms.RadioButton();
            this.rdo_tor = new System.Windows.Forms.RadioButton();
            this.rdo_btd = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txt_input
            // 
            this.txt_input.Location = new System.Drawing.Point(10, 10);
            this.txt_input.Margin = new System.Windows.Forms.Padding(5);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(460, 25);
            this.txt_input.TabIndex = 0;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(480, 9);
            this.btn_search.Margin = new System.Windows.Forms.Padding(5);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(90, 23);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "搜索";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_result
            // 
            this.txt_result.Location = new System.Drawing.Point(10, 72);
            this.txt_result.Margin = new System.Windows.Forms.Padding(5);
            this.txt_result.Multiline = true;
            this.txt_result.Name = "txt_result";
            this.txt_result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_result.Size = new System.Drawing.Size(560, 273);
            this.txt_result.TabIndex = 3;
            // 
            // rdo_bts
            // 
            this.rdo_bts.AutoSize = true;
            this.rdo_bts.Location = new System.Drawing.Point(12, 43);
            this.rdo_bts.Margin = new System.Windows.Forms.Padding(5);
            this.rdo_bts.Name = "rdo_bts";
            this.rdo_bts.Size = new System.Drawing.Size(92, 19);
            this.rdo_bts.TabIndex = 4;
            this.rdo_bts.TabStop = true;
            this.rdo_bts.Text = "Btspread";
            this.rdo_bts.UseVisualStyleBackColor = true;
            this.rdo_bts.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdo_tor
            // 
            this.rdo_tor.AutoSize = true;
            this.rdo_tor.Location = new System.Drawing.Point(110, 43);
            this.rdo_tor.Margin = new System.Windows.Forms.Padding(5);
            this.rdo_tor.Name = "rdo_tor";
            this.rdo_tor.Size = new System.Drawing.Size(124, 19);
            this.rdo_tor.TabIndex = 5;
            this.rdo_tor.TabStop = true;
            this.rdo_tor.Text = "TorrentKitty";
            this.rdo_tor.UseVisualStyleBackColor = true;
            // 
            // rdo_btd
            // 
            this.rdo_btd.AutoSize = true;
            this.rdo_btd.Location = new System.Drawing.Point(244, 43);
            this.rdo_btd.Margin = new System.Windows.Forms.Padding(5);
            this.rdo_btd.Name = "rdo_btd";
            this.rdo_btd.Size = new System.Drawing.Size(76, 19);
            this.rdo_btd.TabIndex = 6;
            this.rdo_btd.TabStop = true;
            this.rdo_btd.Text = "BtDigg";
            this.rdo_btd.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 355);
            this.Controls.Add(this.rdo_btd);
            this.Controls.Add(this.rdo_tor);
            this.Controls.Add(this.rdo_bts);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_input);
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Main";
            this.Text = "搜片神器";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.RadioButton rdo_bts;
        private System.Windows.Forms.RadioButton rdo_tor;
        private System.Windows.Forms.RadioButton rdo_btd;
    }
}

