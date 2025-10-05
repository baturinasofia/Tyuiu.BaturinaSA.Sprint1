﻿using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.BaturinaSA.Sprint1.Task6.V10.Lib
{
    public class DataService : ISprint1Task6V10
    {
        public string DeleteMiddleLetter(string value)
        {
            string[] words = value.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length % 2 != 0)
                {
                    words[i] = words[i].Remove(words[i].Length / 2, 1);
                }
            }
            string res = string.Join(" ", words);
            return res;
        }
    }
}