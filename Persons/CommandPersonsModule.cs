using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    public class CommandPersonsModule : Nancy.NancyModule
    {
        public CommandPersonsModule()
        {
            Post["api/v1/persons"] = p => { return ""; };
            Get["api/v1/command"] = p => { return "getttt"; };
        }
    }
}
