using System;
using System.Text.RegularExpressions;
namespace problem_solving {
    public class TimeConversion {
        public static string convert (string parameter) {
            DateTime d = DateTime.Parse (parameter);
            return d.ToString ("HH:mm:ss");
        }
    }
}