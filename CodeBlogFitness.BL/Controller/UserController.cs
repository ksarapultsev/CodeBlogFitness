using CodeBlogFitness.BL.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlogFitness.BL.Controller
{
   public class UserController
    {
        public User User { get; }
        public UserController(string userName, string genderName, DateTime birthDay, double weight, double heigth )
        {
            // TODO: Проверка
            var gender = new Gender(genderName);
            var user = new User(userName, gender, birthDay, weight, heigth);
            User = user ?? throw new ArgumentNullException("Ошибка, пользователь не может равен null");

        }

        /// <summary>
        /// Сохранить данные пользователя
        /// </summary>
        public void Save()
        {
            var formatter = new BinaryFormatter();
            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, User);
            }

        }
        /// <summary>
        /// Получить данные пользователя
        /// </summary>
        /// <returns></returns>
        public UserController()
        {
            var formatter = new BinaryFormatter();
            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                if( formatter.Deserialize(fs) is User user)
                {
                    User = user;
                }
                 
                //TODO: Что делать если пользователя не прочитали?
                

            }
        }
    }
}
