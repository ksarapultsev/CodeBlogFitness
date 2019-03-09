using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlogFitness.BL.Model
{
    [Serializable]
   public class Food
    {
        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Белки
        /// </summary>
        public double Proteins { get; }
        public double Callories { get; }

        /// <summary>
        /// Жиры
        /// </summary>
        public double Fats { get; }
        public double Carbohydates { get; }

        /// <summary>
        /// Углеводы
        /// </summary>
        public double Carbohydrates { get;}
        /// <summary>
        /// Калории за 100 грамм продукта
        /// </summary>
        public double Calories { get; }

        private double CalloriesOnGramm { get { return Calories / 100.0; } }
        private double ProteinsOnGramm { get { return Proteins / 100.0; } }
        private double FatsOneGramm { get { return Fats / 100.0; } }
        private double CarbohydratesOneGramm { get { return Carbohydrates / 100.0; } }

        public Food(string name) :this(name, 0,0,0,0)
        {          

        }

        public Food(string name, double proteins, double callories, double fats, double carbohydates)
        {
            // TODO: проверка

            Name = name;
            Proteins = proteins / 100.0;
            Callories = callories / 100.0;
            Fats = fats / 100.0;
            Carbohydates = carbohydates / 100.0;            

        }

        public override string ToString()
        {
            return Name;

        }
    }
}
