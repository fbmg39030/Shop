﻿namespace Shop.API.Models;

public class OrderProductsDbo : BaseDbo
{
    public virtual OrderDbo Order { get; set; }
    public virtual ProductDbo Product {  get; set; }
    public virtual int Quantity { get; set; }
    public virtual decimal UnitPrice { get; set; }
}
