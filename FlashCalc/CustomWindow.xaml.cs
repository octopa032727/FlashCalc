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

namespace FlashCalc
{
    /// <summary>
    /// CustomWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class CustomWindow : Window
    {
        public CustomWindow()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, RoutedEventArgs e)
        {
            double speed;
            int amount;
            int min, max;

            bool sresult = double.TryParse(tb_speed.Text, out speed);
            bool aresult = int.TryParse(tb_amount.Text, out amount);
            bool miresult = int.TryParse(tb_min.Text, out min);
            bool maresult = int.TryParse(tb_max.Text, out max);

            //数値への変換が可能か判断
            if ((sresult && aresult) && (miresult && maresult))
            {

                MainWindow.speed = speed;
                MainWindow.amount = amount;
                MainWindow.min = min;
                MainWindow.max = max;

                var flash = new FlashWindow();
                flash.Show();

                Close();
            }
        }

        private void btn_back_Click(object sender, RoutedEventArgs e)
        {
            var main = new MainWindow();
            main.Show();

            Close();
        }
    }
}
