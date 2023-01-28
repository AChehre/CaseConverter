using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using CaseConverter.Utils;

namespace CaseConverter.Converters
{
    /// <summary>
    /// Convert to words, i.e. "My simple example"
    /// </summary>
    public class SentenceCaseConverter : ICaseConverter
    {
        /// <inheritdoc />
        public string Convert(IEnumerable<string> words)
        {
            if (words == null)
            {
                return string.Empty;
            }
            var result = new StringBuilder();
            var isFirst = true;
            foreach (var word in words)
            {
                if (!isFirst)
                {
                    result.Append(" ");
                }
                result.Append(!isFirst ? CultureInfo.CurrentCulture.TextInfo.ToLower(word).Trim() : StringUtil.ToFirstUpper(word).Trim());
                isFirst = false;
            }
            
            return result.ToString();
        }
    }
}
