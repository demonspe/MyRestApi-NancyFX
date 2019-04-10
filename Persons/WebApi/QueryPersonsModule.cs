using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    public class QueryPersonsModule : Nancy.NancyModule
    {
        public QueryPersonsModule()
        {
            Get["/"] = _ => "Hello World!";
            Get["api/v1/persons/{id:long}"] = param =>
            {
                int id = (int)param.id;
                if(id == 0)
                    return Nancy.HttpStatusCode.NotFound;
                
                return "person " + id;
            };
            
        }
    }
}
