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
using Wpf_DZ_2.Pages;

namespace Wpf_DZ_2_Заполнение_макета_ {
    /// <summary>
    /// Логика взаимодействия для UserWindow.xaml
    /// </summary>
    public partial class UserWindow : Window {

        private PageContext _pageContext;
        public UserWindow ( ) {
            InitializeComponent ( );
            _pageContext = new PageContext ();
            this.DataContext = _pageContext;
            _pageContext.AddPage(new MainPage ());
            
        }

        private void MainPageClick ( object sender, RoutedEventArgs e ) {
            _pageContext.ChangeRootPage ( new MainPage ( ) );
        }

        private void OrdersPageClick ( object sender, RoutedEventArgs e ) {
            _pageContext.ChangeRootPage( new OrdersPage ( ) );
        }
    }
}
