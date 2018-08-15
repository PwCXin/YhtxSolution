namespace Yhtx.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_CATEGORY
    {
        [Key]
        [StringLength(30)]
        public string S_ID { get; set; }

        [StringLength(50)]
        public string S_DESCRIPTION { get; set; }

        [StringLength(100)]
        public string S_CONTENT { get; set; }

        [StringLength(30)]
        public string S_PARENT { get; set; }

        public decimal? N_SEQUENCE { get; set; }

        public decimal? N_ISDELETE { get; set; }

        public decimal? N_DISUSE { get; set; }

        [StringLength(30)]
        public string S_SCOPE { get; set; }

        public decimal? n_IsSelect { get; set; }
    }
}
