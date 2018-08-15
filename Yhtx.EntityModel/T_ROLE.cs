namespace Yhtx.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_ROLE
    {
        [Key]
        [StringLength(30)]
        public string S_ID { get; set; }

        [StringLength(30)]
        public string S_NAME { get; set; }

        public decimal? N_ISDELETE { get; set; }

        [StringLength(30)]
        public string S_CATEGORY { get; set; }

        [StringLength(100)]
        public string S_CONTENT { get; set; }
    }
}
