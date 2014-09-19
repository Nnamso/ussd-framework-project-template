using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using UssdFramework;

namespace $safeprojectname$.Models
{
    public class InputProcessors
    {
        public static async Task<UssdResponse> CustomGreeting(Session session, Dictionary<string, string> data)
        {
            return UssdResponse.Input(String.Format("Hello, {0} {1} {2}"
                , data["Title"], data["FirstName"], data["LastName"]));
        }
    }
}