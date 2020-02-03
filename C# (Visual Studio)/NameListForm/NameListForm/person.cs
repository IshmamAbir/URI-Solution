using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace NameListForm
{
    class person
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }


        public string GetFullName()
        {
            return FirstName + " " + MiddleName + " " + LastName;
        }
    }
     

}



