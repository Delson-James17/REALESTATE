﻿namespace RealEstate.API.Models
{
    public class SaleorRentModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<EstateProperty>? EstateProperties { get; set; }
    }
}
