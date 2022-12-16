using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_DZ_2_Заполнение_макета_ {
    internal class NotifyClass : INotifyPropertyChanged {

        //перерисовка интерфейса

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged ( [CallerMemberName] string property=null ) {

            PropertyChanged?.Invoke ( this, new PropertyChangedEventArgs ( property ) );

        }
    }
}
