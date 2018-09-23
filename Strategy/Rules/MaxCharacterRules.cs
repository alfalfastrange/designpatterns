﻿using System.Collections.Generic;
using System.Linq;

namespace Strategy.Rules
{
    public class MaxCharacterRules : IRules
    {
        private const int MAX_CHARACTER_LENGTH = 100;

        public bool RunRules(List<object> properties)
        {
            var results = new List<bool>();
            foreach (object item in properties)
            {
                if (item is string && item != null)
                {
                    string s = item as string;
                    results.Add(s.Length <= MAX_CHARACTER_LENGTH);
                }
            }
            return results.All(x => x == true) && results.Any();
        }
    }
}