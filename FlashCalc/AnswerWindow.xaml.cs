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
    /// AnswerWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class AnswerWindow : Window
    {
        public static int youranswer;

        public AnswerWindow()
        {
            InitializeComponent();
        }

        private void btn_answer_Click(object sender, RoutedEventArgs e)
        {
            bool result = int.TryParse(tb_yourans.Text, out youranswer);

            if (result)
            {
                var resultw = new ResultWindow();
                resultw.Show();

                Close();
            }
        }
    }
}
