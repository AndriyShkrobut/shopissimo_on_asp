﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WebShop.Data.Models
{
  public class Product
  {
    public int ID { get; set; }

    [Display(Name = "Product Name")]
    public string Name { get; set; }

    public string Description { get; set; }

    [DataType(DataType.ImageUrl)]
    public string ImageURL { get; set; }

    [DataType(DataType.Currency)]
    [Column(TypeName = "money")]
    public decimal Price { get; set; }

    public virtual CartItem CartItem { get; set; }
  }
}