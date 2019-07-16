using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Wpf.Events
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            SliderValue.Text = e.NewValue.ToString();
        }

        private void OnValueChanged2(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            SliderValue2.Text = e.NewValue.ToString();
        }

        private void StartLongRunningTask_Click(object sender, RoutedEventArgs e)
        {
            Task.Run(() => {
                for(int i=0; i< 10; i++)
                {
                    Thread.Sleep(150);
                    Application.Current.Dispatcher.Invoke(() => { Progress.Value += 10; } );
                }
            });
        }
    }
}
