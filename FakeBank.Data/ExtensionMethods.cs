using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeBank.Data
{
    public static class ExtensionMethods
    {
        public static string Generate16DigitString()
        {
            var rand = new Random();
            var builder = new StringBuilder();
            while (builder.Length < 16)
            {
                builder.Append(rand.Next(10).ToString());
            }
            return builder.ToString();
        }
    }
}
