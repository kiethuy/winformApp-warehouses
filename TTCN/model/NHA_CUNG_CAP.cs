namespace WindowsFormsApp1.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    [Table("NHA_CUNG_CAP")]
    public partial class NHA_CUNG_CAP
    {
        [Key]
        [StringLength(15)]
        public string MA_NHA_CUNG_CAP { get; set; }

        [Required]
        [StringLength(150)]
        public string TEN_NHA_CUNG_CAP { get; set; }

    }
}
