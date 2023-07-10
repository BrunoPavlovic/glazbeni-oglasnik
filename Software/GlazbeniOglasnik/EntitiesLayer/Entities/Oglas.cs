namespace EntitiesLayer.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Oglas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Oglas()
        {
            Slike = new HashSet<Slike>();
            Korisnik1 = new HashSet<Korisnik>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Naziv_oglasa { get; set; }

        public string Opis { get; set; }

        public decimal Cijena { get; set; }

        [Required]
        [StringLength(50)]
        public string Lokacija { get; set; }

        [Required]
        [StringLength(10)]
        public string Kategorija { get; set; }

        public DateTime Datum_objave { get; set; }

        public byte? Prodano { get; set; }

        public int? Broj_pregleda { get; set; }

        public int Korisnik_id { get; set; }

        public virtual Korisnik Korisnik { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Slike> Slike { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Korisnik> Korisnik1 { get; set; }
    }
}
