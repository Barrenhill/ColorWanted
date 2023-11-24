using System.ComponentModel;
using Timer = System.Windows.Forms.Timer;

namespace ColorWanted
{
    partial class ColorWanted
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            components = new Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(ColorWanted));
            checkBox1 = new CheckBox();
            txtPoint = new TextBox();
            timer1 = new Timer(components);
            txtRGB = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            txtColor = new TextBox();
            label4 = new Label();
            panel3 = new Panel();
            label6 = new Label();
            label5 = new Label();
            notifyIcon1 = new NotifyIcon(components);
            NicontextMenu = new ContextMenuStrip(components);
            toolStripMenuItem_Exit = new ToolStripMenuItem();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            NicontextMenu.SuspendLayout();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(7, 10);
            checkBox1.Margin = new Padding(4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(123, 21);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "是否显示在最顶层";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // txtPoint
            // 
            txtPoint.Location = new Point(170, 37);
            txtPoint.Margin = new Padding(4);
            txtPoint.Name = "txtPoint";
            txtPoint.Size = new Size(129, 23);
            txtPoint.TabIndex = 1;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // txtRGB
            // 
            txtRGB.Location = new Point(170, 72);
            txtRGB.Margin = new Padding(4);
            txtRGB.Name = "txtRGB";
            txtRGB.Size = new Size(129, 23);
            txtRGB.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Location = new Point(7, 47);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(69, 83);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 44);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(68, 17);
            label1.TabIndex = 5;
            label1.Text = "鼠标位置：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 79);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(69, 17);
            label2.TabIndex = 6;
            label2.Text = "R G B 值：";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtColor);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtPoint);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtRGB);
            panel2.Controls.Add(panel1);
            panel2.Location = new Point(7, 10);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(310, 146);
            panel2.TabIndex = 7;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(170, 108);
            txtColor.Margin = new Padding(4);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(129, 23);
            txtColor.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(92, 115);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(68, 17);
            label4.TabIndex = 8;
            label4.Text = "网页颜色：";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(7, 166);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(310, 46);
            panel3.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(96, 11);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(151, 17);
            label6.TabIndex = 1;
            label6.Text = "按住Ctrl+F键复制网页颜色";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 13);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(80, 17);
            label5.TabIndex = 0;
            label5.Text = "复制颜色值：";
            // 
            // notifyIcon1
            // 
            notifyIcon1.BalloonTipText = "颜色拾取器";
            notifyIcon1.ContextMenuStrip = NicontextMenu;
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "颜色拾取器";
            notifyIcon1.Visible = true;
            notifyIcon1.MouseClick += notifyIcon1_Click;
            notifyIcon1.MouseDoubleClick += notifyIcon1_MouseDoubleClick;
            // 
            // NicontextMenu
            // 
            NicontextMenu.Items.AddRange(new ToolStripItem[] { toolStripMenuItem_Exit });
            NicontextMenu.Name = "NicontextMenu";
            NicontextMenu.Size = new Size(101, 26);
            // 
            // toolStripMenuItem_Exit
            // 
            toolStripMenuItem_Exit.Name = "toolStripMenuItem_Exit";
            toolStripMenuItem_Exit.Size = new Size(100, 22);
            toolStripMenuItem_Exit.Text = "退出";
            toolStripMenuItem_Exit.Click += Application_Exit_Click;
            // 
            // ColorWanted
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(324, 219);
            Controls.Add(panel3);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "ColorWanted";
            StartPosition = FormStartPosition.CenterParent;
            Text = "颜色拾取器";
            Load += FrmGetColor_Load;
            SizeChanged += Form1_SizeChanged;
            Leave += FrmGetColor_Leave;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            NicontextMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private CheckBox checkBox1;
        private TextBox txtPoint;
        private Timer timer1;
        private TextBox txtRGB;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private TextBox txtColor;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel panel3;
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip NicontextMenu;
        private ToolStripMenuItem toolStripMenuItem_Exit;
    }
}