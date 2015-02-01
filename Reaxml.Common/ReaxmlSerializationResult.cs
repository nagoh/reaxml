using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reaxml.Common
{
    public class ReaxmlSerializationResult
    {
        public propertyList PropertyList { get; set; }
        public List<string> Errors { get; set; }
        public List<string> Warnings { get; set; }
    }
}
