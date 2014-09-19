using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using UssdFramework;

namespace $safeprojectname$.Models.ScreenResponses
{
    public class Menus
    {
        public async static Task<UssdResponse> MainMenu(Session session)
        {
            return UssdResponse.Menu(String.Format("Welcome to {0}" + Environment.NewLine
                                                   + "1. General greeting" + Environment.NewLine
                                                   + "2. Custom greeting" + Environment.NewLine
                , session.AppName));
        }
    }
}