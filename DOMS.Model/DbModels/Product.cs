﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DOMS.Model.DbModels
{
    [Table("DOMS_Product")]
    public class Product : BaseModel
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        public int BrandId { get; set; }
        public string Description { get; set; }
        [Required]
        public decimal CurrentCostAud { get; set; }
        public decimal CurrentCostRmb { get; set; }
        public decimal CurrentSellPriceAud { get; set; }
        [Required]
        public decimal CurrentSellPriceRmb { get; set; }
        public int CatalogueId { get; set; }
        public string Labels { get; set; }
        [Required]
        public string CreatedUserName { get; set; }
        public bool IsPublic { get; set; }

        public Brand Brand { get; set; }
        public Catalogue Catalogue { get; set; }
        public ApplicationUser CreatedUser { get; set; }
    }
}
