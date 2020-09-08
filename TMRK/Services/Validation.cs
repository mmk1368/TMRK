using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

public static class Validation
{
    public static string NormalizeDate(this string date)
    {
        date = date.Insert(4, "/");
        date = date.Insert(7, "/");
        return date;
    }
}
