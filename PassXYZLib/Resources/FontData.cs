using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PassXYZLib.Resources
{
    static public class FontData
    {
        public static Dictionary<string, string> GetGlyphs(Type type)
        {
            var fields = type.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy);
            var dictionary = new Dictionary<string, string>();

            foreach (var field in fields)
            {
                if (field.IsLiteral && !field.IsInitOnly && field.FieldType == typeof(string))
                {
                    dictionary.Add(field.Name, (string)field.GetRawConstantValue());
                }
            }

            return dictionary;
        }
    }
}
