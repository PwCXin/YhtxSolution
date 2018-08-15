using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yhtx.EntityModel.Base
{
   public class Tree
    {
        public string id { get; set; }
        public string label { get; set; }
        public List<Tree> children { get; set; }
    }
}
