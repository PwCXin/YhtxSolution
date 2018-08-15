namespace Yhtx.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OPERATE_LOG
    {
        public decimal ID { get; set; }

        [StringLength(32)]
        public string NUM_ID { get; set; }

        [StringLength(12)]
        public string REG_ID { get; set; }

        [StringLength(18)]
        public string USER_ID { get; set; }

        [StringLength(100)]
        public string ORGANIZATION { get; set; }

        [StringLength(12)]
        public string ORGANIZATION_ID { get; set; }

        [StringLength(30)]
        public string USER_NAME { get; set; }

        [StringLength(40)]
        public string TERMINAL_ID { get; set; }

        [StringLength(14)]
        public string OPERATE_TIME { get; set; }

        [StringLength(1)]
        public string OPERATE_TYPE { get; set; }

        [StringLength(1)]
        public string OPERATE_RESULT { get; set; }

        [StringLength(4)]
        public string ERROR_CODE { get; set; }

        [StringLength(50)]
        public string OPERATE_NAME { get; set; }

        [StringLength(3000)]
        public string OPERATE_CONDITION { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? INSERT_TIME { get; set; }

        [StringLength(1)]
        public string COLLECT_TYPE { get; set; }

        [StringLength(32)]
        public string SENDID { get; set; }
    }
}
