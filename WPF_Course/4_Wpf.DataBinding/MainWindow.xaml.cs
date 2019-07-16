using _4_Wpf.DataBinding.Model;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _4_Wpf.DataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Craftsman Craftsman { get; set; }

        public MainWindow()
        {
            Craftsman = new Craftsman()
            {
                Age = 10,
                Name = "Woody",
                LastName = "Woodpecker",
                PicturePath = "Images\Woody2.jiff"
            };

            InitializeComponent();

            Binding pictureBinding = new Binding();
        }

        
    }
}
