using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yhtx.EntityModel
{
    public class T_Person_Role
    {
        [Key]
        [StringLength(100)]
        public string S_Id { get; set; }
        [StringLength(30)]
        public string S_PERSONID { get; set; }
        [StringLength(30)]
        public string S_ROLE_ID { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime D_UPDATETIME { get; set; }
    }
}
