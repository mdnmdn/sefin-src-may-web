namespace CorsoMaggioWeb.Logic.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TestTable")]
    public partial class TestTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TestTable()
        {
        }

        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Description { get; set; }

        
    }
}
