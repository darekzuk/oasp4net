using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oasp4net.ServiceLayer.App_Start
{
    public class LoggingMiddleware

    {
        private readonly System.Func<System.Collections.Generic.IDictionary<string, object>,
                                  System.Threading.Tasks.Task> appFunc;

        public LoggingMiddleware( System.Func<System.Collections.Generic.IDictionary<string, object>,
                                  System.Threading.Tasks.Task> func)

        {

            this.appFunc = func;

        }

        public async Task Invoke(IDictionary<string, object> env)

        {
            Console.WriteLine("Got a Request method "+env["owin.RequestMethod"] + " with params: "+ env["owin.RequestPath"]);
            var requestHeader = (IDictionary<string, string[]>)env["owin.RequestHeaders"];

            await appFunc.Invoke(env);
        }

    }
}
