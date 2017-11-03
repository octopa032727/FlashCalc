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
    /// ResultWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class ResultWindow : Window
    {
        public ResultWindow()
        {
            InitializeComponent();

            //答え
            int sum = FlashWindow.numbers.Sum();
            //予想した答え
            int youranswer = AnswerWindow.youranswer;

            tb_trueans.Text = sum.ToString();
            tb_yourans.Text = youranswer.ToString();

            //結果の判断
            if (sum.Equals(youranswer))
            {
                lb_result.Foreground = new SolidColorBrush(Colors.Red);
                lb_result.Content = "おめでとう! 正解!";
            }
            else
            {
                lb_result.Foreground = new SolidColorBrush(Colors.Blue);
                lb_result.Content = "残念! 不正解!";
            }
        }

        private void btn_back_Click(object sender, RoutedEventArgs e)
        {
            var main = new MainWindow();
            main.Show();
            FlashWindow.numbers.RemoveRange(0, FlashWindow.numbers.Count);

            Close();
        }
    }
}
