namespace RentOfMall
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Renter")]
    public partial class Renter
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Renter()
        {
            Rent = new HashSet<Rent>();
        }

        [Key]
        [Column("ID Renter")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Renter { get; set; }

        [Column("ID Rent")]
        public int? ID_Rent { get; set; }

        [MaxLength(50)]
        public byte[] Name { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        public string Address { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rent> Rent { get; set; }

        public virtual Rent Rent1 { get; set; }
    }
}
