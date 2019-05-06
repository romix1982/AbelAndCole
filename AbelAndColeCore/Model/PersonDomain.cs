using AbelAndColeCore.Entities;
using AbelAndColeCore.Utils;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace AbelAndColeCore.Model
{
   public static class PersonDomain
    {
        public static List<Person> ListPersons { get; set; }

        public static void GenerateListPersons()
        {
            ListPersons = new List<Person>()
            {
                new Person(1, "Romina", "romi@gmail.com", ValueDomain.GenerateRandomPreferences(0, new int[]{3,4}, new int[]{7,9,10})),
                new Person(2, "Sergio", "Sergio@gmail.com",  ValueDomain.GenerateRandomPreferences(1, new int[]{4}, new int[]{7,8,12})),
                new Person(3, "Martha", "Martha@gmail.com",  ValueDomain.GenerateRandomPreferences(0, new int[]{3,5}, new int[]{7})),
                new Person(4, "George", "George@gmail.com",  ValueDomain.GenerateRandomPreferences(1, new int[]{5}, new int[]{8,9,11})),
                new Person(5, "Mary", "Mary@gmail.com",  ValueDomain.GenerateRandomPreferences(0, new int[]{6}, new int[]{7,8,9,10,11,12})),
                new Person(6, "Ben", "Ben@gmail.com",  ValueDomain.GenerateRandomPreferences(2, new int[]{3,4}, new int[]{7,9,12})),
            };
;
        }

        public static List<Value> GetEspecificPreferenceByPerson(Person pPerson, EnumsSurveycs.EnumType pInformationType)
        {
            return pPerson.Preferences.Where(x => x.TypeValue.IdType == (int)pInformationType).ToList();
        }


        public static List<Value> AddPreferences(List<string> listKey, string FoodPrferences)
        {
            List<Value> lvalue = new List<Value>();
            foreach (var item in listKey)
            {
                Value v = ValueDomain.GetSpecificValue(item);
                if(v != null)
                    lvalue.Add(v);
            }
            lvalue.Add(ValueDomain.GetSpecificValue(FoodPrferences));
            return lvalue;
        }



        public static string PrintPreferences(Person pPerson)
        {
            string preferences = "";
            Value FoodPreferences = GetEspecificPreferenceByPerson(pPerson,EnumsSurveycs.EnumType.FoodPreferences).First();
            List<Value> ComunicationInterest = GetEspecificPreferenceByPerson(pPerson, EnumsSurveycs.EnumType.ComunicationPreferences);
            List<Value> FoodInterest = GetEspecificPreferenceByPerson(pPerson, EnumsSurveycs.EnumType.FoodInterest);

            preferences = "Your Preference is: \\n" + FoodPreferences.Description + "\\n Your Interest : \\n";

            foreach (var item in FoodInterest)
            {
                preferences = preferences + item.Description + ", ";
            }

            preferences =  preferences + "\\n"+ "Your favourite ways of communcation:  \\n";

            foreach (var item in ComunicationInterest)
            {
                preferences = preferences + item.Description + ", ";
            }
            return preferences;
        }




    }
}
