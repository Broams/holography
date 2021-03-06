﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Holography
{
    /// <summary>
    /// Logique d'interaction pour HologramVideo.xaml
    /// </summary>
    public partial class HologramDisplay2 : Window
    {
        class Path
        {
            public string PathId { get; set; }
        }
        private string state = null;
        private Hologram2 hologram2;
        public HologramDisplay2(Hologram2 holo)
        {
            hologram2 = holo;
            InitializeComponent();
            Path PathInstance = new Path();
            PathInstance.PathId = holo.video;
            this.DataContext = PathInstance;

            myMediaElement1.LoadedBehavior = MediaState.Manual;
            myMediaElement2.LoadedBehavior = MediaState.Manual;
            myMediaElement3.LoadedBehavior = MediaState.Manual;
            myMediaElement4.LoadedBehavior = MediaState.Manual;

            myMediaElement1.MediaEnded += new RoutedEventHandler(myMediaElement1_MediaEnded);
            myMediaElement2.MediaEnded += new RoutedEventHandler(myMediaElement2_MediaEnded);
            myMediaElement3.MediaEnded += new RoutedEventHandler(myMediaElement3_MediaEnded);
            myMediaElement4.MediaEnded += new RoutedEventHandler(myMediaElement4_MediaEnded);

            myMediaElement1.MediaOpened += new RoutedEventHandler(myMediaElement1_MediaOpened);
            

            myMediaElement1.Play();
            myMediaElement2.Play();
            myMediaElement3.Play();
            myMediaElement4.Play();
            state = "play";
        }

        void myMediaElement1_MediaEnded(object sender, EventArgs e)
        {
            myMediaElement1.Position = TimeSpan.FromSeconds(0);
            myMediaElement1.Play();
        }
        void myMediaElement2_MediaEnded(object sender, EventArgs e)
        {
            myMediaElement2.Position = TimeSpan.FromSeconds(0);
            myMediaElement2.Play();
        }
        void myMediaElement3_MediaEnded(object sender, EventArgs e)
        {
            myMediaElement3.Position = TimeSpan.FromSeconds(0);
            myMediaElement3.Play();
        }
        void myMediaElement4_MediaEnded(object sender, EventArgs e)
        {
            myMediaElement4.Position = TimeSpan.FromSeconds(0);
            myMediaElement4.Play();
        }

        private void mainGrid_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            if(state == "play")
            {
                ChangerStateVideo(0);
            }
            else if(state == "pause")
            {
                ChangerStateVideo(1);
            }
        }
        private void myMediaElement1_MediaOpened(object sender, RoutedEventArgs e)
        {
            if (hologram2.check)
            {
                int duration = Convert.ToInt32(myMediaElement1.NaturalDuration.TimeSpan.TotalSeconds);
                int second = duration / 4;
                int third = duration / 2;
                int fourth = duration / 4 * 3;
                myMediaElement2.Position = new TimeSpan(0, 0, 0, second, 0);
                myMediaElement3.Position = new TimeSpan(0, 0, 0, third, 0);
                myMediaElement4.Position = new TimeSpan(0, 0, 0, fourth, 0);
            }
        }

        public void ChangerStateVideo(int stateVoulu)
        {
            if (state == "play" && stateVoulu == 1)
            {
                myMediaElement1.Pause();
                myMediaElement2.Pause();
                myMediaElement3.Pause();
                myMediaElement4.Pause();
                state = "pause";
            }
            else if (state == "pause" && stateVoulu == 0)
            {
                myMediaElement1.Play();
                myMediaElement2.Play();
                myMediaElement3.Play();
                myMediaElement4.Play();
                state = "play";
            }
            else { }
        }
    }
}