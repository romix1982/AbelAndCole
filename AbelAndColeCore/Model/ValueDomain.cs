using AbelAndColeCore.Entities;
using AbelAndColeCore.Utils;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace AbelAndColeCore.Model
{

    public static  class  ValueDomain
    {
        public static List<Value> ListSurveyTypes { get; set; }

        public static void GenerateTypesValues()
        {
            ListSurveyTypes = new List<Value>()
            {
                new Value(0, "Vegeterian",TypeDomain.ListTypes[0]),
                new Value(1, "Vegan", TypeDomain.ListTypes[0]),
                new Value(2, "Neither", TypeDomain.ListTypes[0]),
                new Value(0, "Email", TypeDomain.ListTypes[1]),
                new Value(1, "App", TypeDomain.ListTypes[1]),
                new Value(2, "Letter", TypeDomain.ListTypes[1]),
                new Value(3, "SMS", TypeDomain.ListTypes[1]),
                new Value(0, "SeasonalFood", TypeDomain.ListTypes[2]),
                new Value(1, "Recipes", TypeDomain.ListTypes[2]),
                new Value(2, "Fruit", TypeDomain.ListTypes[2]),
                new Value(3, "Veg", TypeDomain.ListTypes[2]),
                new Value(4, "Drinks", TypeDomain.ListTypes[2]),
                new Value(5, "Household", TypeDomain.ListTypes[2]),


            };
        }

        public static List<Value> GetSpecificPreferences(EnumsSurveycs.EnumType pInformationType)
        {

            return ListSurveyTypes.Where(x => x.TypeValue.IdType == (int)pInformationType).ToList();
            
        }

        public static Value GetSpecificValue(EnumsSurveycs.EnumValues pValue)
        {

            return ListSurveyTypes.Where(x => x.Description == pValue.ToString()).First() ;

        }

        public static Value GetSpecificValue(string valueDescription)
        {
            var result = ListSurveyTypes.Where(x => x.Description == valueDescription);
            if (result.Count() > 0)
                return result.First();
            else
                return null;
        }

        public static List<Value> GenerateRandomPreferences(int food, int[] comunication, int[] interest)
        {
            List<Value> lstPreferences = new List<Value>()
            {
                ListSurveyTypes[0],
            };

            foreach (var item in comunication)
            {
                lstPreferences.Add(ListSurveyTypes[item]);

            }

            foreach (var item in interest)
            {
                lstPreferences.Add(ListSurveyTypes[item]);

            }
            return lstPreferences;
        }

    }
}
