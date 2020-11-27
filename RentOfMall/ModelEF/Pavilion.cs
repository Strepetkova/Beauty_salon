namespace RentOfMall
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pavilion")]
    public partial class Pavilion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pavilion()
        {
            Rent = new HashSet<Rent>();
        }

        public int ID { get; set; }

        public int IDMall { get; set; }

        [Required]
        [StringLength(50)]
        public string NumberPavilion { get; set; }

        public int Floor { get; set; }

        [Required]
        [StringLength(50)]
        public string Status { get; set; }

        public double Area { get; set; }

        public double CostSquareMeter { get; set; }

        public double Сoefficient { get; set; }

        public virtual Mall Mall { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rent> Rent { get; set; }
    }
}
