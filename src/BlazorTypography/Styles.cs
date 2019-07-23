using System;
using System.Collections;
using System.Collections.Generic;

namespace BlazorTypography
{
    //TODO: Remove duplicate styles (they dont hurt, but just cleaner)
    public class Styles : IEnumerable<KeyValuePair<string, string>>
    {
        private readonly IDictionary<string, string> _styles = new Dictionary<string, string>();

        public void AddStyle(string selector, string rules)
        {
            if (_styles.ContainsKey(selector))
            {
                string newRules = _styles[selector] + Environment.NewLine + rules;
                _styles[selector] = newRules;
            }
            else
            {
                _styles.Add(selector, rules);
            }
        }

        public void AddStyles(IList<string> selectors, string rules)
        {
            foreach (string selector in selectors)
            {
                AddStyle(selector, rules);
            }
        }

        public IEnumerator<KeyValuePair<string, string>> GetEnumerator()
        {
            return _styles.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _styles.GetEnumerator();
        }
    }
}
