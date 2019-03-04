using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlogFitness.BL.Model
{
    /// <summary>
    /// Пользователь
    /// </summary>
 
    class User
    {
        /// <summary>
        /// Имя.
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Пол
        /// </summary>
        public Gender Gender { get; }
        /// <summary>
        /// День рождения
        /// </summary>
        public DateTime BirthDate { get; }

        /// <summary>
        /// Вес
        /// </summary>

        public double Weight { get; set; }
        /// <summary>
        /// Рост
        /// </summary>

        public double Height { get; set; }

        public User(string name, 
                    Gender gender, 
                    DateTime birthDate, 
                    double weight, 
                    double height)
        {
            #region Проверка условий
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя пользователя не может быть пустым или null", nameof(name));
            }

            if (gender == null)
            {
                throw new ArgumentNullException("пол не может быть Null", nameof(gender));
            }
            if(birthDate <DateTime.Parse("01.01.1900") && birthDate>= DateTime.Now)
            {
                throw new ArgumentNullException("дата не корректа", nameof(birthDate));
            }

            if (weight <=0)
            {
                throw new ArgumentNullException("Вес меньше нуля", nameof(weight));
            }

            if (height <= 0)
            {
                throw new ArgumentNullException("Рост меньше нуля", nameof(height));
            }

            #endregion
            Name = name;
            Gender = gender;
            BirthDate = birthDate;
            Weight = weight;
            Height = height;
                
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
