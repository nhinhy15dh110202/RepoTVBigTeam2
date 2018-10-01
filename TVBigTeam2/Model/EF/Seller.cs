namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Seller")]
    public partial class Seller
    {
        public int SellerID { get; set; }

        [StringLength(50)]
        public string SellerName { get; set; }

        [StringLength(50)]
        public string SellerAdress { get; set; }

        public int? SellerLimit { get; set; }

        public bool SellerStatus { get; set; }

        [StringLength(50)]
        public string SellerNote { get; set; }
    }
}
