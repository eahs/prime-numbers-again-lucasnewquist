// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

var primes = new List<int>(10000000) { 2, 3 , 5, 7, 11, 13};

bool IsPrime(int number)
{
    int sqrt = (int)Math.Sqrt(number);

    for (int i = 0; i < primes[i]; i++)
    {
        

        if (number % primes[i] == 0)
        {
            return false;
        }

        if (primes[i] > sqrt)
            break;
    }

    return true;
}

List<int> GetPrimes(int n)
{
    int primeCounter = 0;

    int i = 3;

    if (n < 3)
        return primes.Take(n).ToList();

    while (primeCounter != n)
    {

        if (i % 3 == 0 || i % 5 == 0 || i % 7 == 0 || i % 11 == 0 || i % 13 == 0 )
        {
        }

        else if (IsPrime(i))
        {
            primes.Add(i);
            primeCounter++;
        }

        i += 2;
    }

    return primes;
}

Stopwatch watch = new Stopwatch();

watch.Start();
GetPrimes(2000000);

watch.Stop();



Console.WriteLine($"Elapsed {watch.ElapsedMilliseconds}ms");

