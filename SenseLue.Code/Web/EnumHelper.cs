using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenseLue.Code
{
    public class EnumHelper
    {
        public static IList<T> EnumToNamesList<T>() where T : struct
        {
            List<T> list = new List<T>();
            foreach (T statusName in Enum.GetValues(typeof(T)))
            {
                list.Add(statusName);
            }
            return list;
        }
    }
}
