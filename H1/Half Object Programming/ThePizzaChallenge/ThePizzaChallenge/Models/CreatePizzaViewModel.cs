using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThePizzaChallenge.Models
{
    public class CreatePizzaViewModel
    {
        public Pizza Pizza {get; set;}
        public List<Ingredients> AllIngredients {get; set;}
    }
}
