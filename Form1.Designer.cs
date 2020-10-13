namespace Animation_Slide_Panel_2
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
            this.components = new System.ComponentModel.Container();
            Guna.UI2.AnimatorNS.Animation animation2 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pn_menu = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.DetectMouse = new System.Windows.Forms.Timer(this.components);
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.tab1 = new Animation_Slide_Panel_2.tab();
            this.tabl1 = new Animation_Slide_Panel_2.tabl();
            this.pn_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_menu
            // 
            this.pn_menu.Controls.Add(this.guna2Button2);
            this.pn_menu.Controls.Add(this.guna2Button1);
            this.pn_menu.Controls.Add(this.guna2PictureBox1);
            this.guna2Transition1.SetDecoration(this.pn_menu, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pn_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_menu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(66)))), ((int)(((byte)(183)))));
            this.pn_menu.Location = new System.Drawing.Point(0, 0);
            this.pn_menu.Name = "pn_menu";
            this.pn_menu.ShadowDecoration.Parent = this.pn_menu;
            this.pn_menu.Size = new System.Drawing.Size(63, 546);
            this.pn_menu.TabIndex = 0;
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            this.guna2Transition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation2;
            // 
            // DetectMouse
            // 
            this.DetectMouse.Enabled = true;
            this.DetectMouse.Tick += new System.EventHandler(this.DetectMouse_Tick);
            // 
            // guna2Button2
            // 
            this.guna2Button2.Animated = true;
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(52)))));
            this.guna2Button2.CheckedState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.guna2Button2.CheckedState.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Transition1.SetDecoration(this.guna2Button2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(66)))), ((int)(((byte)(183)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(52)))));
            this.guna2Button2.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Image = global::Animation_Slide_Panel_2.Properties.Resources.dollar_account_150px_png1;
            this.guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button2.ImageOffset = new System.Drawing.Point(5, 0);
            this.guna2Button2.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button2.Location = new System.Drawing.Point(0, 131);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(205, 45);
            this.guna2Button2.TabIndex = 2;
            this.guna2Button2.Text = "Wallet";
            this.guna2Button2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button2.TextOffset = new System.Drawing.Point(20, 0);
            this.guna2Button2.UseTransparentBackground = true;
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(52)))));
            this.guna2Button1.CheckedState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.CheckedState.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Transition1.SetDecoration(this.guna2Button1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(66)))), ((int)(((byte)(183)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(52)))));
            this.guna2Button1.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = global::Animation_Slide_Panel_2.Properties.Resources.male_user_150px;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.ImageOffset = new System.Drawing.Point(5, 0);
            this.guna2Button1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button1.Location = new System.Drawing.Point(0, 86);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(205, 45);
            this.guna2Button1.TabIndex = 1;
            this.guna2Button1.Text = "Dashboard";
            this.guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.TextOffset = new System.Drawing.Point(20, 0);
            this.guna2Button1.UseTransparentBackground = true;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2PictureBox1.Image = global::Animation_Slide_Panel_2.Properties.Resources.kisspng_launchpad_computer_icons_macos_launch_5acdb74a9b7091_3212701315234312426367_removebg_preview;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(63, 57);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(52)))));
            this.guna2Panel1.Controls.Add(this.tab1);
            this.guna2Panel1.Controls.Add(this.tabl1);
            this.guna2Transition1.SetDecoration(this.guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(63, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(217, 546);
            this.guna2Panel1.TabIndex = 1;
            // 
            // tab1
            // 
            this.tab1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(52)))));
            this.guna2Transition1.SetDecoration(this.tab1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab1.Location = new System.Drawing.Point(0, 0);
            this.tab1.Name = "tab1";
            this.tab1.Size = new System.Drawing.Size(217, 546);
            this.tab1.TabIndex = 0;
            // 
            // tabl1
            // 
            this.tabl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(52)))));
            this.guna2Transition1.SetDecoration(this.tabl1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tabl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabl1.Location = new System.Drawing.Point(0, 0);
            this.tabl1.Name = "tabl1";
            this.tabl1.Size = new System.Drawing.Size(217, 546);
            this.tabl1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(875, 546);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.pn_menu);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Animation Panel Slide";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pn_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pn_menu;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private System.Windows.Forms.Timer DetectMouse;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private tab tab1;
        private tabl tabl1;
    }
}

