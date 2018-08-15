namespace Yhtx.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_PERMISSIONRESOURCES
    {
        [Key]
        [StringLength(32)]
        public string S_ID { get; set; }

        [StringLength(100)]
        public string S_DESCRIPTION { get; set; }

        [StringLength(32)]
        public string S_PARENT { get; set; }

        public decimal? N_SEQUENCE { get; set; }

        [StringLength(2000)]
        public string S_CONTENT { get; set; }

        [StringLength(50)]
        public string S_KEY { get; set; }

        public decimal? N_ISDELETE { get; set; }

        [StringLength(500)]
        public string S_URL { get; set; }

        [StringLength(200)]
        public string S_IMAGE { get; set; }

        public decimal? N_ISMENU { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? D_ADDTIME { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? D_UPDATETIME { get; set; }

        [StringLength(200)]
        public string S_UUID { get; set; }

        [StringLength(200)]
        public string S_MENUSTYLE { get; set; }
    }
}
