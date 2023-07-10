using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntitiesLayer.Entities
{

    [Table("Korisnik")]
    public partial class Korisnik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Korisnik()
        {
            Oglas = new HashSet<Oglas>();
            Oglas1 = new HashSet<Oglas>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Ime { get; set; }

        [Required]
        [StringLength(50)]
        public string Prezime { get; set; }

        [Required]
        [StringLength(50)]
        public string Korime { get; set; }

        [Required]
        public string Lozinka { get; set; }

        [Required]
        [StringLength(13)]
        public string Broj_telefona { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Oglas> Oglas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Oglas> Oglas1 { get; set; }
    }
}
