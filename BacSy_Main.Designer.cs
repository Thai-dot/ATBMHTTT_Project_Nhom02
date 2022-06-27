namespace Test2
{
    partial class BacSy_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgv_HSBA_BS = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgv_HSBADV_BacSy = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_Timkiem = new System.Windows.Forms.Button();
            this.dgv_benhnhan_bacsy = new System.Windows.Forms.DataGridView();
            this.benhnhan_input_txtbox = new System.Windows.Forms.Label();
            this.txb_Ma_BN = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button_TB = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HSBA_BS)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HSBADV_BacSy)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_benhnhan_bacsy)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(394, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "BÁC SỸ";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(80, 52);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(783, 424);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPage1.Controls.Add(this.dgv_HSBA_BS);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(775, 398);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Xem HSBA";
            // 
            // dgv_HSBA_BS
            // 
            this.dgv_HSBA_BS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HSBA_BS.Location = new System.Drawing.Point(40, 76);
            this.dgv_HSBA_BS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_HSBA_BS.Name = "dgv_HSBA_BS";
            this.dgv_HSBA_BS.RowHeadersWidth = 51;
            this.dgv_HSBA_BS.RowTemplate.Height = 24;
            this.dgv_HSBA_BS.Size = new System.Drawing.Size(690, 298);
            this.dgv_HSBA_BS.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LemonChiffon;
            this.tabPage2.Controls.Add(this.dgv_HSBADV_BacSy);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(775, 398);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Xem HSBA_DV";
            // 
            // dgv_HSBADV_BacSy
            // 
            this.dgv_HSBADV_BacSy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_HSBADV_BacSy.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_HSBADV_BacSy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HSBADV_BacSy.Location = new System.Drawing.Point(27, 49);
            this.dgv_HSBADV_BacSy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_HSBADV_BacSy.Name = "dgv_HSBADV_BacSy";
            this.dgv_HSBADV_BacSy.RowHeadersWidth = 51;
            this.dgv_HSBADV_BacSy.RowTemplate.Height = 24;
            this.dgv_HSBADV_BacSy.Size = new System.Drawing.Size(723, 320);
            this.dgv_HSBADV_BacSy.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_Timkiem);
            this.tabPage3.Controls.Add(this.dgv_benhnhan_bacsy);
            this.tabPage3.Controls.Add(this.benhnhan_input_txtbox);
            this.tabPage3.Controls.Add(this.txb_Ma_BN);
            this.tabPage3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(775, 398);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Xem Bệnh Nhân";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_Timkiem
            // 
            this.btn_Timkiem.Location = new System.Drawing.Point(462, 13);
            this.btn_Timkiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Timkiem.Name = "btn_Timkiem";
            this.btn_Timkiem.Size = new System.Drawing.Size(74, 27);
            this.btn_Timkiem.TabIndex = 3;
            this.btn_Timkiem.Text = "Tìm Kiếm";
            this.btn_Timkiem.UseVisualStyleBackColor = true;
            this.btn_Timkiem.Click += new System.EventHandler(this.btn_Timkiem_Click);
            // 
            // dgv_benhnhan_bacsy
            // 
            this.dgv_benhnhan_bacsy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_benhnhan_bacsy.Location = new System.Drawing.Point(39, 61);
            this.dgv_benhnhan_bacsy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_benhnhan_bacsy.Name = "dgv_benhnhan_bacsy";
            this.dgv_benhnhan_bacsy.RowHeadersWidth = 51;
            this.dgv_benhnhan_bacsy.RowTemplate.Height = 24;
            this.dgv_benhnhan_bacsy.Size = new System.Drawing.Size(699, 314);
            this.dgv_benhnhan_bacsy.TabIndex = 2;
            // 
            // benhnhan_input_txtbox
            // 
            this.benhnhan_input_txtbox.AutoSize = true;
            this.benhnhan_input_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.benhnhan_input_txtbox.Location = new System.Drawing.Point(63, 15);
            this.benhnhan_input_txtbox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.benhnhan_input_txtbox.Name = "benhnhan_input_txtbox";
            this.benhnhan_input_txtbox.Size = new System.Drawing.Size(116, 20);
            this.benhnhan_input_txtbox.TabIndex = 1;
            this.benhnhan_input_txtbox.Text = "Nhập mã/cmnd";
            // 
            // txb_Ma_BN
            // 
            this.txb_Ma_BN.Location = new System.Drawing.Point(190, 17);
            this.txb_Ma_BN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txb_Ma_BN.Name = "txb_Ma_BN";
            this.txb_Ma_BN.Size = new System.Drawing.Size(258, 20);
            this.txb_Ma_BN.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(678, 17);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Thông Tin Cá Nhân";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(572, 17);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 39);
            this.button2.TabIndex = 3;
            this.button2.Text = "Đăng Xuất";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_TB
            // 
            this.button_TB.Location = new System.Drawing.Point(785, 17);
            this.button_TB.Name = "button_TB";
            this.button_TB.Size = new System.Drawing.Size(92, 39);
            this.button_TB.TabIndex = 4;
            this.button_TB.Text = "THÔNG BÁO";
            this.button_TB.UseVisualStyleBackColor = true;
            this.button_TB.Click += new System.EventHandler(this.button_TB_Click);
            // 
            // BacSy_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 475);
            this.Controls.Add(this.button_TB);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BacSy_Main";
            this.Text = "BacSy_Main";
            this.Load += new System.EventHandler(this.BacSy_Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HSBA_BS)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HSBADV_BacSy)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_benhnhan_bacsy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgv_HSBA_BS;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgv_HSBADV_BacSy;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgv_benhnhan_bacsy;
        private System.Windows.Forms.Label benhnhan_input_txtbox;
        private System.Windows.Forms.TextBox txb_Ma_BN;
        private System.Windows.Forms.Button btn_Timkiem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_TB;
    }
}