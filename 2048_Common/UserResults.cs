using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _2048_Common
{
    public class UserResults
    {
        private static string userResultsPath = "userResults.json";
        public string name;
        public int score;

        public UserResults(string name,int score)
        {
            this.name = name;
            this.score = score;
        }

        public static void CreateFileResultsIfNotExists()
        {
            if (!FileProvider.IsExists(userResultsPath))
            {
                var value = JsonConvert.SerializeObject(new List<UserResults>(), Formatting.Indented);
                FileProvider.Add(userResultsPath, value);
            }
        }

        public static void SaveResults(List<UserResults> results)
        {
            var serializedResults = JsonConvert.SerializeObject(results, Formatting.Indented);
            FileProvider.Set(userResultsPath, serializedResults);

        }

        public static List<UserResults> GetResultsFromFile()
        {
            //Считываем содержимое файла
            var serializedResults = FileProvider.Get(userResultsPath);
            //Диссериализация(возвращает указанный тип данных)
            var results = JsonConvert.DeserializeObject<List<UserResults>>(serializedResults);
            return results;

        }


    }
}
