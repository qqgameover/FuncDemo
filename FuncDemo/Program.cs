﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FuncDemo
{
    static class Program
    {
        public static Func<int, int, int> Func = Thing;
        static void Main(string[] args)
        {
            var merText = new List<string> {"dette ", "er ", "en test "};
            Func(30, 40).Tee(Console.WriteLine);
            new StringBuilder()
                .Append("Hei og hallo, ")
                .AddSequence(merText, (builder, c) => builder
                    .Append(c)).Tee(Console.WriteLine);
        }

        public static int Thing(int num1, int num2)
        {
            return num1 + num2;
        }

        public static StringBuilder AddSequence<T>(this StringBuilder @this,
            IEnumerable<T> seq,
            Func<StringBuilder, T, StringBuilder> fn) => seq.Aggregate(@this, fn);
    }
}
