namespace RentOfMall
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Rent")]
    public partial class Rent
    {
        [Key]
        [Column("ID Rent")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Rent { get; set; }

        [Column("ID Renter")]
        public int ID_Renter { get; set; }

        [Column("ID Mall")]
        public int ID_Mall { get; set; }

        [Column("ID Employee")]
        public int ID_Employee { get; set; }

        [Column("ID Pavilion")]
        public int ID_Pavilion { get; set; }

        [Required]
        [StringLength(50)]
        public string Status { get; set; }

        [Column("Begin Data", TypeName = "date")]
        public DateTime Begin_Data { get; set; }

        [Column("Eng Data", TypeName = "date")]
        public DateTime Eng_Data { get; set; }

        public double? CostOfRent { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Mall Mall { get; set; }

        public virtual Pavilion Pavilion { get; set; }

        public virtual Renter Renter { get; set; }
    }
}
