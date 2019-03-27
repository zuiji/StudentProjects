using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ThePizzaChallenge.Models
{
    public class Pizza
    {
        [Key]
        public int PizzaId {get; set;}

        public string PizzaName {get; set;}
        public Pizza()
        {
        }

        public ICollection<Ingredients> Ingredients {get; set;}

        public decimal Price()
        {
            decimal teDecimal=0;
            foreach (Ingredients ingredientse in Ingredients)
            {
               teDecimal += ingredientse.PriceDecimal;
            }

            return teDecimal;
        }

    }

    public class Ingredients
    {
        [Key]
        public int IngredientsId {get; set;}

        public string IngredientsName { get; set;}

        public decimal PriceDecimal {get; set;}
        [NotMapped]
        public bool IsSelected {get; set;}

        public Ingredients()
        {
            
        }
        public Ingredients(string ingredientsName, decimal priceDecimal)
        {
            this.IngredientsName = ingredientsName;
            PriceDecimal = priceDecimal;
        }
    }
}
