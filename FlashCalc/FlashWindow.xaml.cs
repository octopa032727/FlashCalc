using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Threading;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FlashCalc
{
    /// <summary>
    /// FlashWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class FlashWindow : Window
    {
        private Random rand = new Random();
        public static List<int> numbers = new List<int>();
        private int i;
        private int colorcount;

        private DispatcherTimer flashtimer = new DispatcherTimer();

        public FlashWindow()
        {
            InitializeComponent();

            //始まる前のおまけ...
            lb_number.Foreground = new SolidColorBrush(Colors.Blue);
            lb_number.Content = "Ready";

            flashtimer.Interval = new TimeSpan(0, 0, 1);
            flashtimer.Tick += (sender, e) =>
            {
                if (i == 0)
                {
                    flashtimer.Interval = new TimeSpan(0, 0, 2);
                    lb_number.Foreground = new SolidColorBrush(Colors.Red);
                    lb_number.Content = "Go!";

                    i++;
                }
                //実際に数字を出力していく
                else if (i != MainWindow.amount + 1)
                {

                    if (colorcount == 0)
                    {
                        flashtimer.Interval = new TimeSpan(1000000);
                        lb_number.Foreground = new SolidColorBrush(Colors.Black);
                        colorcount++;
                    }
                    else
                    {
                        lb_number.Foreground = new SolidColorBrush(Colors.GreenYellow);

                        //指定した間隔に設定する
                        flashtimer.Interval = new TimeSpan((long)(MainWindow.speed * 10000000));

                        int tmp = rand.Next(MainWindow.min, MainWindow.max + 1);
                        lb_number.Content = tmp.ToString();
                        numbers.Add(tmp);

                        colorcount--;
                        i++;
                    }
                }
                else
                {
                    flashtimer.Stop();
                    lb_number.Content = string.Empty;

                    var answer = new AnswerWindow();
                    answer.Show();

                    Close();
                }
            };

            flashtimer.Start();
        }
    }
}
