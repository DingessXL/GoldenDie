using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Core
{
    public static class DiceEvaluator
    {
        public static void Evaluate(string raw)
        {
            raw = raw.Replace(" ", string.Empty);
            String pattern = @"([-+*/])";
            String[] atoms = Regex.Split(raw, pattern);

        }
    }
}