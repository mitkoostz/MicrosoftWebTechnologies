using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MunicipalityStaraZagora.Models
{
    public class NewsItemViewModel
    {
        //CITY|NAME|DATE|DESCRIPTION|IMAGE
        public string CityName { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string ForwardLink { get; set; }
    }
}
