namespace LeetCode
{
    public class CountItemsMatchingARule1773
    {
        public int CountMatchesSolution(IList<IList<string>> items, string ruleKey, string ruleValue)
        {
            int count = 0;

            // sikl
            foreach (var item in items)
            {
                if (ruleKey == "type")
                    if (ruleValue == item[0])
                        count++;

                if (ruleKey == "color")
                    if (ruleValue == item[1])
                        count++;
                
                if (ruleKey == "name")
                    if (ruleValue == item[2])
                        count++;
            }

            return count;
        }
        
        public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue)
        {
            int count = 0;
            foreach (var item in items)
            {
                if (ruleKey == "type")
                    if (ruleValue == item[0])
                        count++;

                if (ruleKey == "color")
                    if (ruleValue == item[1])
                        count++;
                
                if (ruleKey == "name")
                    if (ruleValue == item[2])
                        count++;
            }

            return count;
        }
    }
}
