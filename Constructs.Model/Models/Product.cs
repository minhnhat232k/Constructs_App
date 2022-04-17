using Constructs.Model.Abstract;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Constructs.Model.Models
{
    [Table("Product")]
    public class Product : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string Name { set; get; }
        public string Alias { get; set; }
        public int CategoryID { set; get; }
        public string Image { set; get; }
        public XElement MoreImage { set; get; }
        public decimal Price { set; get; }
        public decimal PromotionPrice { set; get; }
        public int? Warranty { get; set; }
        public string Description { set; get; }
        public string Content { set; get; }

        public bool? HomeFlag { set; get; }
        public bool? HotFlag { set; get; }
        public int? ViewCount { set; get; }

        [ForeignKey("CategoryID")]
        public virtual ProductCategory ProductCategory { set; get; }



    }
}