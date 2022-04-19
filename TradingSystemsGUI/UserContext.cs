using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradingSystemServer;

namespace TradingSystemsGUI
{
    public static class UserContext
    {
        private static User _user;

        public static void SetUserContext(User user)
        {
            _user = user;
        }

        public static User GetUserContext()
        {
            return _user;
        }

        public static void ClearUserContext()
        {
            _user = null;
        }
    }
}
