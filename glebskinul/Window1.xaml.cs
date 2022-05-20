using System;
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

namespace _11._05._2022classworkcsh
{
    /// <summary>
    /// Логика взаимодействия для menu.xaml
    /// </summary>
    public partial class Window1 : Window
    {

        public Window1()
        {
            InitializeComponent();
            name_title.Foreground = Brushes.Red;
        }

        private void start_game_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void exit_game_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            //Application.Current.MainWindow.Close();
            if (sender is MainWindow == true) ((MainWindow)sender).Close();
            
        }
        
        
    }
}
