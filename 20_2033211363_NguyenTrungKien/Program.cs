﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_2033211363_NguyenTrungKien
{
    internal class Search
    {
        static void Main(string[] args)
        {
            BSKhongDeQuy bsKhongDeQuy = new BSKhongDeQuy();;
            int[] array = { 11, 2, 7, 5, 4, 23, 22, 5, 6, 1, 99, 76, 21 };
            Console.Write("\n\nMang chua sap xep: ");
            foreach (int value in array)
            {
                Console.Write(value + " ");
            }
            Array.Sort(array);
            Console.Write("\n\nMang sau khi sap xep: ");
            foreach (int value in array)
            {
                Console.Write(value + " ");
            }
            Console.Write("\n\nNhap so tim kiem: ");
            int target = int.Parse(Console.ReadLine());
            int indexKhongDeQuy = bsKhongDeQuy.BinarySearchKhongDeQuy(array, target);
            if (indexKhongDeQuy != -1)
            {
                Console.WriteLine($"\nTim thay phan tu {target} tai vi tri {indexKhongDeQuy} ");
            }
            else
            {
                Console.WriteLine($"\nKhong tim thay phan tu {target}");
            }
            Console.ReadKey();
        }
    }
}