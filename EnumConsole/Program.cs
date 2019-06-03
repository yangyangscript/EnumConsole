using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EnumConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = GetAttrEnum<EnumTest, EnumAttribute>();
            items.ForEach(s=>Console.WriteLine($"{s.en.ToString()}//////{s.attr?.Name1}-{s.attr?.Name2}-{s.attr?.Name3}"));
            Console.ReadLine();
        }

        public class RetClass<En,Attr> where Attr:System.Attribute
        {
            public En en { get; set; }

            public Attr attr { get; set; }
        }

        public static List<RetClass<En,Attr>> GetAttrEnum<En, Attr>() where Attr:System.Attribute 
        {
            var attributType = typeof(Attr);
            var enType = typeof(En);

            //自己去查BindingFlags
            return enType.GetMembers(BindingFlags.Static | BindingFlags.Public)
                .Select(s => new RetClass<En, Attr>()
                {
                    en = (En) Enum.Parse(enType, s.Name, false),
                    attr = (Attr) System.Attribute.GetCustomAttribute(s, attributType)
                }).ToList();
        }
    }
}
