namespace EntitiesLayer.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Slike")]
    public partial class Slike
    {
        public int Id { get; set; }

        public int Oglas_id { get; set; }

        [Required]
        public byte[] Slika { get; set; }

        public virtual Oglas Oglas { get; set; }
    }
}
