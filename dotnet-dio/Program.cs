﻿using desenv_dotnet.Common.Models;
using System;
 
class Solution {
    public static void Main(string[] args) {
        int n = 2;
        int count = 0;
 
        for (int i = 1; i <= n; i++) {
// TODO: Crie as outras condições necessárias para a resolução do desafio:
            if (n % i == 0) {
                Console.WriteLine($"Execuçāo {count} e indice {i}");
                count++;
            }
        }
        Console.WriteLine(count == 3);
    }
}