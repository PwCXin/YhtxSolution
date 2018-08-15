namespace Yhtx.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_PERSON
    {
      
        [Key]
        [StringLength(32)]
        public string S_ID { get; set; }

        [StringLength(100)]
        public string S_NAME { get; set; }

        [StringLength(30)]
        public string S_PASSWORD { get; set; }

        [StringLength(30)]
        public string S_UNIT { get; set; }

        [StringLength(100)]
        public string S_UNITNAME { get; set; }

        [StringLength(50)]
        public string S_DESCRIPTION { get; set; }

        [StringLength(30)]
        public string S_SEX { get; set; }

        public decimal? N_SEQUENCE { get; set; }

        [StringLength(30)]
        public string S_IDENTIFICATION { get; set; }

        [StringLength(32)]
        public string S_DUTY { get; set; }

        [StringLength(30)]
        public string S_TEL { get; set; }

        [StringLength(30)]
        public string S_PHONE { get; set; }

        [StringLength(30)]
        public string S_EMAIL { get; set; }

        [StringLength(30)]
        public string S_FAX { get; set; }

        [StringLength(30)]
        public string S_ST { get; set; }

        [StringLength(30)]
        public string S_JWT { get; set; }

        [StringLength(20)]
        public string S_POLICENUM { get; set; }

        [StringLength(30)]
        public string S_DTEL { get; set; }

        public decimal N_DISUSE { get; set; }

        [StringLength(60)]
        public string S_GROUP { get; set; }

        [StringLength(60)]
        public string S_CATEGORY { get; set; }

        [StringLength(60)]
        public string S_ASSIGNMENT { get; set; }

        public decimal? N_STATUS { get; set; }

        public decimal? N_NORMAL { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime D_CREATETIME { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime D_UPDATETIME { get; set; }

        [StringLength(50)]
        public string S_REMARKS { get; set; }

        [StringLength(50)]
        public string S_REMARKSTWO { get; set; }

        [StringLength(50)]
        public string S_REMARKSTHREE { get; set; }

        [StringLength(32)]
        public string S_DEVICEID { get; set; }

        public decimal? N_ISDELETE { get; set; }

        [StringLength(50)]
        public string S_LOGINID { get; set; }
    }
}
