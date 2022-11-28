using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_Algorithms
{
    public class SearchNumber
    {
        private string filepath = @"E:\Basic Core Program\Data Structure Algorithms\Data_Structure_Algorithms\Data Structure Algorithms\HashTable.json";
        Hashtable Hashtable = new Hashtable();
        public void SearchData(string searchValue)
        {
            bool existData = false;
            string readnumbers = File.ReadAllText(filepath);
            string fileData = JsonConvert.DeserializeObject<string>(readnumbers);
            string[] numbers = fileData.Split(' ');
            for (int i = 0; i < numbers.Length; i++)
            {
                Hashtable.Add(i, numbers[i]);
            }
            foreach (var key in Hashtable.Keys)
            {
                Console.WriteLine("{0}: {1}", key, Hashtable[key]);
            }
            foreach (int key in Hashtable.Keys)
            {
                if (Hashtable[key].Equals(searchValue))
                {
                    existData = true;
                    Hashtable.Remove(key);
                    break;
                }
            }
            if (!existData)
            {
                int insertKey = Hashtable.Count + 1;
                Hashtable.Add(insertKey, searchValue);
            }

            string[] joinstring = new string[Hashtable.Count];
            int j = 0;
            foreach (int key in Hashtable.Keys)
            {
                string result = Convert.ToString(Hashtable[key]);
                joinstring[j] = result;
                j++;

            }
            string combineNumbers = string.Join(" ", joinstring);
            string writeNumbers = JsonConvert.SerializeObject(combineNumbers);
            File.WriteAllText(filepath, writeNumbers);
        }
        public void Display()
        {
            foreach (var key in Hashtable.Keys)
            {
                Console.WriteLine("{0}: {1}", key, Hashtable[key]);
            }
        }
    }
}

