using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp
{
    public class List
    {
        Dictionary<String, List<string>> myDictionary { get; set; } = new Dictionary<string, List<string>>();
    }
}
