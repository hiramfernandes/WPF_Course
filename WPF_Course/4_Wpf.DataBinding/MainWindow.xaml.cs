using _5_Wpf.DataBinding.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows;

namespace _5_Wpf.DataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Craftsman Craftsman { get; set; }
        public ObservableCollection<Craftsman> Craftsmen { get; set; }

        public MainWindow()
        {
            Craftsman = new Craftsman()
            {
                Age = 10,
                Name = "Woody",
                LastName = "Woodpecker",
                PicturePath = "Images/Woody.jfif"
            };

            Craftsmen = new ObservableCollection<Craftsman>()
            {
                new Craftsman() {Age = 10, LastName = "Woodpecker", Name = "Woody", PicturePath = "Images/Woody.jfif" },
                new Craftsman() {Age = 12, LastName = "Woodpecker2", Name = "Woody2", PicturePath = "Images/Woody2.jiff" },
            };

            InitializeComponent();
        }

        private void AddCraftsman_OnClick(object sender, RoutedEventArgs e)
        {
            Craftsmen.Add(
                new Craftsman()
                {
                    Age = 12,
                    Name = "Some Name",
                    LastName = "Some Last Name"
                });
        }
    }
}
