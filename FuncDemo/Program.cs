using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FuncDemo
{
    static class Program
    {
        static void Main(string[] args)
        {
            var merText = new List<string> {"dette ", "er ", "en test "};
            AddTwoNums(30, 40).Tee(Console.WriteLine);
            new StringBuilder()
                .Append("Hei og hallo, ")
                .AddSequence(merText, (builder, c) => builder
                    .Append(c)).Tee(Console.WriteLine);
        }
        
        public static Func<int, int, int> AddTwoNums = (num1, num2) => num1 + num2; //????? but why....

        public static StringBuilder AddSequence<T>(this StringBuilder @this,
            IEnumerable<T> seq,
            Func<StringBuilder, T, StringBuilder> fn) => seq.Aggregate(@this, fn);
    }
}
