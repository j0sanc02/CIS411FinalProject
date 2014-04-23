using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace CarLot2.Models
{
    public class Car
    {
        public int ID { get; set; }

        public bool Checked { get; set; }

        public string carID { get; set; }

        public int Year { get; set; }

        [StringLength(60, MinimumLength = 2)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        public string Make { get; set; }

        [StringLength(60, MinimumLength = 1)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        public string Model { get; set; }

        [Range(1, 1000000)]
        public int Mileage { get; set; }

        [StringLength(30, MinimumLength = 1)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        public string ExtColor { get; set; }

        [StringLength(30, MinimumLength = 1)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        public string IntColor { get; set; }


        [Range(1, 2000000)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }


    }

    public class CarDBContext:DbContext
    {
        public DbSet<Car> Cars { get; set; }
    }
}