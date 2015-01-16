using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KompetanseApplikasjon.Validators
{
    public class NameValidator : ValidationAttribute
    {
        private string _name;
        private string _errorMessage;
        private int _min, _max;
        public string Test { get; set; }

        public NameValidator(int min, int max)
        {
            _min = min;
            _max = max;
        }

        public override bool IsValid(object value)
        {
            _name = (string) value;

            if (_name.Length < 4)
            {
                _errorMessage = "Navnet er for kort";
                return false;
            }
            if (_name.Length > 20)
            {
                _errorMessage = "Navnet er for langt";
                return false;
            }

            return true;
        }

        public override string FormatErrorMessage(string name)
        {
            return string.Format("{0} ({1}) - {2}", _errorMessage, _name, Test);
        }
    }
}