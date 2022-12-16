using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Wpf_DZ_2_Заполнение_макета_ {
    internal class UserContext {
        private UserContext ( User user ) {

            _user = user;
            _currentUserContext = this;
            OnPropertyChanged ( "CurrentUserContext" );
        }

        private User _user;
        public User User { get { return _user; } }


        private static UserContext _currentUserContext;
        public static UserContext CurrentUserContext {
            get { return _currentUserContext; }
        }

        public void ClearUser ( ) {
            _currentUserContext = null;
        }

        //переключение на другую кнопку из главного меню старые страницы затираются и берется новая из стэк
        public static void CreateUserContext ( User user ) {
            if ( CurrentUserContext != null ) {
                new UserContext ( user ); 
            }
        }

        //статический NotifyPropertyChanged
        public static event PropertyChangedEventHandler PropertyChanged;
        protected static void OnPropertyChanged ( [CallerMemberName] string property = null ) {

            PropertyChanged?.Invoke ( CurrentUserContext, new PropertyChangedEventArgs ( property ) );

        }


    }
}
