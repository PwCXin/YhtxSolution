namespace Yhtx.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_UNIT_PERSON
    {
        [Key]
        [StringLength(40)]
        public string S_ID { get; set; }

        [StringLength(30)]
        public string S_UNITID { get; set; }

        [StringLength(32)]
        public string S_PERSONID { get; set; }

        [StringLength(50)]
        public string S_CATEGORY { get; set; }

        [StringLength(50)]
        public string S_REGION { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? D_UPDATETIME { get; set; }
    }
}
