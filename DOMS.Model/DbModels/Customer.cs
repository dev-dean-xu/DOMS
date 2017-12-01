﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DOMS.Model.DbModels
{
    [Table("DOMS_Customer")]
    public class Customer: BaseModel
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
        [Phone]
        public string PhoneNumber { get; set; }
        public string WechatAccount { get; set; }
        public string WechatName { get; set; }
        public string AlipayAccount { get; set; }
        public string IdCard { get; set; }
    }
}
