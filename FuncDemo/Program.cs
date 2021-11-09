﻿using System;
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
            var testArray = new[] {1, 3, 4, 7, 9, 10, 15, 19};
            AddTwoNums(30, 40).Tee(Console.WriteLine);
            new StringBuilder()
                .Append("Hei og hallo, ")
                .AddSequence(merText, (builder, c) => builder
                    .Append(c)).Tee(Console.WriteLine);

            var intList = Enumerable.Range(0, testArray.Length)
                .Select(x => testArray[x])
                .Where(x => x > 10);
            foreach (var num in intList) Console.WriteLine(num);

            var enumerable = testArray.Select(x => x)
                .Where(x => x > 10);
            foreach (var i in enumerable) Console.WriteLine(i);
            foreach (var num in testArray) Console.WriteLine(num);
        }
        
        public static Func<int, int, int> AddTwoNums = (num1, num2) => num1 + num2; //????? but why....

        public static StringBuilder AddSequence<T>(this StringBuilder @this,
            IEnumerable<T> seq,
            Func<StringBuilder, T, StringBuilder> fn) => seq.Aggregate(@this, fn);
    }
}
