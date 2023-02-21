using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Concrete;

namespace Core.Extensions
{
    public static class EnumExtensions
    {
        public static string GetDescription<T>(this T enumValue) where T : struct, IConvertible
        {
            if (!typeof(T).IsEnum)
            {
                return null;
            }

            string result = enumValue.ToString();
            FieldInfo field = enumValue.GetType().GetField(enumValue.ToString());
            if (field == null)
            {
                return result;
            }

            object[] customAttributes = field.GetCustomAttributes(typeof(DescriptionAttribute), inherit: true);
            if (customAttributes != null && customAttributes.Length != 0)
            {
                result = ((DescriptionAttribute)customAttributes[0]).Description;
            }

            return result;
        }

        public static string GetDisplayName(Enum value)
        {
            return value.GetType()?.GetMember(value.ToString())?.First()?.GetCustomAttribute<DisplayAttribute>()?.Name;
        }
    }
}
