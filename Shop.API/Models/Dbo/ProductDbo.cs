﻿using NHibernate.Type;
using System.ComponentModel;
using System.Xml.Linq;

namespace Shop.API.Models.Dbo;

public class ProductDbo : BaseDbo
{
    public virtual string Name1 { get; set; }
    public virtual string Description { get; set; }
    public virtual decimal Price { get; set; }
    public virtual ProductStatus Status { get; set; }
    public virtual string Tag { get; set; }
    public virtual List<string> ImageUrl { get; set; }
}

public enum ProductStatus
{
    INSTOCK,
    LOWSTOCK,
    OUTOFSTOCK,
    INACTIVE
}
