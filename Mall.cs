namespace RKIS_Lab4
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Mall")]
    public partial class Mall
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mall()
        {
            Pavilion = new HashSet<Pavilion>();
            Rent = new HashSet<Rent>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        public int? Amount_P { get; set; }

        [StringLength(50)]
        public string Town { get; set; }

        [Column(TypeName = "money")]
        public decimal? Cost { get; set; }

        public double? Coeff_cost { get; set; }

        public int? Floor { get; set; }

        [StringLength(150)]
        public string Image { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pavilion> Pavilion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rent> Rent { get; set; }
    }
}
