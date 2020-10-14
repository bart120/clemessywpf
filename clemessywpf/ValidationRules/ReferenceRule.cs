using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace clemessywpf.ValidationRules
{
    public class ReferenceRule: ValidationRule
    {
        public int Max { get; set; } = 8;

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            var txt = value?.ToString();
            if (txt != null)
            {
                if(txt.Length > Max)
                {
                    return new ValidationResult(false, $"Le nombre maximum de caractères est: {Max}");
                }
            }
            return  ValidationResult.ValidResult;
        }
    }
}
