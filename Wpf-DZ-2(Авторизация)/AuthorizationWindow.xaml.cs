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
using Wpf_DZ_2_Заполнение_макета_.ViewModel;

namespace Wpf_DZ_2_Заполнение_макета_ {
    /// <summary>
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window {

        private AuthorizationVM vm;
        public AuthorizationWindow ( ) {
            InitializeComponent ( );
            vm = new AuthorizationVM ( );
            this.DataContext = vm;
        }

        private void Button_Click ( object sender, RoutedEventArgs e ) {
            //vm.PasswordUser=pwdBox.Password;


            //if (vm.Auth ( )) MessageBox.Show ( Global.User.Name );
            ////MessageBox.Show ( vm.LoginUser + " " + vm.PasswordUser);
            ////if(vm.Auth ( ) ) {

            ////}
            ///
            if (vm.Auth ( pwdBox.Password ) ) {
                (new UserWindow()).Show ();
                this.Owner.Close ( );
                this.Close ();
            }
        }
    }
}
