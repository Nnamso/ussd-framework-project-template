using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using UssdFramework;

namespace $safeprojectname$.Models.ScreenResponses
{
    public class Notices
    {
        public static async Task<UssdResponse> GeneralGreeting(Session session)
        {
            return UssdResponse.Notice("Hello, boss!");
        }
    }
}