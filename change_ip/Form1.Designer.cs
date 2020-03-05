namespace change_ip
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.model = new System.Windows.Forms.ComboBox();
            this.station = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.line = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Copyright = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTitle = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnclose = new Bunifu.Framework.UI.BunifuFlatButton();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // model
            // 
            this.model.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.model.BackColor = System.Drawing.SystemColors.Window;
            this.model.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.model.FormattingEnabled = true;
            this.model.Location = new System.Drawing.Point(146, 59);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(504, 33);
            this.model.TabIndex = 1;
            this.model.SelectedIndexChanged += new System.EventHandler(this.model_SelectedIndexChanged);
            // 
            // station
            // 
            this.station.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.station.Enabled = false;
            this.station.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.station.FormattingEnabled = true;
            this.station.Location = new System.Drawing.Point(146, 125);
            this.station.Name = "station";
            this.station.Size = new System.Drawing.Size(504, 33);
            this.station.TabIndex = 2;
            this.station.SelectedIndexChanged += new System.EventHandler(this.station_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(537, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "MODEL    :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "STATION :";
            // 
            // line
            // 
            this.line.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.line.Enabled = false;
            this.line.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.line.FormattingEnabled = true;
            this.line.Location = new System.Drawing.Point(146, 189);
            this.line.MaxDropDownItems = 10;
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(504, 33);
            this.line.TabIndex = 3;
            this.line.SelectedIndexChanged += new System.EventHandler(this.line_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(34, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "LINE         :";
            // 
            // Copyright
            // 
            this.Copyright.AutoSize = true;
            this.Copyright.BackColor = System.Drawing.Color.Transparent;
            this.Copyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Copyright.ForeColor = System.Drawing.Color.Red;
            this.Copyright.Location = new System.Drawing.Point(3, 8);
            this.Copyright.Name = "Copyright";
            this.Copyright.Size = new System.Drawing.Size(131, 20);
            this.Copyright.TabIndex = 7;
            this.Copyright.Text = "INFORMATION";
            this.Copyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.Copyright);
            this.panel1.Font = new System.Drawing.Font("FixSwiss", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(35, 249);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 36);
            this.panel1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(33, 298);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "EST 2018 © MIS SUPPORT ";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel5.Location = new System.Drawing.Point(-1, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 323);
            this.panel5.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Location = new System.Drawing.Point(-2, 323);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(685, 10);
            this.panel3.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel4.Location = new System.Drawing.Point(673, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 332);
            this.panel4.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Controls.Add(this.btnTitle);
            this.panel2.Controls.Add(this.btnclose);
            this.panel2.Location = new System.Drawing.Point(-2, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(685, 32);
            this.panel2.TabIndex = 10;
            // 
            // btnTitle
            // 
            this.btnTitle.Activecolor = System.Drawing.Color.Transparent;
            this.btnTitle.BackColor = System.Drawing.Color.Transparent;
            this.btnTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTitle.BorderRadius = 0;
            this.btnTitle.ButtonText = "C H A N G E - M O D E L";
            this.btnTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnTitle.DisabledColor = System.Drawing.Color.Gray;
            this.btnTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTitle.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTitle.Iconimage = null;
            this.btnTitle.Iconimage_right = null;
            this.btnTitle.Iconimage_right_Selected = null;
            this.btnTitle.Iconimage_Selected = null;
            this.btnTitle.IconMarginLeft = 0;
            this.btnTitle.IconMarginRight = 0;
            this.btnTitle.IconRightVisible = true;
            this.btnTitle.IconRightZoom = 0D;
            this.btnTitle.IconVisible = true;
            this.btnTitle.IconZoom = 35D;
            this.btnTitle.IsTab = false;
            this.btnTitle.Location = new System.Drawing.Point(7, 7);
            this.btnTitle.Name = "btnTitle";
            this.btnTitle.Normalcolor = System.Drawing.Color.Transparent;
            this.btnTitle.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnTitle.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.btnTitle.selected = false;
            this.btnTitle.Size = new System.Drawing.Size(168, 20);
            this.btnTitle.TabIndex = 4;
            this.btnTitle.Text = "C H A N G E - M O D E L";
            this.btnTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTitle.Textcolor = System.Drawing.Color.White;
            this.btnTitle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnclose
            // 
            this.btnclose.Activecolor = System.Drawing.Color.Transparent;
            this.btnclose.BackColor = System.Drawing.Color.Transparent;
            this.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnclose.BorderRadius = 0;
            this.btnclose.ButtonText = "       [ E X I T ]";
            this.btnclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclose.DisabledColor = System.Drawing.Color.Gray;
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Iconcolor = System.Drawing.Color.Transparent;
            this.btnclose.Iconimage = null;
            this.btnclose.Iconimage_right = null;
            this.btnclose.Iconimage_right_Selected = null;
            this.btnclose.Iconimage_Selected = null;
            this.btnclose.IconMarginLeft = 0;
            this.btnclose.IconMarginRight = 0;
            this.btnclose.IconRightVisible = true;
            this.btnclose.IconRightZoom = 0D;
            this.btnclose.IconVisible = true;
            this.btnclose.IconZoom = 90D;
            this.btnclose.IsTab = false;
            this.btnclose.Location = new System.Drawing.Point(609, 7);
            this.btnclose.Name = "btnclose";
            this.btnclose.Normalcolor = System.Drawing.Color.Transparent;
            this.btnclose.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnclose.OnHoverTextColor = System.Drawing.Color.OrangeRed;
            this.btnclose.selected = false;
            this.btnclose.Size = new System.Drawing.Size(92, 20);
            this.btnclose.TabIndex = 3;
            this.btnclose.Text = "       [ E X I T ]";
            this.btnclose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclose.Textcolor = System.Drawing.Color.White;
            this.btnclose.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(682, 333);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.line);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.station);
            this.Controls.Add(this.model);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Model";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox line;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox model;
        public System.Windows.Forms.ComboBox station;
        private System.Windows.Forms.Label Copyright;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnclose;
        private Bunifu.Framework.UI.BunifuFlatButton btnTitle;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
    }
}

