namespace RKIS_Lab4
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Workers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Workers()
        {
            Rent = new HashSet<Rent>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Login { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        [Required]
        [StringLength(50)]
        public string First_Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Second_Name { get; set; }

        [StringLength(50)]
        public string Middle_Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Role { get; set; }

        [StringLength(20)]
        public string Phone { get; set; }

        [Required]
        [StringLength(20)]
        public string Gender { get; set; }

        [StringLength(150)]
        public string Image { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rent> Rent { get; set; }
    }
}
