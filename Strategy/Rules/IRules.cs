using System.Collections.Generic;

namespace Strategy.Rules
{
    public interface IRules
    {
        bool RunRules(List<object> properties);
    }
}