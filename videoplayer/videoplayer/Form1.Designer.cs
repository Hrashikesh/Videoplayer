namespace videoplayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.fullscreen = new Bunifu.Framework.UI.BunifuImageButton();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.file = new Bunifu.Framework.UI.BunifuFlatButton();
            this.stop = new Bunifu.Framework.UI.BunifuImageButton();
            this.Next = new Bunifu.Framework.UI.BunifuImageButton();
            this.Back = new Bunifu.Framework.UI.BunifuImageButton();
            this.volume = new Bunifu.Framework.UI.BunifuImageButton();
            this.mute = new Bunifu.Framework.UI.BunifuImageButton();
            this.Play = new Bunifu.Framework.UI.BunifuImageButton();
            this.Pause = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.filename = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.min = new Bunifu.Framework.UI.BunifuImageButton();
            this.close = new Bunifu.Framework.UI.BunifuImageButton();
            this.logo = new System.Windows.Forms.PictureBox();
            this.max = new Bunifu.Framework.UI.BunifuImageButton();
            this.resize = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.slider = new Bunifu.Framework.UI.BunifuSlider();
            this.time2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.time1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.bunifuDragControl3 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl4 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fullscreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pause)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resize)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.fullscreen);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.file);
            this.panel1.Controls.Add(this.stop);
            this.panel1.Controls.Add(this.Next);
            this.panel1.Controls.Add(this.Back);
            this.panel1.Controls.Add(this.volume);
            this.panel1.Controls.Add(this.mute);
            this.panel1.Controls.Add(this.Play);
            this.panel1.Controls.Add(this.Pause);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 447);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 48);
            this.panel1.TabIndex = 0;
            // 
            // fullscreen
            // 
            this.fullscreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fullscreen.BackColor = System.Drawing.Color.Transparent;
            this.fullscreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fullscreen.Image = ((System.Drawing.Image)(resources.GetObject("fullscreen.Image")));
            this.fullscreen.ImageActive = null;
            this.fullscreen.Location = new System.Drawing.Point(900, 10);
            this.fullscreen.Name = "fullscreen";
            this.fullscreen.Size = new System.Drawing.Size(30, 30);
            this.fullscreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fullscreen.TabIndex = 9;
            this.fullscreen.TabStop = false;
            this.fullscreen.Zoom = 10;
            this.fullscreen.Click += new System.EventHandler(this.fullscreen_Click);
            this.fullscreen.MouseLeave += new System.EventHandler(this.fullscreen_MouseLeave);
            this.fullscreen.MouseHover += new System.EventHandler(this.fullscreen_MouseHover);
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.Location = new System.Drawing.Point(618, 11);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(217, 45);
            this.trackBar1.SmallChange = 10;
            this.trackBar1.TabIndex = 7;
            this.trackBar1.Value = 50;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // file
            // 
            this.file.Activecolor = System.Drawing.Color.Transparent;
            this.file.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.file.BackColor = System.Drawing.Color.Transparent;
            this.file.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.file.BorderRadius = 0;
            this.file.ButtonText = "File";
            this.file.Cursor = System.Windows.Forms.Cursors.Hand;
            this.file.DisabledColor = System.Drawing.Color.Gray;
            this.file.Iconcolor = System.Drawing.Color.Transparent;
            this.file.Iconimage = ((System.Drawing.Image)(resources.GetObject("file.Iconimage")));
            this.file.Iconimage_right = null;
            this.file.Iconimage_right_Selected = null;
            this.file.Iconimage_Selected = null;
            this.file.IconMarginLeft = 0;
            this.file.IconMarginRight = 0;
            this.file.IconRightVisible = true;
            this.file.IconRightZoom = 0D;
            this.file.IconVisible = true;
            this.file.IconZoom = 75D;
            this.file.IsTab = false;
            this.file.Location = new System.Drawing.Point(8, 2);
            this.file.Name = "file";
            this.file.Normalcolor = System.Drawing.Color.Transparent;
            this.file.OnHovercolor = System.Drawing.Color.Transparent;
            this.file.OnHoverTextColor = System.Drawing.Color.White;
            this.file.selected = false;
            this.file.Size = new System.Drawing.Size(77, 44);
            this.file.TabIndex = 1;
            this.file.Text = "File";
            this.file.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.file.Textcolor = System.Drawing.Color.White;
            this.file.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.file.Click += new System.EventHandler(this.file_Click);
            // 
            // stop
            // 
            this.stop.BackColor = System.Drawing.Color.Transparent;
            this.stop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stop.Image = ((System.Drawing.Image)(resources.GetObject("stop.Image")));
            this.stop.ImageActive = null;
            this.stop.Location = new System.Drawing.Point(172, 10);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(30, 30);
            this.stop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.stop.TabIndex = 6;
            this.stop.TabStop = false;
            this.stop.Zoom = 10;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            this.stop.MouseLeave += new System.EventHandler(this.stop_MouseLeave);
            this.stop.MouseHover += new System.EventHandler(this.stop_MouseHover);
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.Color.Transparent;
            this.Next.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Next.Image = ((System.Drawing.Image)(resources.GetObject("Next.Image")));
            this.Next.ImageActive = null;
            this.Next.Location = new System.Drawing.Point(208, 10);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(30, 30);
            this.Next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Next.TabIndex = 5;
            this.Next.TabStop = false;
            this.Next.Zoom = 10;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            this.Next.MouseLeave += new System.EventHandler(this.Next_MouseLeave);
            this.Next.MouseHover += new System.EventHandler(this.Next_MouseHover);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Transparent;
            this.Back.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Back.Image = ((System.Drawing.Image)(resources.GetObject("Back.Image")));
            this.Back.ImageActive = null;
            this.Back.Location = new System.Drawing.Point(100, 10);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(30, 30);
            this.Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Back.TabIndex = 4;
            this.Back.TabStop = false;
            this.Back.Zoom = 10;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            this.Back.MouseLeave += new System.EventHandler(this.Back_MouseLeave);
            this.Back.MouseHover += new System.EventHandler(this.Back_MouseHover);
            // 
            // volume
            // 
            this.volume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.volume.BackColor = System.Drawing.Color.Transparent;
            this.volume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.volume.Image = ((System.Drawing.Image)(resources.GetObject("volume.Image")));
            this.volume.ImageActive = null;
            this.volume.Location = new System.Drawing.Point(582, 10);
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(30, 30);
            this.volume.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.volume.TabIndex = 8;
            this.volume.TabStop = false;
            this.volume.Zoom = 10;
            this.volume.Click += new System.EventHandler(this.volume_Click);
            this.volume.MouseLeave += new System.EventHandler(this.volume_MouseLeave);
            this.volume.MouseHover += new System.EventHandler(this.volume_MouseHover);
            // 
            // mute
            // 
            this.mute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mute.BackColor = System.Drawing.Color.Transparent;
            this.mute.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mute.Image = ((System.Drawing.Image)(resources.GetObject("mute.Image")));
            this.mute.ImageActive = null;
            this.mute.Location = new System.Drawing.Point(582, 10);
            this.mute.Name = "mute";
            this.mute.Size = new System.Drawing.Size(30, 30);
            this.mute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mute.TabIndex = 10;
            this.mute.TabStop = false;
            this.mute.Zoom = 10;
            this.mute.Click += new System.EventHandler(this.mute_Click);
            // 
            // Play
            // 
            this.Play.BackColor = System.Drawing.Color.Transparent;
            this.Play.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Play.Image = ((System.Drawing.Image)(resources.GetObject("Play.Image")));
            this.Play.ImageActive = null;
            this.Play.Location = new System.Drawing.Point(136, 10);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(30, 30);
            this.Play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Play.TabIndex = 2;
            this.Play.TabStop = false;
            this.Play.Zoom = 10;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            this.Play.MouseLeave += new System.EventHandler(this.Play_MouseLeave);
            this.Play.MouseHover += new System.EventHandler(this.Play_MouseHover);
            // 
            // Pause
            // 
            this.Pause.BackColor = System.Drawing.Color.Transparent;
            this.Pause.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pause.Image = ((System.Drawing.Image)(resources.GetObject("Pause.Image")));
            this.Pause.ImageActive = null;
            this.Pause.Location = new System.Drawing.Point(136, 10);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(30, 30);
            this.Pause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pause.TabIndex = 3;
            this.Pause.TabStop = false;
            this.Pause.Zoom = 10;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            this.Pause.MouseLeave += new System.EventHandler(this.Pause_MouseLeave);
            this.Pause.MouseHover += new System.EventHandler(this.Pause_MouseHover);
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.filename);
            this.panel2.Controls.Add(this.min);
            this.panel2.Controls.Add(this.close);
            this.panel2.Controls.Add(this.logo);
            this.panel2.Controls.Add(this.max);
            this.panel2.Controls.Add(this.resize);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(942, 44);
            this.panel2.TabIndex = 1;
            // 
            // filename
            // 
            this.filename.AutoSize = true;
            this.filename.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filename.ForeColor = System.Drawing.Color.White;
            this.filename.Location = new System.Drawing.Point(51, 13);
            this.filename.MaximumSize = new System.Drawing.Size(750, 17);
            this.filename.Name = "filename";
            this.filename.Size = new System.Drawing.Size(0, 17);
            this.filename.TabIndex = 9;
            // 
            // min
            // 
            this.min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.min.BackColor = System.Drawing.Color.Transparent;
            this.min.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.min.Image = ((System.Drawing.Image)(resources.GetObject("min.Image")));
            this.min.ImageActive = null;
            this.min.Location = new System.Drawing.Point(831, 8);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(30, 30);
            this.min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.min.TabIndex = 8;
            this.min.TabStop = false;
            this.min.Zoom = 10;
            this.min.Click += new System.EventHandler(this.min_Click);
            this.min.MouseLeave += new System.EventHandler(this.min_MouseLeave);
            this.min.MouseHover += new System.EventHandler(this.min_MouseHover);
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.ImageActive = null;
            this.close.Location = new System.Drawing.Point(903, 8);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(30, 30);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.TabIndex = 6;
            this.close.TabStop = false;
            this.close.Zoom = 10;
            this.close.Click += new System.EventHandler(this.close_Click);
            this.close.MouseLeave += new System.EventHandler(this.close_MouseLeave);
            this.close.MouseHover += new System.EventHandler(this.close_MouseHover);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logo.Location = new System.Drawing.Point(0, 2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(48, 40);
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // max
            // 
            this.max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.max.BackColor = System.Drawing.Color.Transparent;
            this.max.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.max.Image = ((System.Drawing.Image)(resources.GetObject("max.Image")));
            this.max.ImageActive = null;
            this.max.Location = new System.Drawing.Point(867, 8);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(30, 30);
            this.max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.max.TabIndex = 7;
            this.max.TabStop = false;
            this.max.Zoom = 10;
            this.max.Click += new System.EventHandler(this.max_Click);
            this.max.MouseLeave += new System.EventHandler(this.max_MouseLeave);
            this.max.MouseHover += new System.EventHandler(this.max_MouseHover);
            // 
            // resize
            // 
            this.resize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resize.BackColor = System.Drawing.Color.Transparent;
            this.resize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resize.Image = ((System.Drawing.Image)(resources.GetObject("resize.Image")));
            this.resize.ImageActive = null;
            this.resize.Location = new System.Drawing.Point(867, 8);
            this.resize.Name = "resize";
            this.resize.Size = new System.Drawing.Size(30, 30);
            this.resize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.resize.TabIndex = 10;
            this.resize.TabStop = false;
            this.resize.Zoom = 10;
            this.resize.Click += new System.EventHandler(this.resize_Click);
            this.resize.MouseLeave += new System.EventHandler(this.resize_MouseLeave);
            this.resize.MouseHover += new System.EventHandler(this.resize_MouseHover);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel2;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.panel1;
            this.bunifuDragControl2.Vertical = true;
            // 
            // slider
            // 
            this.slider.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.slider.BackColor = System.Drawing.Color.Transparent;
            this.slider.BackgroudColor = System.Drawing.Color.White;
            this.slider.BorderRadius = 25;
            this.slider.IndicatorColor = System.Drawing.Color.DodgerBlue;
            this.slider.Location = new System.Drawing.Point(100, 0);
            this.slider.MaximumValue = 100;
            this.slider.Name = "slider";
            this.slider.Size = new System.Drawing.Size(728, 30);
            this.slider.TabIndex = 0;
            this.slider.Value = 0;
            this.slider.ValueChanged += new System.EventHandler(this.slider_ValueChanged);
            // 
            // time2
            // 
            this.time2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.time2.AutoSize = true;
            this.time2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time2.ForeColor = System.Drawing.Color.White;
            this.time2.Location = new System.Drawing.Point(833, 5);
            this.time2.Name = "time2";
            this.time2.Size = new System.Drawing.Size(64, 17);
            this.time2.TabIndex = 7;
            this.time2.Text = "00:00:00";
            // 
            // time1
            // 
            this.time1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.time1.AutoSize = true;
            this.time1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time1.ForeColor = System.Drawing.Color.White;
            this.time1.Location = new System.Drawing.Point(32, 5);
            this.time1.Name = "time1";
            this.time1.Size = new System.Drawing.Size(64, 17);
            this.time1.TabIndex = 8;
            this.time1.Text = "00:00:00";
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Controls.Add(this.time1);
            this.panel3.Controls.Add(this.time2);
            this.panel3.Controls.Add(this.slider);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 417);
            this.panel3.MaximumSize = new System.Drawing.Size(1500, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(942, 30);
            this.panel3.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // player
            // 
            this.player.Dock = System.Windows.Forms.DockStyle.Fill;
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(0, 44);
            this.player.MaximumSize = new System.Drawing.Size(1370, 645);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(942, 373);
            this.player.TabIndex = 3;
            this.player.DoubleClickEvent += new AxWMPLib._WMPOCXEvents_DoubleClickEventHandler(this.player_DoubleClickEvent);
            this.player.KeyDownEvent += new AxWMPLib._WMPOCXEvents_KeyDownEventHandler(this.player_KeyDownEvent);
            this.player.KeyPressEvent += new AxWMPLib._WMPOCXEvents_KeyPressEventHandler(this.player_KeyPressEvent);
            // 
            // bunifuDragControl3
            // 
            this.bunifuDragControl3.Fixed = true;
            this.bunifuDragControl3.Horizontal = true;
            this.bunifuDragControl3.TargetControl = this.filename;
            this.bunifuDragControl3.Vertical = true;
            // 
            // bunifuDragControl4
            // 
            this.bunifuDragControl4.Fixed = true;
            this.bunifuDragControl4.Horizontal = true;
            this.bunifuDragControl4.TargetControl = this.panel3;
            this.bunifuDragControl4.Vertical = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(942, 495);
            this.ControlBox = false;
            this.Controls.Add(this.player);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fullscreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pause)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resize)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton Play;
        private Bunifu.Framework.UI.BunifuImageButton Pause;
        private Bunifu.Framework.UI.BunifuImageButton Next;
        private Bunifu.Framework.UI.BunifuImageButton Back;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton file;
        private Bunifu.Framework.UI.BunifuImageButton min;
        private Bunifu.Framework.UI.BunifuImageButton max;
        private Bunifu.Framework.UI.BunifuImageButton close;
        private Bunifu.Framework.UI.BunifuImageButton stop;
        private System.Windows.Forms.TrackBar trackBar1;
        private Bunifu.Framework.UI.BunifuImageButton fullscreen;
        private Bunifu.Framework.UI.BunifuImageButton volume;
        private Bunifu.Framework.UI.BunifuCustomLabel filename;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuSlider slider;
        private Bunifu.Framework.UI.BunifuCustomLabel time2;
        private Bunifu.Framework.UI.BunifuCustomLabel time1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuImageButton mute;
        private Bunifu.Framework.UI.BunifuImageButton resize;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl3;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl4;
    }
}

