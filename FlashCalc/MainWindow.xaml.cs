using System;
using System.Collections.Generic;
using System.Linq;
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

namespace FlashCalc
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        //表示する速さ
        public static double speed;
        //表示する数
        public static int amount;
        //最小値
        public static int min;
        //最大値
        public static int max;

        public static Random rand = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_easy_Click(object sender, RoutedEventArgs e)
        {
            speed = 1.0;
            amount = rand.Next(5, 11);
            min = 1;
            max = 50;
            MessageBox.Show($"難易度:Easy\r\n速度:{speed},問題数:{amount}\r\n開始します。");

            var flash = new FlashWindow();
            flash.Show();

            Close();
        }

        private void btn_normal_Click(object sender, RoutedEventArgs e)
        {
            speed = 0.5;
            amount = rand.Next(15, 21);
            min = 50;
            max = 100;
            MessageBox.Show($"難易度:Normal\r\n速度:{speed},問題数:{amount}\r\n開始します。");

            var flash = new FlashWindow();
            flash.Show();

            Close();
        }

        private void btn_hard_Click(object sender, RoutedEventArgs e)
        {

            speed = 0.25;
            amount = rand.Next(25, 31);
            min = 50;
            max = 150;
            MessageBox.Show($"難易度:Hard\r\n速度:{speed},問題数:{amount}\r\n開始します。");

            var flash = new FlashWindow();
            flash.Show();

            Close();
        }

        private void btn_custom_Click(object sender, RoutedEventArgs e)
        {
            var custom = new CustomWindow();
            custom.Show();

            Close();
        }

        private void btn_help_Click(object sender, RoutedEventArgs e)
        {
            var help = new HelpWindow();
            help.Show();
        }
    }
}
