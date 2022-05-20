using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Media.Animation;
using System.Windows.Threading;


namespace _11._05._2022classworkcsh
{
    public partial class MainWindow : Window
    {
        Image player = new Image();

        int sw = 0;

        long x = 500, y = 450;

        double stepcounter = 1;

        Uri uri = new Uri("чел стоит.png", UriKind.Relative);

        Window1 pause_window = new Window1();
       
        public MainWindow()
        {
            InitializeComponent();
            player.Source = new BitmapImage(uri);
            player.Height = 100;
            player.Width = 100;
            Canvas.SetLeft(player, x);
            Canvas.SetTop(player, y);
            canva.Children.Add(player);

            
            pause_window.Title = "PAUSE";
            pause_window.Topmost = true;
            //men.Owner = this;
            pause_window.Show();
            


        }

    private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (x == 5)
            {
                x = 20;
                Canvas.SetLeft(player, x);
            }
            if (x == 1100)
            {
                x = 1080;
                Canvas.SetLeft(player, x);
            }

            switch (e.Key) {
                case Key.Space:
                    if (Canvas.GetTop(player) <= 449) break;
                    else
                    {
                        DoubleAnimation animation = new DoubleAnimation();
                        uri = new Uri("чел стоит.png", UriKind.Relative);
                        player.Source = new BitmapImage(uri);
                        Canvas.SetTop(player, y);
                        animation.From = Canvas.GetTop(player);
                        animation.To = Canvas.GetTop(player) - 100;
                        animation.Duration = TimeSpan.FromSeconds(0.4);
                        animation.AutoReverse = true;
                        player.BeginAnimation(Canvas.TopProperty, animation);
                        break;
                    }

                case Key.A:
                    if (stepcounter % 3 == 0)
                    {
                        uri = new Uri("чел для проекта 1 обратно.png", UriKind.Relative);
                        player.Source = new BitmapImage(uri);
                    }
                    if (stepcounter % 3 == 1)
                    {
                        uri = new Uri("чел для проекта 2 обратно.png", UriKind.Relative);
                        player.Source = new BitmapImage(uri);
                    }
                    if (stepcounter % 3 == 2)
                    {
                        uri = new Uri("чел бежит 3 обратно.png", UriKind.Relative);
                        player.Source = new BitmapImage(uri);
                    }
                    Canvas.SetLeft(player, x -= 5);
                    stepcounter += 0.25;
                    sw = 1;
                    break;

                case Key.D:
                    if (stepcounter % 3 == 0) {
                        uri = new Uri("чел бежит 1.png", UriKind.Relative);
                        player.Source = new BitmapImage(uri);
                    }
                    if (stepcounter % 3 == 1)
                    {
                        uri = new Uri("чел бежит 2.png", UriKind.Relative);
                        player.Source = new BitmapImage(uri);
                    }
                    if (stepcounter % 3 == 2)
                    {
                        uri = new Uri("чел бежит 3.png", UriKind.Relative);
                        player.Source = new BitmapImage(uri);
                    }
                    Canvas.SetLeft(player, x += 5);
                    stepcounter += 0.25;
                    sw = 2;
                    break;

                case Key.Right:


/*                    DoubleAnimation animation1 = new DoubleAnimation();
                    uri = new Uri("чел бьёт 1.png", UriKind.Relative);
                    player.Source = new BitmapImage(uri);
                    Canvas.SetLeft(player, x);
                    animation1.From = Canvas.GetLeft(player);
                    animation1.To = Canvas.GetLeft(player) + 30;
                    animation1.Duration = TimeSpan.FromSeconds(1);



                    DoubleAnimation animation2 = new DoubleAnimation();
                    uri = new Uri("чел бьёт 2.png", UriKind.Relative);
                    player.Source = new BitmapImage(uri);
                    Canvas.SetLeft(player, x);
                    animation2.From = Canvas.GetLeft(player);
                    animation2.To = Canvas.GetLeft(player) + 30;
                    animation2.Duration = TimeSpan.FromSeconds(1);



                    DoubleAnimation animation3 = new DoubleAnimation();
                    uri = new Uri("чел бьёт 3.png", UriKind.Relative);
                    player.Source = new BitmapImage(uri);
                    Canvas.SetLeft(player, x);
                    animation3.From = Canvas.GetLeft(player);
                    animation3.To = Canvas.GetLeft(player) + 30;
                    animation3.Duration = TimeSpan.FromSeconds(1);


                    player.BeginAnimation(Canvas.LeftProperty, animation1);
                    player.BeginAnimation(Canvas.LeftProperty, animation2);
                    player.BeginAnimation(Canvas.LeftProperty, animation3);*/
                    break;
            }
        }

        private void pause_img_MouseDown(object sender, MouseButtonEventArgs e)
        {
                Window1 pause_window = new Window1();
                pause_window.Title = "PAUSE";
                pause_window.Topmost = true;
                //pause_window.Owner = this;
                pause_window.ShowDialog();
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            if (sw == 2)
            {
                uri = new Uri("чел стоит.png", UriKind.Relative);
                player.Source = new BitmapImage(uri);
            }
            if(sw == 1)
            {
                uri = new Uri("чел стоит обратно.png", UriKind.Relative);
                player.Source = new BitmapImage(uri);
            }
        }
    }
}
