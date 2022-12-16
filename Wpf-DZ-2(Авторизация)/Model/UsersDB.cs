using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_DZ_2_Заполнение_макета_.Model {
    internal class UsersDB {

        public List<User> Users { get; set; } = new List<User> ( ){
            new User ("Ann","ann123","123"),
            new User ("Qwe","qwe123","123"),
            new User ("Asd","Asd123","123"),
            new User ("Zxc","Zxc789","789"),
            new User ("Rty","Rty456","456"),
        };
    }
}
