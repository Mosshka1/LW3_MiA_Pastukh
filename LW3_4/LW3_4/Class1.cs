using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW3_4
{
    public class DogSingleResponse
    {
        public string message { get; set; } = string.Empty; 
        public string status { get; set; } = string.Empty;  
    }

    public class DogMultiResponse
    {
        public List<string> message { get; set; } = new List<string>();
        public string status { get; set; } = string.Empty;
    }
}
