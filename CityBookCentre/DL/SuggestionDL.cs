using CityBookCentre.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityBookCentre.DL
{
    public class SuggestionDL
    {
        public static List<Suggestion> suggestions = new List<Suggestion>();

        public static void loadSuggestions()
        {
            string suggestionsWholeLine;

            string path = "suggestions.txt";
            StreamReader file = new StreamReader(path);
            while (!file.EndOfStream)
            {
                suggestionsWholeLine = file.ReadLine();
                string[] fileData = suggestionsWholeLine.Split(',');
                //suggestionBookArray[suggestionCount] = fileData[0];
                //suggestionArray[suggestionCount] = fileData[1];
                suggestions.Add(new Suggestion(fileData[0], fileData[1]));
            }
            file.Close();
        }
    }
}
