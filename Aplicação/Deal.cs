using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumirApiPloomes
{
    class Deal
    {
        public Deal(string contactId)
        {
            ContactId = contactId;
        }

        public string ContactId { get; set; }
        public int StageId { get; set; }
        public string Amount { get; set; }       
        public string Title   { get; set; }
    }
}
