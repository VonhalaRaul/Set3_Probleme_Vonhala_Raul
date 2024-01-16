using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set3_Probleme_Vonhala_Raul
{
    internal class Program
    {
        static void Prob1()
        {
            string line = Console.ReadLine();
            string[] tokens = line.Split(new char[] { ' ', ';', ',' }, StringSplitOptions.RemoveEmptyEntries);
            int[] arr = new int[tokens.Length];
            int s = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(tokens[i]);
                
                s = s + arr[i];
            }
            Console.WriteLine($"Suma elementelor este {s}");
            Console.ReadKey();
        }

        static void Prob2()
        {
            string line = Console.ReadLine();
            string[] tokens = line.Split(new char[] { ' ', ';', ',' }, StringSplitOptions.RemoveEmptyEntries);
            int[] arr = new int[tokens.Length];
            int k;
            Console.Write("Introduceti k ");
            k=int.Parse(Console.ReadLine());
            int poz = 0;
            bool ok = false;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(tokens[i]);
                if (arr[i] == k)
                {
                    poz = i;
                    ok = true;
                    break;
                }
            }
            if (ok)
            {
                Console.WriteLine(poz);
            }
            else
                Console.WriteLine("-1");
            Console.ReadKey();


        }
        static void Prob3()
        {
            string line=Console.ReadLine();
            string[] tokens = line.Split(new char[] { ' ', ';', ',' }, StringSplitOptions.RemoveEmptyEntries);
            int[] arr = new int[tokens.Length];
            int max = int.MinValue;
            int min=int.MaxValue;
            int poz1=0,poz2 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(tokens[i]);
                if (arr[i]>max)
                {
                    max = arr[i];
                    poz1 = i;
               
                }
                if (arr[i]<min)
                {
                    min = arr[i];
                    poz2 = i;
                    
                }
                
                
            }
            Console.WriteLine($"Pozitia maximului este {poz1}, iar pozitia minimului {poz2}");
            Console.ReadKey();
        }
        static void Prob4()
        {
            string line = Console.ReadLine();
            string[] tokens = line.Split(new char[] { ' ', ';', ',' }, StringSplitOptions.RemoveEmptyEntries);
            int[] arr = new int[tokens.Length];
            int min = int.MaxValue;
            int max=int.MinValue;
            int nr = 0;
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = int.Parse(tokens[i]);
                if (arr[i]>max)
                {
                    max = arr[i];
                    nr++;
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                    nr++;
                }
               

            }
            
            Console.WriteLine($"Maximul este {max}, minimul este {min}, iar acestea apar de {nr} ori");
            Console.ReadKey();


        }

        static void Prob5()
        {
            string line = Console.ReadLine();
            string[] tokens=line.Split(new char[] {' ', ';',','}, StringSplitOptions.RemoveEmptyEntries);
            int[] arr=new int[tokens.Length];
            int e, k;
            Console.Write("Introduceti valoarea e ");
            e=int.Parse(Console.ReadLine());
            Console.Write("Introduceti pozitia k ");
            k = int.Parse(Console.ReadLine());
            for( int i=0; i<arr.Length;i++)
            {
                arr[i] = int.Parse(tokens[i]);
                arr[k] = e;

            }
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);
            Console.ReadKey();  

        }

        static void Prob6()
        {
            string line=Console.ReadLine();
            string[] tokens=line.Split(new char[] {' ',';',','}, StringSplitOptions.RemoveEmptyEntries);
            int[] arr=new int[tokens.Length];
            int k;
            Console.Write("Introduceti pozitia k ");
            k=int.Parse(Console.ReadLine());  
            
            for(int i=0; i<arr.Length;i++)
            {
                arr[i] = int.Parse(tokens[i]);
                
                
            }
            if (k > 0 && k < arr.Length)
            {
                for (int i = k; i < arr.Length - 1; i++)
                    arr[i] = arr[i + 1];
                arr[arr.Length - 1] = 0;

            }
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
            Console.ReadKey();
            
        }
        static void Prob7()
        {
            string line= Console.ReadLine();
            string[] tokens=line.Split(new char[] { ' ', ';', ',' }, StringSplitOptions.RemoveEmptyEntries);
            int[] arr = new int[tokens.Length];
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = int.Parse(tokens[i]);
                Array.Reverse(arr);
            }
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i]+ " ");
            Console.WriteLine();

            Console.ReadKey();

        }

        static void Prob8()
        {
            Console.WriteLine("Introduceti vectorul de numere separate prin spatiu:");
            string v = Console.ReadLine();

           
            string[] aux = v.Split(' ');

            
            int[] vector = new int[aux.Length];
            for (int i = 0; i < aux.Length; i++)
            {
                vector[i] = int.Parse(aux[i]);
            }

            Console.WriteLine("Vectorul initial:");
            AfiseazaVector(vector);
            RotireSpreStanga(vector);
            Console.WriteLine("Vectorul dupa rotire spre stanga:");
            AfiseazaVector(vector);

        }
        static void RotireSpreStanga(int[] vector)
        {
            int primul = vector[0];

            for (int i = 0; i < vector.Length - 1; i++)
            {
                vector[i] = vector[i + 1];
            }

            vector[vector.Length - 1] = primul;
        }
        static void AfiseazaVector(int[] vector)
        {
            foreach (int numar in vector)
            {
                Console.Write(numar + " ");
            }
            Console.WriteLine();
        }
        static void Prob9()
        {
            Console.WriteLine("Introduceti vectorul de numere separate prin spatiu:");
            string v = Console.ReadLine();

            Console.WriteLine("Introduceti numarul de pozitii pentru rotire spre stanga (k):");
            int k = int.Parse(Console.ReadLine());
            string[] aux = v.Split(' ');
            int[] vector = new int[aux.Length];
            for (int i = 0; i < aux.Length; i++)
            {
                vector[i] = int.Parse(aux[i]);
            }

            Console.WriteLine("Vectorul initial:");
            AfiseazaVector(vector);
            RotireSpreStanga(vector, k);
            Console.WriteLine($"Vectorul dupa rotire spre stanga cu {k} pozitii:");
            AfiseazaVector(vector);
        }

        static void RotireSpreStanga(int[] vector, int k)
        {
            int n = vector.Length;
            k = k % n; 
            for (int i = 0; i < k; i++)
            {
                int primul = vector[0];

                for (int j = 0; j < n - 1; j++)
                {
                    vector[j] = vector[j + 1];
                }

                vector[n - 1] = primul;
            }
        }

        static void Prob10()
        {
            Console.WriteLine("Introduceti vectorul de numere sortat in ordine crescatoare, separate prin spatiu:");
            string v = Console.ReadLine();

            Console.WriteLine("Introduceti elementul pe care doriti sa il cautati:");
            int k = int.Parse(Console.ReadLine());
            string[] aux = v.Split(' ');
            int[] vector = new int[aux.Length];
            for (int i = 0; i < aux.Length; i++)
            {
                vector[i] = int.Parse(aux[i]);
            }

            int rez = CautareBinara(vector, k);


            if (rez != -1)
            {
                Console.WriteLine($"Elementul {k} se gaseste la pozitia {rez} in vector.");
            }
            else
            {
                Console.WriteLine($"Elementul {k} nu se gaseste in vector.");
            }
        }
        static int CautareBinara(int[] vector, int k)
        {
            int stanga = 0;
            int dreapta = vector.Length - 1;

            while (stanga <= dreapta)
            {
                int mijloc = stanga + (dreapta - stanga) / 2;

                if (vector[mijloc] == k)
                {
                    return mijloc; 
                }
                else if (vector[mijloc] < k)
                {
                    stanga = mijloc + 1;
                }
                else
                {
                    dreapta = mijloc - 1; 
                }
            }

            return -1; 
        }
        static void Prob11()
        {
            Console.WriteLine("Introduceti un numar natural n:");
            int n = int.Parse(Console.ReadLine());

            CiurulluiEratostene(n);
        }
        static void CiurulluiEratostene(int n)
        {
            bool[] prim = new bool[n + 1];
            for (int i = 2; i <= n; i++)
            {
                prim[i] = true;
            }
            for (int i = 2; i * i <= n; i++)
            {
                if (prim[i])
                {
                    for (int j = i * i; j <= n; j += i)
                    {
                        prim[j] = false;
                    }
                }
            }
            Console.WriteLine($"Numerele prime mai mici sau egale cu {n} sunt:");
            for (int i = 2; i <= n; i++)
            {
                if (prim[i])
                {
                    Console.Write(i + " ");
                }
            }
        }
        static void Prob12()
        {
            Console.WriteLine("Introduceti vectorul de numere separate prin spatiu:");
            string v = Console.ReadLine();
            string[] aux = v.Split(' ');
            int[] vector = new int[aux.Length];
            for (int i = 0; i < aux.Length; i++)
            {
                vector[i] = int.Parse(aux[i]);
            }

            Console.WriteLine("Vectorul initial:");
            AfiseazaVector(vector);
            SelectionSort(vector);
            Console.WriteLine("Vectorul dupa sortare prin selectie:");
            AfiseazaVector(vector);
        }
        static void SelectionSort(int[] vector)
        {
            int n = vector.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (vector[j] < vector[min])
                    {
                        min = j;
                    }
                }

                int aux2 = vector[i];
                vector[i] = vector[min];
                vector[min] = aux2;
            }
        }

        static void Prob13()
        {
            Console.WriteLine("Introduceti vectorul de numere separate prin spatiu:");
            string v = Console.ReadLine();
            string[] aux = v.Split(' ');

            int[] vector = new int[aux.Length];
            for (int i = 0; i < aux.Length; i++)
            {
                vector[i] = int.Parse(aux[i]);
            }
            Console.WriteLine("Vectorul initial:");
            AfiseazaVector(vector);
            InsertionSort(vector);
            Console.WriteLine("Vectorul dupa sortare prin insertie:");
            AfiseazaVector(vector);
        }
        static void InsertionSort(int[] vector)
        {
            int n = vector.Length;

            for (int i = 1; i < n; i++)
            {
                int val = vector[i];
                int j = i - 1;

                while (j >= 0 && vector[j] > val)
                {
                    vector[j + 1] = vector[j];
                    j--;
                }
                vector[j + 1] = val;
            }
        }
        static void Prob14()
        {
            Console.WriteLine("Introduceti vectorul de numere separate prin spatiu:");
            string v = Console.ReadLine();
            string[] aux = v.Split(' ');
            int[] vector = new int[aux.Length];
            for (int i = 0; i < aux.Length; i++)
            {
                vector[i] = int.Parse(aux[i]);
            }
            Console.WriteLine("Vectorul initial:");
            AfiseazaVector(vector);
            InterschimbareZero(vector);
            Console.WriteLine("Vectorul dupa interschimbare:");
            AfiseazaVector(vector);
        }
        static void InterschimbareZero(int[] vector)
        {
            int n = vector.Length;
            int pozi = 0;
            for (int i = 0; i < n; i++)
            {
                if (vector[i] != 0)
                {
                    int aux2 = vector[i];
                    vector[i] = vector[pozi];
                    vector[pozi] = aux2;

                    pozi++;
                }
            }
        }
        static void Prob15()
        {
            Console.WriteLine("Introduceti vectorul de numere separate prin spatiu:");
            string v = Console.ReadLine();
            string[] aux = v.Split(' ');

            int[] vector = new int[aux.Length];
            for (int i = 0; i < aux.Length; i++)
            {
                vector[i] = int.Parse(aux[i]);
            }
            Console.WriteLine("Vectorul initial:");
            AfiseazaVector(vector);
            Eliminare(vector);
            Console.WriteLine("Vectorul dupa eliminarea duplicatelor:");
            AfiseazaVector(vector);
        }
        static void Eliminare(int[] vector)
        {
            int n = vector.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (vector[i] == vector[j])
                    {
                        for (int k = j; k < n - 1; k++)
                        {
                            vector[k] = vector[k + 1];
                        }
                        n--;
                        j--;
                    }
                }
            }
            Array.Resize(ref vector, n);
        }
        static void Prob16()
        {
            Console.WriteLine("Introduceti vectorul de numere separate prin spatiu:");
            string v = Console.ReadLine();
            string[] aux = v.Split(' ');
            int[] vector = new int[aux.Length];
            for (int i = 0; i < aux.Length; i++)
            {
                vector[i] = int.Parse(aux[i]);
            }
            Console.WriteLine("Vectorul initial:");
            AfiseazaVector(vector);
            int cmmd = CMMDV(vector);
            Console.WriteLine($"Cel mai mare divizor comun al elementelor vectorului este: {cmmd}");
        }
        static int CMMD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }
        static int CMMDV(int[] vector)
        {
            int cmmd = vector[0];

            for (int i = 1; i < vector.Length; i++)
            {
                cmmd = CMMD(cmmd, vector[i]);
                if (cmmd == 1)
                {
                    break;
                }
            }

            return cmmd;
        }
        static void Prob17()
        {
            Console.WriteLine("Introduceti numarul in baza 10:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti baza destinatie (1 < b < 17):");
            int b = int.Parse(Console.ReadLine());

            if (b < 2 || b > 16)
            {
                Console.WriteLine("Baza trebuie sa fie intre 2 si 16.");
            }
            else
            {
                string rez = Conversie(n, b);
                Console.WriteLine($"Rezultatul conversiei este: {rez} în baza {b}");
            }
        }
        static string Conversie(int numar, int baza)
        {
            if (numar == 0)
            {
                return "0";
            }

            string rez = "";

            while (numar > 0)
            {
                int rest = numar % baza;
                char cifra = (char)(rest < 10 ? '0' + rest : 'A' + rest - 10);
                rez = cifra + rez;
                numar /= baza;
            }

            return rez;
        }
        static void Prob18()
        {
            Console.WriteLine("Introduceti gradul polinomului (n):");
            int n = int.Parse(Console.ReadLine());
            double[] coeficient = new double[n + 1];

            Console.WriteLine("Introduceti coeficientii polinomului de la cel mai mic la cel mai mare grad:");
            for (int i = 0; i <= n; i++)
            {
                Console.Write($"Coeficient pentru x^{i}: ");
                coeficient[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Introduceti valoarea lui x:");
            double x = double.Parse(Console.ReadLine());

            double rez = CalculPolinom(coeficient, x);

            Console.WriteLine($"Valoarea polinomului in punctul {x} este: {rez}");
        }
        static double CalculPolinom(double[] coeficient, double x)
        {
            int n = coeficient.Length - 1;
            double rez = 0;

            for (int i = 0; i <= n; i++)
            {
                rez += coeficient[i] * Math.Pow(x, i);
            }

            return rez;
        }
        static void Prob19()
        {
            Console.WriteLine("Introduceti vectorul s de numere separate prin spatiu:");
            string sv = Console.ReadLine();
            int[] s = Array.ConvertAll(sv.Split(' '), int.Parse);

            Console.WriteLine("Introduceti vectorul p de numere separate prin spatiu:");
            string pv = Console.ReadLine();
            int[] p = Array.ConvertAll(pv.Split(' '), int.Parse);

            int rez = NumarAparitii(s, p);

            Console.WriteLine($"Vectorul p apare in vectorul s de {rez} ori.");
        }
        static int NumarAparitii(int[] s, int[] p)
        {
            int nrap = 0;

            for (int i = 0; i <= s.Length - p.Length; i++)
            { 
                if (verif(s, i, p))
                {
                    nrap++;
                }
            }

            return nrap;
        }
        static bool verif(int[] s, int start, int[] p)
        {
            for (int i = 0; i < p.Length; i++)
            {
                if (s[start + i] != p[i])
                {
                    return false;
                }
            }

            return true;
        }
        static void Prob20()
        {
            Console.WriteLine("Introduceti primul sirag de margele:");
            string s1 = Console.ReadLine();

            Console.WriteLine("Introduceti al doilea sirag de margele:");
            string s2 = Console.ReadLine();

            int rez = NumarSuprapuneri(s1, s2);

            Console.WriteLine($"Numarul de suprapuneri intre cele doua siraguri este: {rez}");
        }
        static int NumarSuprapuneri(string s1, string s2)
        {
            int nrsup = 0;
            int lungimeS1 = s1.Length;
            int lungimeS2 = s2.Length;
            for (int i = 0; i < lungimeS1; i++)
            {
                for (int j = 0; j < lungimeS2; j++)
                {
                    int supinitial = 0;
                    while (i + supinitial < lungimeS1 && j + supinitial < lungimeS2 &&
                           s1[i + supinitial] == s2[j + supinitial])
                    {
                        supinitial++;
                    }

                    nrsup += supinitial;
                }
            }

            return nrsup;
        }
        static void Prob21()
        {
            Console.WriteLine("Introduceti primul vector de numere separate prin spatiu:");
            string input1 = Console.ReadLine();
            int[] v1 = Array.ConvertAll(input1.Split(' '), int.Parse);

            Console.WriteLine("Introduceti al doilea vector de numere separate prin spatiu:");
            string input2 = Console.ReadLine();
            int[] v2 = Array.ConvertAll(input2.Split(' '), int.Parse);

            int rezultat = ComparareLexicografica(v1, v2);

            if (rezultat < 0)
            {
                Console.WriteLine("Primul vector este inaintea celui de-al doilea in ordinea lexicografica.");
            }
            else if (rezultat > 0)
            {
                Console.WriteLine("Cel de-al doilea vector este inaintea primului in ordinea lexicografica.");
            }
            else
            {
                Console.WriteLine("Cei doi vectori sunt identici in ordinea lexicografica.");
            }
        }
        static int ComparareLexicografica(int[] v1, int[] v2)
        {
            int lungimeMinima = Math.Min(v1.Length, v2.Length);

            for (int i = 0; i < lungimeMinima; i++)
            {
                if (v1[i] < v2[i])
                {
                    return -1;
                }
                else if (v1[i] > v2[i])
                {
                    return 1;
                }
            }

            if (v1.Length < v2.Length)
            {
                return -1;
            }
            else if (v1.Length > v2.Length)
            {
                return 1;
            }
            return 0;
        }

        static void Prob22()
        {
            Console.WriteLine("Introduceti primul vector de numere separate prin spatiu:");
        string input1 = Console.ReadLine();
        int[] v1 = Array.ConvertAll(input1.Split(' '), int.Parse);

        Console.WriteLine("Introduceti al doilea vector de numere separate prin spatiu:");
        string input2 = Console.ReadLine();
        int[] v2 = Array.ConvertAll(input2.Split(' '), int.Parse);
        var set1 = new HashSet<int>(v1);
        var set2 = new HashSet<int>(v2);


        var intersectie = set1.Intersect(set2).ToArray();
        AfisareRezultat("Intersectia", intersectie);

        var reuniune = set1.Union(set2).ToArray();
        AfisareRezultat("Reuniunea", reuniune);

        var diferenta1 = set1.Except(set2).ToArray();
        AfisareRezultat("Diferenta v1 - v2", diferenta1);
        var diferenta2 = set2.Except(set1).ToArray();
        AfisareRezultat("Diferenta v2 - v1", diferenta2);
        }
        static void AfisareRezultat(string operatie, int[] rezultat)
        {
            Console.WriteLine($"{operatie}: {string.Join(" ", rezultat)}");
        }
        static void Prob23()
        {
            Console.WriteLine("Introduceti primul vector de numere separate prin spatiu (in ordine crescatoare):");
            string input1 = Console.ReadLine();
            int[] v1 = Array.ConvertAll(input1.Split(' '), int.Parse);

            Console.WriteLine("Introduceti al doilea vector de numere separate prin spatiu (in ordine crescatoare):");
            string input2 = Console.ReadLine();
            int[] v2 = Array.ConvertAll(input2.Split(' '), int.Parse);
            var intersectie = Intersectie(v1, v2);
            AfisareRezultat("Intersectia", intersectie);
            var reuniune = Reuniune(v1, v2);
            AfisareRezultat("Reuniunea", reuniune);
            var diferenta1 = Diferenta(v1, v2);
            AfisareRezultat("Diferenta v1 - v2", diferenta1);
            var diferenta2 = Diferenta(v2, v1);
            AfisareRezultat("Diferenta v2 - v1", diferenta2);
        }
        static int[] Intersectie(int[] v1, int[] v2)
        {
            List<int> intersectie = new List<int>();
            int i = 0, j = 0;

            while (i < v1.Length && j < v2.Length)
            {
                if (v1[i] == v2[j])
                {
                    intersectie.Add(v1[i]);
                    i++;
                    j++;
                }
                else if (v1[i] < v2[j])
                {
                    i++;
                }
                else
                {
                    j++;
                }
            }

            return intersectie.ToArray();
        }
        static int[] Reuniune(int[] v1, int[] v2)
        {
            List<int> reuniune = new List<int>();
            int i = 0, j = 0;

            while (i < v1.Length && j < v2.Length)
            {
                if (v1[i] == v2[j])
                {
                    reuniune.Add(v1[i]);
                    i++;
                    j++;
                }
                else if (v1[i] < v2[j])
                {
                    reuniune.Add(v1[i]);
                    i++;
                }
                else
                {
                    reuniune.Add(v2[j]);
                    j++;
                }
            }

            while (i < v1.Length)
            {
                reuniune.Add(v1[i]);
                i++;
            }

            while (j < v2.Length)
            {
                reuniune.Add(v2[j]);
                j++;
            }

            return reuniune.ToArray();
        }
        static int[] Diferenta(int[] v1, int[] v2)
        {
            List<int> diferenta = new List<int>();
            int i = 0, j = 0;

            while (i < v1.Length && j < v2.Length)
            {
                if (v1[i] == v2[j])
                {
                    i++;
                    j++;
                }
                else if (v1[i] < v2[j])
                {
                    diferenta.Add(v1[i]);
                    i++;
                }
                else
                {
                    j++;
                }
            }

            while (i < v1.Length)
            {
                diferenta.Add(v1[i]);
                i++;
            }

            return diferenta.ToArray();
        }
        static void Prob24()
        {
            Console.WriteLine("Introduceti primul vector de valori binare separate prin spatiu (0 sau 1):");
            string input1 = Console.ReadLine();
            int[] v1 = Array.ConvertAll(input1.Split(' '), int.Parse);

            Console.WriteLine("Introduceti al doilea vector de valori binare separate prin spatiu (0 sau 1):");
            string input2 = Console.ReadLine();
            int[] v2 = Array.ConvertAll(input2.Split(' '), int.Parse);

            var intersectie = Intersectie2(v1, v2);
            AfisareRezultat("Intersectia", intersectie);

            var reuniune = Reuniune2(v1, v2);
            AfisareRezultat("Reuniunea", reuniune);

            var diferenta1 = Diferenta2(v1, v2);
            AfisareRezultat("Diferenta v1 - v2", diferenta1);
            var diferenta2 = Diferenta2(v2, v1);
            AfisareRezultat("Diferenta v2 - v1", diferenta2);
        }
        static int[] Intersectie2(int[] v1, int[] v2)
        {
            return v1.Zip(v2, (a, b) => a & b).ToArray();
        }
        static int[] Reuniune2(int[] v1, int[] v2)
        {
            return v1.Zip(v2, (a, b) => a | b).ToArray();
        }
        static int[] Diferenta2(int[] v1, int[] v2)
        {
            return v1.Zip(v2, (a, b) => a & ~b).ToArray();
        }
        static void Prob25()
        {
            Console.WriteLine("Introduceti primul vector sortat crescator de numere separate prin spatiu:");
            string input1 = Console.ReadLine();
            int[] v1 = Array.ConvertAll(input1.Split(' '), int.Parse);

            Console.WriteLine("Introduceti al doilea vector sortat crescator de numere separate prin spatiu:");
            string input2 = Console.ReadLine();
            int[] v2 = Array.ConvertAll(input2.Split(' '), int.Parse);

            int[] rezultat = Interclasare(v1, v2);
            AfisareRezultat("Rezultatul interclasarii", rezultat);
        }
        static int[] Interclasare(int[] v1, int[] v2)
        {
            int lungime1 = v1.Length;
            int lungime2 = v2.Length;
            int[] rezultat = new int[lungime1 + lungime2];

            int i = 0, j = 0, k = 0;

            while (i < lungime1 && j < lungime2)
            {
                if (v1[i] <= v2[j])
                {
                    rezultat[k++] = v1[i++];
                }
                else
                {
                    rezultat[k++] = v2[j++];
                }
            }

            while (i < lungime1)
            {
                rezultat[k++] = v1[i++];
            }

            while (j < lungime2)
            {
                rezultat[k++] = v2[j++];
            }

            return rezultat;
        }
        static void Prob26()
        {
            Console.WriteLine("Introduceti primul numar mare:");
            string input1 = Console.ReadLine().TrimStart('0');
            int[] numar1 = Array.ConvertAll(input1.ToCharArray(), c => c - '0');

            Console.WriteLine("Introduceti al doilea numar mare:");
            string input2 = Console.ReadLine().TrimStart('0');
            int[] numar2 = Array.ConvertAll(input2.ToCharArray(), c => c - '0');
            int[] suma = Aduna(numar1, numar2);
            AfisareRezultat("Suma", suma);
            int[] diferenta = Scade(numar1, numar2);
            AfisareRezultat("Diferenta", diferenta);
            int[] produs = Inmulteste(numar1, numar2);
            AfisareRezultat("Produsul", produs);
        }
        static int[] Aduna(int[] numar1, int[] numar2)
        {
            int maxLungime = Math.Max(numar1.Length, numar2.Length);
            int[] rezultat = new int[maxLungime + 1];

            int carry = 0;
            int index = rezultat.Length - 1;

            for (int i = 0; i < maxLungime || carry > 0; i++)
            {
                int cifra1 = (i < numar1.Length) ? numar1[numar1.Length - 1 - i] : 0;
                int cifra2 = (i < numar2.Length) ? numar2[numar2.Length - 1 - i] : 0;

                int sumaCifrelor = cifra1 + cifra2 + carry;
                rezultat[index--] = sumaCifrelor % 10;
                carry = sumaCifrelor / 10;
            }
            int firstNonZeroIndex = Array.FindIndex(rezultat, x => x != 0);
            if (firstNonZeroIndex == -1)
            {
                return new int[] { 0 };
            }

            return rezultat;

        }
        static int[] Scade(int[] numar1, int[] numar2)
        {
            if (Comparare(numar1, numar2) < 0)
            {
                int[] temp = numar1;
                numar1 = numar2;
                numar2 = temp;
            }

            int[] rezultat = new int[numar1.Length];
            int borrow = 0;

            for (int i = 0; i < numar1.Length; i++)
            {
                int cifra1 = numar1[numar1.Length - 1 - i];
                int cifra2 = (i < numar2.Length) ? numar2[numar2.Length - 1 - i] : 0;

                int difCifrelor = cifra1 - cifra2 - borrow;

                if (difCifrelor < 0)
                {
                    difCifrelor += 10;
                    borrow = 1;
                }
                else
                {
                    borrow = 0;
                }

                rezultat[rezultat.Length - 1 - i] = difCifrelor;
            }

            int firstNonZeroIndex = Array.FindIndex(rezultat, x => x != 0);
            if (firstNonZeroIndex == -1)
            {
                return new int[] { 0 };
            }

            return rezultat;
        }
        static int[] Inmulteste(int[] numar1, int[] numar2)
        {
            int[] rezultat = new int[numar1.Length + numar2.Length];

            for (int i = 0; i < numar1.Length; i++)
            {
                int carry = 0;

                for (int j = 0; j < numar2.Length || carry > 0; j++)
                {
                    int produsCifre = rezultat[rezultat.Length - 1 - i - j] + carry + numar1[numar1.Length - 1 - i] * ((j < numar2.Length) ? numar2[numar2.Length - 1 - j] : 0);
                    rezultat[rezultat.Length - 1 - i - j] = produsCifre % 10;
                    carry = produsCifre / 10;
                }
            }

            int firstNonZeroIndex = Array.FindIndex(rezultat, x => x != 0);
            if (firstNonZeroIndex == -1)
            {
                return new int[] { 0 };
            }

            return rezultat;
        }
        static int Comparare(int[] numar1, int[] numar2)
        {
            if (numar1.Length < numar2.Length)
            {
                return -1;
            }
            else if (numar1.Length > numar2.Length)
            {
                return 1;
            }

            for (int i = 0; i < numar1.Length; i++)
            {
                if (numar1[i] < numar2[i])
                {
                    return -1;
                }
                else if (numar1[i] > numar2[i])
                {
                    return 1;
                }
            }

            return 0;
        }
        static void Prob27()
        {
            Console.WriteLine("Introduceti elementele vectorului separate prin spatii:");
            int[] vector = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            Console.WriteLine("Introduceti indexul:");
            int index = int.Parse(Console.ReadLine());

            int valoareSortata = ValoareSortata(vector, index);
            Console.WriteLine($"Valoarea de pe pozitia {index} dupa sortare este: {valoareSortata}");
        }
        static int ValoareSortata(int[] vector, int index)
        {
            if (index < 0 || index >= vector.Length)
            {
                Console.WriteLine("Index invalid.");
                return -1; 
            }

            int[] vectorSortat = (int[])vector.Clone();
            Array.Sort(vectorSortat);

            return vectorSortat[index];
        }
        static void Prob28()
        {
            Console.WriteLine("Introduceti elementele vectorului separate prin spatii:");
            int[] vector = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            QuickSort(vector, 0, vector.Length - 1);

            Console.WriteLine("Vectorul sortat:");
            foreach (var element in vector)
            {
                Console.Write($"{element} ");
            }
        }
        static void QuickSort(int[] vector, int stanga, int dreapta)
        {
            if (stanga < dreapta)
            {
                int indexPartitie = Partitie(vector, stanga, dreapta);

                QuickSort(vector, stanga, indexPartitie - 1);
                QuickSort(vector, indexPartitie + 1, dreapta);
            }
        }
        static int Partitie(int[] vector, int stanga, int dreapta)
        {
            int pivot = vector[dreapta];
            int indexPivot = stanga - 1;

            for (int j = stanga; j < dreapta; j++)
            {
                if (vector[j] <= pivot)
                {
                    indexPivot++;
                    SchimbaElemente(vector, indexPivot, j);
                }
            }

            SchimbaElemente(vector, indexPivot + 1, dreapta);

            return indexPivot + 1;
        }
        static void SchimbaElemente(int[] vector, int i, int j)
        {
            int aux = vector[i];
            vector[i] = vector[j];
            vector[j] = aux;
        }
        static void Prob29()
        {
            Console.WriteLine("Introduceti elementele vectorului separate prin spatii:");
            int[] vector = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            MergeSort(vector, 0, vector.Length - 1);

            Console.WriteLine("Vectorul sortat:");
            foreach (var element in vector)
            {
                Console.Write($"{element} ");
            }
        }
        static void MergeSort(int[] vector, int stanga, int dreapta)
        {
            if (stanga < dreapta)
            {
                int mijloc = (stanga + dreapta) / 2;

                MergeSort(vector, stanga, mijloc);
                MergeSort(vector, mijloc + 1, dreapta);

                Uneste(vector, stanga, mijloc, dreapta);
            }
        }
        static void Uneste(int[] vector, int stanga, int mijloc, int dreapta)
        {
            int dimensiuneStanga = mijloc - stanga + 1;
            int dimensiuneDreapta = dreapta - mijloc;

            int[] subvectorStanga = new int[dimensiuneStanga];
            int[] subvectorDreapta = new int[dimensiuneDreapta];

            Array.Copy(vector, stanga, subvectorStanga, 0, dimensiuneStanga);
            Array.Copy(vector, mijloc + 1, subvectorDreapta, 0, dimensiuneDreapta);

            int i = 0, j = 0, k = stanga;

            while (i < dimensiuneStanga && j < dimensiuneDreapta)
            {
                if (subvectorStanga[i] <= subvectorDreapta[j])
                {
                    vector[k] = subvectorStanga[i];
                    i++;
                }
                else
                {
                    vector[k] = subvectorDreapta[j];
                    j++;
                }
                k++;
            }

            while (i < dimensiuneStanga)
            {
                vector[k] = subvectorStanga[i];
                i++;
                k++;
            }

            while (j < dimensiuneDreapta)
            {
                vector[k] = subvectorDreapta[j];
                j++;
                k++;
            }
        }
        static void Prob30()
        {
            Console.WriteLine("Introduceti elementele vectorului E separate prin spatii:");
            int[] E = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            Console.WriteLine("Introduceti elementele vectorului W (ponderi) separate prin spatii:");
            int[] W = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            if (E.Length != W.Length)
            {
                Console.WriteLine("Vectorii trebuie sa aiba aceeasi lungime.");
                return;
            }

            List<ElementPonderat> elementePonderate = new List<ElementPonderat>();

            for (int i = 0; i < E.Length; i++)
            {
                elementePonderate.Add(new ElementPonderat { Valoare = E[i], Pondere = W[i] });
            }

            SortareBicriteriala(elementePonderate);

            Console.WriteLine("Vectorii sortati:");
            foreach (var element in elementePonderate)
            {
                Console.WriteLine($"Valoare: {element.Valoare}, Pondere: {element.Pondere}");
            }
        }
        static void SortareBicriteriala(List<ElementPonderat> elementePonderate)
        {
            elementePonderate.Sort((x, y) =>
            {
                int comparareValoare = x.Valoare.CompareTo(y.Valoare);

                if (comparareValoare != 0)
                {
                    return comparareValoare;
                }

                return y.Pondere.CompareTo(x.Pondere);
            });
        }
        class ElementPonderat
        {
            public int Valoare { get; set; }
            public int Pondere { get; set; }
        }
        static void Prob31()
        {
            Console.WriteLine("Introduceti elementele vectorului separate prin spatii:");
            int[] vector = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int rezultat = GasesteElementMajoritate(vector);

            if (rezultat != -1)
            {
                Console.WriteLine($"Elementul majoritate este: {rezultat}");
            }
            else
            {
                Console.WriteLine("Nu exista element majoritate in vector.");
            }
        }
        static int GasesteElementMajoritate(int[] vector)
        {
            int candidat = -1;
            int numarAparitii = 0;


            foreach (var element in vector)
            {
                if (numarAparitii == 0)
                {
                    candidat = element;
                    numarAparitii = 1;
                }
                else if (candidat == element)
                {
                    numarAparitii++;
                }
                else
                {
                    numarAparitii--;
                }
            }

            numarAparitii = 0;
            foreach (var element in vector)
            {
                if (element == candidat)
                {
                    numarAparitii++;
                }
            }

            return (numarAparitii > vector.Length / 2) ? candidat : -1;
        }



        static void Main(string[] args)
        {
            Prob1();
            //Prob2();
            //Prob3();
            //Prob4();
            //Prob5();
            //Prob6();
            //Prob7();
            //Prob8();
            //Prob9();
            //Prob10();
            //Prob11();
            //Prob12();
            //Prob13();
            //Prob14();
            //Prob15();
            //Prob16();
            //Prob17();
            //Prob18();
            //Prob19();
            //Prob20();
            //Prob21();
            //Prob22();
            //Prob23();
            //Prob24();
            //Prob25();
            //Prob26();
            //Prob27();
            //Prob28();
            //Prob29();
            //Prob30();
            //Prob31();
            Console.ReadKey();
        }
    }
}
