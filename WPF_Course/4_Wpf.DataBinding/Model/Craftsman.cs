using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _5_Wpf.DataBinding.Model
{
    public class Craftsman : INotifyPropertyChanged
    {
        private int _age;

        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age
        {
            get
            {
                Thread.Sleep(3200);
                return _age;
            }
            set
            {
                _age = value;
            }
        }

        public string PicturePath { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

    }
}
