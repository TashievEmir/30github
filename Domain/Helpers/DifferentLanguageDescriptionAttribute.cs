using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Helpers
{
    [AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
    sealed class DifferentLanguageDescriptionAttribute : Attribute
    {
        public string En { get; }
        public string Ru { get; }
        public string Kg { get; }

        public DifferentLanguageDescriptionAttribute(string en, string ru, string kg)
        {
            En = en;
            Ru = ru;
            Kg = kg;
        }
    }
}
