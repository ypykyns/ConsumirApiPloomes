using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace ConsumirApiPloomes
{

    public class Contact
    {        
        public Contact(string name, int typeId)
        {
            Name = name;
            TypeId = typeId;
        }

        public string Name { get; set; }
        public int TypeId  { get; set; }

        public int ContactId(string Name) {


            return 0;
        }
    }

    
}
