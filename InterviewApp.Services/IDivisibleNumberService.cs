using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewApp.Services
{
    public interface IDivisibleNumberService
    {
        void AddPair(int value, string word);
        Dictionary<int, string> Pairings();
        string IsDvisible(int number);
        IEnumerable<string> GetAllValues(int maxValue);
    }
}
