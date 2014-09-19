using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UssdFramework;

namespace $safeprojectname$.Models
{
    public class Screens
    {
        public static Dictionary<string, UssdScreen> All = new Dictionary<string, UssdScreen>();

        static Screens()
        {
            All.Add("1", UssdScreen.Menu("Main menu", ScreenResponses.Menus.MainMenu));

            All.Add("1.1", UssdScreen.Notice("General greeting", ScreenResponses.Notices.GeneralGreeting));

            All.Add("1.2", UssdScreen.Input("Custom greeting"
                , new List<UssdInput>()
                {
                    new UssdInput("Title", new List<UssdInputOption>()
                    {
                        new UssdInputOption("Mr"),
                        new UssdInputOption("Mrs"),
                        new UssdInputOption("Miss"),
                        new UssdInputOption("Dr"),
                        new UssdInputOption("Prof"),
                    }),
                    new UssdInput("FirstName", "First Name"),
                    new UssdInput("LastName", "Last Name"),
                }, InputProcessors.CustomGreeting));
        }
    }
}