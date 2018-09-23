using System.Collections.Generic;
using Strategy.Rules;

namespace Strategy
{
    public class AboutBox
    {
        private readonly IRules rules;

        public AboutBox(IRules rules)
        {
            this.rules = rules;
        }

        public string Title { get; set; }

        public string About { get; set; }

        public int Version { get; set; }

        public bool ExecuteRules()
        {
            return this.rules.RunRules(new List<object> { Title, About, Version });
        }
    }
}