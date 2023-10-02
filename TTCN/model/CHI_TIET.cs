namespace WindowsFormsApp1.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CHI_TIET
    {
        [Key]
        [StringLength(15)]
        public string MA_CHI_TIET { get; set; }

        [Required]
        [StringLength(150)]
        public string TEN_CHI_TIET { get; set; }
    }
}
