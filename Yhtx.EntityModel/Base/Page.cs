using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yhtx.EntityModel.Base
{
    public class Page<T>
    {
        public int Count { get; set; }
        public List<T> _PageList { get; set; }
    }
}
