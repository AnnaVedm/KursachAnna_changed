using System;
using System.Collections.Generic;

namespace KursachAnna.Models;

public partial class Product
{
    public int Productid { get; set; }

    public string Productname { get; set; } = null!;

    public string? Description { get; set; }

    public decimal Price { get; set; }

    public int Quantityinstock { get; set; }

    public int? Categoryid { get; set; }

    public byte[]? Photo { get; set; }

    public int? Categoriesid2 { get; set; }

    public virtual Categories2? Categoriesid2Navigation { get; set; }

    public virtual Category? Category { get; set; }

    public virtual ICollection<Orderdetail> Orderdetails { get; set; } = new List<Orderdetail>();
}
