namespace RKIS_Lab4
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Rent")]
    public partial class Rent
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int? ID_tenan { get; set; }

        public int? ID_Mall { get; set; }

        public int? ID_workers { get; set; }

        [StringLength(10)]
        public string Num_pav { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Start_rent { get; set; }

        [Column(TypeName = "date")]
        public DateTime End_rent { get; set; }

        public virtual Mall Mall { get; set; }

        public virtual Pavilion Pavilion { get; set; }

        public virtual Tenants Tenants { get; set; }

        public virtual Workers Workers { get; set; }
    }
}
