using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewApp.Services
{
    public class DivisibleNumberService : IDivisibleNumberService
    {
        private Dictionary<int, string> _pairings = new Dictionary<int, string>();

        public void AddPair(int value, string word)
        {
            _pairings.Add(value, word);
        }

        public Dictionary<int, string> Pairings()
        {
            return _pairings;
        }

        public string IsDvisible(int number)
        {
            var result = "";

            foreach(var pair in _pairings)
            {
                if (number % pair.Key == 0)
                {
                    result += pair.Value;
                }
            }

            if (string.IsNullOrEmpty(result))
            {
                result += number.ToString();
            }

            return result;
        }

        public IEnumerable<string> GetAllValues(int maxValue)
        {
            for (int i = 1; i <= maxValue; i++)
            {
                yield return IsDvisible(i);
            }
        }
    }
}
