﻿using System;

namespace Algorithms
{
    public class BubbleSort<T> : AlgorithmBase<T> where T : IComparable // сортировка пузырьком
    {
        // Описание
        // Время: лучшее - O(n), худшее - O(n^2)

        public override void Sort()
        {
            var count = Items.Count;

            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count - i - 1; j++)
                {
                    var a = Items[j];
                    var b = Items[j + 1];

                    if (a.CompareTo(b) == 1)
                    {
                        Swop(j, j + 1);
                    }
                }
            }
        }
    }
}