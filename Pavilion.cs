namespace RKIS_Lab4
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

        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string Num_pav { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_mall { get; set; }

        public int? Floor { get; set; }

        [StringLength(70)]
        public string Status { get; set; }

        public int? Square { get; set; }

        public int? Cost_meter { get; set; }

        public double? Coeff_cost { get; set; }

        public virtual Mall Mall { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rent> Rent { get; set; }
    }
}
