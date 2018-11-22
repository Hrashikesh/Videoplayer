using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Media;
using System.IO;
using WMPLib;



namespace videoplayer
{
    public partial class Form1 : Form
    {
        
        String selectedfile;
        int flag = 0;//for space button pause/play
      
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            
            slider.Value = Convert.ToInt32(player.Ctlcontrols.currentPosition);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            
        }


        //code to select the file
        private void file_Click(object sender, EventArgs e)//to open a dialog box to select required video  and to filter the extension
        {
            OpenFileDialog obj = new OpenFileDialog();
          
            obj.AddExtension = true;
            obj.DefaultExt = "";
            obj.Title = "Select the media";
        
            obj.Filter="Media(*.*)|*.*";
            selectedfile = obj.FileName;
            obj.ShowDialog();       //to open the dialog box
            this.filename.Text = obj.SafeFileName;
            
            player.URL = obj.FileName;
            player.Ctlcontrols.play();


            //for taking the length of the video
            WindowsMediaPlayer wmp = new WindowsMediaPlayerClass();
            IWMPMedia mediainfo = wmp.newMedia(obj.FileName);
            slider.MaximumValue = Convert.ToInt32(mediainfo.duration);

            int maxtime = Convert.ToInt32(mediainfo.duration);
            time2.Text = string.Format("{0:00}:{1:00}:{2:00}", maxtime / 3600, (maxtime / 60) % 60, maxtime % 60);

        } 




     





        //Code for all the buttons


        //For minimis button
        private void min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        //For maximise Button
        private void max_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }

            else
            {
                this.WindowState = FormWindowState.Normal;

             }
            
            max.Hide();
            resize.Show();
        }



        //For resize button to got to normal window size
        private void resize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;

            resize.Hide();
            max.Show();
        }




        //For the fullSreen Button
        private void fullscreen_Click(object sender, EventArgs e)
        {
            
            
           
            this.WindowState = FormWindowState.Maximized;
            player.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            player.Dock = DockStyle.None;
            max.Hide();
            resize.Show();
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            


        }



        //For Close button
        private void close_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Application.Exit();
            Pause.Hide();
            Play.Show();

        }



        //For play Button
        private void Play_Click(object sender, EventArgs e)
        {

            timer1.Start();
            player.Ctlcontrols.play();
            Play.Hide();
            Pause.Show();
        }


        //For Pause Button
        private void Pause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            player.Ctlcontrols.pause();
            Pause.Hide();
            Play.Show();
        }

       // for stop Button
        private void stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            player.Ctlcontrols.stop();
            Pause.Hide();
            Play.Show();
            int currenttime = Convert.ToInt32(player.Ctlcontrols.currentPosition);
            slider.Value = currenttime;
            time1.Text = string.Format("{0:00}:{1:00}:{2:00}", currenttime / 3600, (currenttime / 60) % 60, currenttime % 60);
        }





        //for Backward Button
        private void Back_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.currentPosition -= 3;
            slider.Value = Convert.ToInt32(player.Ctlcontrols.currentPosition);// to decrease the slider value(progressbar)
        }


        //for Fastforward Button
        private void Next_Click(object sender, EventArgs e)
        {

            
                player.Ctlcontrols.currentPosition += 3;
                slider.Value = Convert.ToInt32(player.Ctlcontrols.currentPosition);// to increase the slider value(progressbar)
            
        }



        //for volume increase and decrease
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = trackBar1.Value;
        }



       
        //To change the current position of the video when click on the progressbar
        private void slider_ValueChanged(object sender, EventArgs e)
        {

            int currenttime = Convert.ToInt32(player.Ctlcontrols.currentPosition);
            if(currenttime==0)
            {
                slider.Value = 0;
            }
            player.Ctlcontrols.currentPosition = slider.Value;
        }


     
      




        

        //Fro Volume button
        private void volume_Click(object sender, EventArgs e)
        {
            if (trackBar1.Visible == false)
            {
                
                trackBar1.Visible = true;
                player.settings.volume = trackBar1.Value;

            }
            else
            {
                trackBar1.Visible = false;
                player.settings.volume = 0;

            }
            volume.Hide();
            mute.Show();
        }
      

       



//Hover code start

        //close button
        private void close_MouseHover(object sender, EventArgs e)
        {
            this.close.BackColor = Color.Red;//When mouse hover on the button its color turns to red
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.close, "Close");
        }
        //When mouse leave the button its back color turns ti transparent
        private void close_MouseLeave(object sender, EventArgs e)
        {
            this.close.BackColor = Color.Transparent;
        }







        //When hoverd on the buttons it will show its property
        private void Play_MouseHover(object sender, EventArgs e)
        {
            this.Play.BackColor = Color.SkyBlue;
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.Play, "Play");
        }
        private void Play_MouseLeave(object sender, EventArgs e)
        {
            this.Play.BackColor = Color.Transparent;
        }


        //pause button hover
        private void Pause_MouseHover(object sender, EventArgs e)
        {
            this.Pause.BackColor = Color.SkyBlue;
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.Pause, "Pause");
        }
        private void Pause_MouseLeave(object sender, EventArgs e)
        {
            this.Pause.BackColor = Color.Transparent;
        }


        //stop button hover
        private void stop_MouseHover(object sender, EventArgs e)
        {
            this.stop.BackColor = Color.SkyBlue;
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.stop, "Stop");
        }
        private void stop_MouseLeave(object sender, EventArgs e)
        {
            this.stop.BackColor = Color.Transparent;
        }



        //Backward button hover
        private void Back_MouseHover(object sender, EventArgs e)
        {
            this.Back.BackColor = Color.SkyBlue;
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.Back, "Backward");
        }
        private void Back_MouseLeave(object sender, EventArgs e)
        {
            this.Back.BackColor = Color.Transparent;
        }




        //forwardbutton hover
        private void Next_MouseHover(object sender, EventArgs e)
        {
            this.Next.BackColor = Color.SkyBlue;
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.Next, "Forward");
        }
        private void Next_MouseLeave(object sender, EventArgs e)
        {
            this.Next.BackColor = Color.Transparent;
        }



        //volume hover
        private void volume_MouseHover(object sender, EventArgs e)
        {
            this.volume.BackColor = Color.SkyBlue;
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.volume, "Volume");
        }
        private void volume_MouseLeave(object sender, EventArgs e)
        {
            this.volume.BackColor = Color.Transparent;
        }



        //fullscreen hover
        private void fullscreen_MouseHover(object sender, EventArgs e)
        {
            this.fullscreen.BackColor = Color.SkyBlue;
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.fullscreen, "Fullscreen");
        }
        private void fullscreen_MouseLeave(object sender, EventArgs e)
        {
            this.fullscreen.BackColor = Color.Transparent;
        }




        //minimise hover
        private void min_MouseHover(object sender, EventArgs e)
        {
            this.min.BackColor = Color.SkyBlue;
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.min, "Minimise");
        }
        private void min_MouseLeave(object sender, EventArgs e)
        {
            this.min.BackColor = Color.Transparent;
        }



        //maximise hover
        private void max_MouseHover(object sender, EventArgs e)
        {
            this.max.BackColor = Color.SkyBlue;
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
           
            ToolTip1.SetToolTip(this.max, "Maximise");
            
            
        }
        private void max_MouseLeave(object sender, EventArgs e)
        {
            this.max.BackColor = Color.Transparent;
        }




        private void resize_MouseHover(object sender, EventArgs e)
        {
            this.resize.BackColor = Color.SkyBlue;
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.resize, "Resize window");
        }
        private void resize_MouseLeave(object sender, EventArgs e)
        {
            this.resize.BackColor = Color.Transparent;
        }

        // Hover code end     

















        //for timer
        private void timer1_Tick(object sender, EventArgs e)
        {

            timer1.Start();
   
            //To find the current time for the progressbar auto movement
            int currenttime = Convert.ToInt32(player.Ctlcontrols.currentPosition);
            time1.Text= string.Format("{0:00}:{1:00}:{2:00}", currenttime / 3600, (currenttime / 60) % 60, currenttime % 60);

            slider.Value = currenttime;

            if (slider.Value <= 0 && flag == 0)
            {
                Pause.Hide();
                Play.Show();
            }
            else if (slider.Value > 0 && flag == 0)
            {
                Play.Hide();
                Pause.Show();
            }
        }

        



        //For Play/pause the video on spacebar click
        private void player_KeyPressEvent(object sender, AxWMPLib._WMPOCXEvents_KeyPressEvent e)
        {
           
            if(e.nKeyAscii==(short)Keys.Space)
            {
                if (Convert.ToInt32(player.playState) == 2)
                {
                    flag = 1;
                    player.Ctlcontrols.play();
                    Play.Hide();
                    Pause.Show();
                }
                else
                {
                    flag = 1;
                    player.Ctlcontrols.pause();
                    Pause.Hide();
                    Play.Show();
                }
            }
           
           
        }



        //For fast forward , bckward on right and left arrow, for Escape, Space, Enter, Up, Down
        private void player_KeyDownEvent(object sender, AxWMPLib._WMPOCXEvents_KeyDownEvent e)
        {
            if (e.nKeyCode == (short)Keys.Escape)
            {
                
                if (this.WindowState == FormWindowState.Maximized)
                {
                    //when screen widht is normal the player will fit the screen
                    player.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
                    player.Dock = DockStyle.Fill;
                    this.WindowState = FormWindowState.Maximized;
                  
                    panel1.Show();
                    panel2.Show();
                    panel3.Show();

                }
              
            }
            if (e.nKeyCode==(short)Keys.Enter)
            {
                if (this.WindowState == FormWindowState.Normal)
                {
                    this.WindowState = FormWindowState.Maximized;
                    max.Hide();
                    resize.Show();
                    panel1.Show();
                    panel2.Show();
                    panel3.Show();
                  
                }

               else 
                {
                    //when screen widht is normal the player will fit the screen
                    player.Dock = DockStyle.Fill;
                    this.WindowState = FormWindowState.Normal;
                    resize.Hide();
                    max.Show();
                    panel1.Show();
                    panel2.Show();
                    panel3.Show();
                   
                }
         
            }
            if (e.nKeyCode == (short)Keys.Right)
            {
                this.player.Ctlcontrols.currentPosition += 2;
                this.slider.Value = Convert.ToInt32(player.Ctlcontrols.currentPosition);
            }
            else if (e.nKeyCode == (short)Keys.Left)
            {
                this.player.Ctlcontrols.currentPosition -= 2;
                this.slider.Value = Convert.ToInt32(player.Ctlcontrols.currentPosition);
            }
            //for volume increase and down
            else if (e.nKeyCode == (short)Keys.Up)
            {
                if (trackBar1.Value<98)
                {
                    this.trackBar1.Value += 3;
                    this.player.settings.volume = trackBar1.Value;
                }
            }
            else if (e.nKeyCode == (short)Keys.Down)
            {
                if (trackBar1.Value>3)
                {
                    this.trackBar1.Value -= 3;
                    this.player.settings.volume = trackBar1.Value;
                }
            }

        }






        //For mutebutton to show volume button
        private void mute_Click(object sender, EventArgs e)
        {
            mute.Hide();
            volume.Show();
            trackBar1.Show();
            player.settings.volume = trackBar1.Value;
        }



       



        //double click mouse right button to play and pause
        private void player_DoubleClickEvent(object sender, AxWMPLib._WMPOCXEvents_DoubleClickEvent e)
        {

            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                flag = 1;
                player.Ctlcontrols.pause();
                Pause.Hide();
                Play.Show();
            }
            else
            {
                flag = 1;
                player.Ctlcontrols.play();
                Play.Hide();
                Pause.Show();
                
            }
        }

      
    }
}

