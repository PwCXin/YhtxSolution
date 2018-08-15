namespace Yhtx.EntityModel
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataAccess : DbContext
    {
        public DataAccess()
            : base("name=DataAccess")
        {
        }

        public virtual DbSet<OPERATE_LOG> OPERATE_LOG { get; set; }
        public virtual DbSet<T_CATEGORY> T_CATEGORY { get; set; }
        public virtual DbSet<T_PERMISSION> T_PERMISSION { get; set; }
        public virtual DbSet<T_PERMISSIONRESOURCES> T_PERMISSIONRESOURCES { get; set; }
        public virtual DbSet<T_PERSON> T_PERSON { get; set; }
        public virtual DbSet<T_ROLE> T_ROLE { get; set; }
        public virtual DbSet<T_UNIT> T_UNIT { get; set; }
        public virtual DbSet<T_UNIT_PERSON> T_UNIT_PERSON { get; set; }
        public virtual DbSet<T_Person_Role> T_Person_Role { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OPERATE_LOG>()
                .Property(e => e.ID)
                .HasPrecision(13, 0);

            modelBuilder.Entity<OPERATE_LOG>()
                .Property(e => e.NUM_ID)
                .IsUnicode(false);

            modelBuilder.Entity<OPERATE_LOG>()
                .Property(e => e.REG_ID)
                .IsUnicode(false);

            modelBuilder.Entity<OPERATE_LOG>()
                .Property(e => e.USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<OPERATE_LOG>()
                .Property(e => e.ORGANIZATION)
                .IsUnicode(false);

            modelBuilder.Entity<OPERATE_LOG>()
                .Property(e => e.ORGANIZATION_ID)
                .IsUnicode(false);

            modelBuilder.Entity<OPERATE_LOG>()
                .Property(e => e.USER_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<OPERATE_LOG>()
                .Property(e => e.TERMINAL_ID)
                .IsUnicode(false);

            modelBuilder.Entity<OPERATE_LOG>()
                .Property(e => e.OPERATE_TIME)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OPERATE_LOG>()
                .Property(e => e.OPERATE_TYPE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OPERATE_LOG>()
                .Property(e => e.OPERATE_RESULT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OPERATE_LOG>()
                .Property(e => e.ERROR_CODE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OPERATE_LOG>()
                .Property(e => e.OPERATE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<OPERATE_LOG>()
                .Property(e => e.OPERATE_CONDITION)
                .IsUnicode(false);

            modelBuilder.Entity<OPERATE_LOG>()
                .Property(e => e.COLLECT_TYPE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OPERATE_LOG>()
                .Property(e => e.SENDID)
                .IsUnicode(false);

            modelBuilder.Entity<T_CATEGORY>()
                .Property(e => e.S_ID)
                .IsUnicode(false);

            modelBuilder.Entity<T_CATEGORY>()
                .Property(e => e.S_DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<T_CATEGORY>()
                .Property(e => e.S_CONTENT)
                .IsUnicode(false);

            modelBuilder.Entity<T_CATEGORY>()
                .Property(e => e.S_PARENT)
                .IsUnicode(false);

            modelBuilder.Entity<T_CATEGORY>()
                .Property(e => e.N_SEQUENCE)
                .HasPrecision(38, 4);

            modelBuilder.Entity<T_CATEGORY>()
                .Property(e => e.N_ISDELETE)
                .HasPrecision(38, 4);

            modelBuilder.Entity<T_CATEGORY>()
                .Property(e => e.N_DISUSE)
                .HasPrecision(38, 4);

            modelBuilder.Entity<T_CATEGORY>()
                .Property(e => e.S_SCOPE)
                .IsUnicode(false);

            modelBuilder.Entity<T_CATEGORY>()
                .Property(e => e.n_IsSelect)
                .HasPrecision(38, 4);

            modelBuilder.Entity<T_PERMISSION>()
                .Property(e => e.S_ID)
                .IsUnicode(false);

            modelBuilder.Entity<T_PERMISSION>()
                .Property(e => e.S_PERMISSIONRESOURCES)
                .IsUnicode(false);

            modelBuilder.Entity<T_PERMISSION>()
                .Property(e => e.S_ROLE)
                .IsUnicode(false);

            modelBuilder.Entity<T_PERMISSION>()
                .Property(e => e.N_ISADD)
                .HasPrecision(38, 4);

            modelBuilder.Entity<T_PERMISSION>()
                .Property(e => e.N_ISDELETE)
                .HasPrecision(38, 4);

            modelBuilder.Entity<T_PERMISSION>()
                .Property(e => e.N_ISEDIT)
                .HasPrecision(38, 4);

            modelBuilder.Entity<T_PERMISSION>()
                .Property(e => e.N_ISQUERY)
                .HasPrecision(38, 4);

            modelBuilder.Entity<T_PERMISSION>()
                .Property(e => e.N_ISDEL)
                .HasPrecision(38, 4);

            modelBuilder.Entity<T_PERMISSIONRESOURCES>()
                .Property(e => e.S_ID)
                .IsUnicode(false);

            modelBuilder.Entity<T_PERMISSIONRESOURCES>()
                .Property(e => e.S_DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<T_PERMISSIONRESOURCES>()
                .Property(e => e.S_PARENT)
                .IsUnicode(false);

            modelBuilder.Entity<T_PERMISSIONRESOURCES>()
                .Property(e => e.N_SEQUENCE)
                .HasPrecision(38, 4);

            modelBuilder.Entity<T_PERMISSIONRESOURCES>()
                .Property(e => e.S_CONTENT)
                .IsUnicode(false);

            modelBuilder.Entity<T_PERMISSIONRESOURCES>()
                .Property(e => e.S_KEY)
                .IsUnicode(false);

            modelBuilder.Entity<T_PERMISSIONRESOURCES>()
                .Property(e => e.N_ISDELETE)
                .HasPrecision(38, 4);

            modelBuilder.Entity<T_PERMISSIONRESOURCES>()
                .Property(e => e.S_URL)
                .IsUnicode(false);

            modelBuilder.Entity<T_PERMISSIONRESOURCES>()
                .Property(e => e.S_IMAGE)
                .IsUnicode(false);

            modelBuilder.Entity<T_PERMISSIONRESOURCES>()
                .Property(e => e.N_ISMENU)
                .HasPrecision(38, 4);

            modelBuilder.Entity<T_PERMISSIONRESOURCES>()
                .Property(e => e.S_UUID)
                .IsUnicode(false);

            modelBuilder.Entity<T_PERMISSIONRESOURCES>()
                .Property(e => e.S_MENUSTYLE)
                .IsUnicode(false);

            modelBuilder.Entity<T_PERSON>()
                .Property(e => e.S_ID)
                .IsUnicode(false);

            modelBuilder.Entity<T_PERSON>()
                .Property(e => e.S_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<T_PERSON>()
                .Property(e => e.S_PASSWORD)
                .IsUnicode(false);

            modelBuilder.Entity<T_PERSON>()
                .Property(e => e.S_UNIT)
                .IsUnicode(false);

            modelBuilder.Entity<T_PERSON>()
                .Property(e => e.S_UNITNAME)
                .IsUnicode(false);

            modelBuilder.Entity<T_PERSON>()
                .Property(e => e.S_DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<T_PERSON>()
                .Property(e => e.S_SEX)
                .IsUnicode(false);

            modelBuilder.Entity<T_PERSON>()
                .Property(e => e.N_SEQUENCE)
                .HasPrecision(38, 4);

            modelBuilder.Entity<T_PERSON>()
                .Property(e => e.S_IDENTIFICATION)
                .IsUnicode(false);

            modelBuilder.Entity<T_PERSON>()
                .Property(e => e.S_DUTY)
                .IsUnicode(false);

            modelBuilder.Entity<T_PERSON>()
                .Property(e => e.S_TEL)
                .IsUnicode(false);

            modelBuilder.Entity<T_PERSON>()
                .Property(e => e.S_PHONE)
                .IsUnicode(false);

            modelBuilder.Entity<T_PERSON>()
                .Property(e => e.S_EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<T_PERSON>()
                .Property(e => e.S_FAX)
                .IsUnicode(false);

            modelBuilder.Entity<T_PERSON>()
                .Property(e => e.S_ST)
                .IsUnicode(false);

            modelBuilder.Entity<T_PERSON>()
                .Property(e => e.S_JWT)
                .IsUnicode(false);

            modelBuilder.Entity<T_PERSON>()
                .Property(e => e.S_POLICENUM)
                .IsUnicode(false);

            modelBuilder.Entity<T_PERSON>()
                .Property(e => e.S_DTEL)
                .IsUnicode(false);

            modelBuilder.Entity<T_PERSON>()
                .Property(e => e.N_DISUSE)
                .HasPrecision(1, 0);

            modelBuilder.Entity<T_PERSON>()
                .Property(e => e.S_GROUP)
                .IsUnicode(false);

            modelBuilder.Entity<T_PERSON>()
                .Property(e => e.S_CATEGORY)
                .IsUnicode(false);

            modelBuilder.Entity<T_PERSON>()
                .Property(e => e.S_ASSIGNMENT)
                .IsUnicode(false);

            modelBuilder.Entity<T_PERSON>()
                .Property(e => e.N_STATUS)
                .HasPrecision(38, 4);

            modelBuilder.Entity<T_PERSON>()
                .Property(e => e.N_NORMAL)
                .HasPrecision(38, 4);

            modelBuilder.Entity<T_PERSON>()
                .Property(e => e.S_REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<T_PERSON>()
                .Property(e => e.S_REMARKSTWO)
                .IsUnicode(false);

            modelBuilder.Entity<T_PERSON>()
                .Property(e => e.S_REMARKSTHREE)
                .IsUnicode(false);

            modelBuilder.Entity<T_PERSON>()
                .Property(e => e.S_DEVICEID)
                .IsUnicode(false);

            modelBuilder.Entity<T_PERSON>()
                .Property(e => e.N_ISDELETE)
                .HasPrecision(38, 4);

            modelBuilder.Entity<T_PERSON>()
                .Property(e => e.S_LOGINID)
                .IsUnicode(false);

            modelBuilder.Entity<T_ROLE>()
                .Property(e => e.S_ID)
                .IsUnicode(false);

            modelBuilder.Entity<T_ROLE>()
                .Property(e => e.S_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<T_ROLE>()
                .Property(e => e.N_ISDELETE)
                .HasPrecision(38, 4);

            modelBuilder.Entity<T_ROLE>()
                .Property(e => e.S_CATEGORY)
                .IsUnicode(false);

            modelBuilder.Entity<T_ROLE>()
                .Property(e => e.S_CONTENT)
                .IsUnicode(false);

            modelBuilder.Entity<T_UNIT>()
                .Property(e => e.S_ID)
                .IsUnicode(false);

            modelBuilder.Entity<T_UNIT>()
                .Property(e => e.S_DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<T_UNIT>()
                .Property(e => e.S_PARENT)
                .IsUnicode(false);

            modelBuilder.Entity<T_UNIT>()
                .Property(e => e.S_PRINCIPAL)
                .IsUnicode(false);

            modelBuilder.Entity<T_UNIT>()
                .Property(e => e.S_ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<T_UNIT>()
                .Property(e => e.S_TEL)
                .IsUnicode(false);

            modelBuilder.Entity<T_UNIT>()
                .Property(e => e.N_SEQUENCE)
                .HasPrecision(38, 4);

            modelBuilder.Entity<T_UNIT>()
                .Property(e => e.S_FAX)
                .IsUnicode(false);

            modelBuilder.Entity<T_UNIT>()
                .Property(e => e.S_EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<T_UNIT>()
                .Property(e => e.S_IP)
                .IsUnicode(false);

            modelBuilder.Entity<T_UNIT>()
                .Property(e => e.S_TASK)
                .IsUnicode(false);

            modelBuilder.Entity<T_UNIT>()
                .Property(e => e.S_REGION)
                .IsUnicode(false);

            modelBuilder.Entity<T_UNIT>()
                .Property(e => e.S_SPELL)
                .IsUnicode(false);

            modelBuilder.Entity<T_UNIT>()
                .Property(e => e.N_EXECUTE)
                .HasPrecision(38, 4);

            modelBuilder.Entity<T_UNIT>()
                .Property(e => e.N_DISUSE)
                .HasPrecision(38, 4);

            modelBuilder.Entity<T_UNIT>()
                .Property(e => e.N_ISDELETE)
                .HasPrecision(38, 4);

            modelBuilder.Entity<T_UNIT>()
                .Property(e => e.S_CATEGORY)
                .IsUnicode(false);

            modelBuilder.Entity<T_UNIT>()
                .Property(e => e.S_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<T_UNIT>()
                .Property(e => e.S_FULLNAME)
                .IsUnicode(false);

            modelBuilder.Entity<T_UNIT>()
                .Property(e => e.S_SIMPLE)
                .IsUnicode(false);

            modelBuilder.Entity<T_UNIT>()
                .Property(e => e.N_NORMAL)
                .HasPrecision(38, 4);

            modelBuilder.Entity<T_UNIT>()
                .Property(e => e.S_FONTCOLOR)
                .IsUnicode(false);

            modelBuilder.Entity<T_UNIT>()
                .Property(e => e.S_DY)
                .IsUnicode(false);

            modelBuilder.Entity<T_UNIT>()
                .Property(e => e.S_UNITTJ)
                .IsUnicode(false);

            modelBuilder.Entity<T_UNIT_PERSON>()
                .Property(e => e.S_ID)
                .IsUnicode(false);

            modelBuilder.Entity<T_UNIT_PERSON>()
                .Property(e => e.S_UNITID)
                .IsUnicode(false);

            modelBuilder.Entity<T_UNIT_PERSON>()
                .Property(e => e.S_PERSONID)
                .IsUnicode(false);

            modelBuilder.Entity<T_UNIT_PERSON>()
                .Property(e => e.S_CATEGORY)
                .IsUnicode(false);

            modelBuilder.Entity<T_UNIT_PERSON>()
                .Property(e => e.S_REGION)
                .IsUnicode(false);

            modelBuilder.Entity<T_Person_Role>()
                .Property(e => e.S_PERSONID)
                .IsUnicode(false);

            modelBuilder.Entity<T_Person_Role>()
                .Property(e => e.S_ROLE_ID)
                .IsUnicode(false);

            modelBuilder.Entity<T_Person_Role>()
                  .Property(e => e.S_Id)
                  .IsUnicode(false);
        }
    }
}
