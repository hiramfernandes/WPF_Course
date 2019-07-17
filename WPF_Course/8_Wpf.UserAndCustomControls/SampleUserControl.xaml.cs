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

namespace _8_Wpf.UserAndCustomControls
{
    /// <summary>
    /// Interaction logic for SampleUserControl.xaml
    /// </summary>
    public partial class SampleUserControl : UserControl
    {
        public SampleUserControl()
        {
            InitializeComponent();
        }

        public string Age
        {
            get { return AgeBox.Text; }
        }

        public string LastName
        {
            get { return LastnameBox.Text; }
        }

        public string Name
        {
            get { return NameBox.Text;  }
        }
    }
}
