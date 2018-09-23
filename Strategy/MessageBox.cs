using System.Collections.Generic;
using Strategy.Rules;

namespace Strategy
{
    public class MessageBox
    {
        private readonly IRules rules;

        public MessageBox(IRules rules)
        {
            this.rules = rules;
        }

        public string Title { get; set; }

        public string ErrorMessage { get; set; }

        public bool ExecuteRules()
        {
            return this.rules.RunRules(new List<object> { ErrorMessage });
        }
    }
}