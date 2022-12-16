using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Wpf_DZ_2_Заполнение_макета_ {
    internal class PageContext : NotifyClass {

        private Stack<UserControl> _pages = new Stack<UserControl> ( );

        public UserControl CurrentPage { get; private set; }

        //добавление новой страницы и присваивание новой страницы
        public void AddPage ( UserControl page ) {
            _pages.Push ( page );
            CurrentPage = page;
            OnPropertyChanged ( "CurrentPage" );
        }

        //удаление страницы
        public void DropPage ( ) {
            _pages.Pop ( );
            CurrentPage = _pages.Peek ( );
            OnPropertyChanged ( "CurrentPage" );
        }

        //текущую страницу удалить, добавить какую мы запросили
        public void NextPage ( UserControl page ) {
            DropPage ( );
            AddPage ( page );

        }

        //получение типа данных страницы
        public void RefreshPage ( params object[] parameters ) {
            Type typePage = CurrentPage.GetType ( );
            CurrentPage = ( UserControl ) Activator.CreateInstance ( typePage, parameters );
        }

        public void ChangeRootPage ( UserControl rootPage ) {
            _pages.Clear ( );
            AddPage ( rootPage );
        }
    }
}
