// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

////programma
////stampa
//Console.WriteLine("quanti numeri vuoi nell'array?");
//int numArray = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("quali numeri vuoi nell'array?");
//int[] number = new int[numArray];
//for (int i = 0; i < numArray; i++)
//{
//    int numberInArray = Convert.ToInt32(Console.ReadLine());
//    number[i] = numberInArray;  
//}

//StampaArray(number);
//Console.WriteLine();

////quadrato con parametro
//Quadrato(10);

////quadrato array
//ElevaArrayAlQuadrato(number);
//Console.WriteLine("la somma dei numeri dell'array è: " + SommaElementiArray(number));

////somma  array di tutti i numeri e di tutti i numeri di quadrati


//SommaElementiArray(number);





////funzioni
////funzione per stampare un array
//void StampaArray(int[] array)
//{
//    for (int i = 0; i < array.Length; i++)
//    {
//        Console.Write("elemento " + (i + 1));
//        Console.WriteLine(" " + array[i]);    
//    }
//}

////funzione quadrato
//int Quadrato(int number)
//{
//    int power = number * number;
//    Console.WriteLine("Il quadrato del numero è: " + power);
//    return power;
//}
////funzione quadrato array
//int[] ElevaArrayAlQuadrato(int[] array)
//{

//    int[] newArray = new int[array.Length];

//    for (int i = 0; i < array.Length; i++)
//    {
//        int arrPower = array[i] * array[i];

//        newArray[i] = arrPower;

//        Console.WriteLine("potenza di " + array[i] + " è " + newArray[i]);


//    }


//    Console.WriteLine("la somma delle potenze dei numeri dell'array è: " + SommaElementiArray(newArray));

//    return newArray;



//}

////funzioni somma array

//int SommaElementiArray(int[] array)
//{

//    int somma = 0;
//    for (int i = 0; i < array.Length; i++)
//    {

//        somma =  array[i] + somma;

//    }


//    return somma;

//}





/* Si chiede di implementare due funzioni che eseguano le corrsipettive funzioni matematiche:
    1 - Fattoriale di un numero
    2 - La sequenza di fibonacci di un numero
    1) il fattoriale di un numero può essere calcolato solo su numeri positivi:
0! = 1
1! = 1
2! = 2
3! = 6
4! = 24
5! = 120
N! = ???
    risolverla in modo RICORSIVO
    o anche in modo ITERATIVO (FOR)
        n	Fn
        0	0
        1	1
        2	1
        3	2
        4	3
        5	5
        6	8
        7	13
        8	21
        9	34
        10	55
fibonacci(10) = 55
*/


//funzione fattoriale il fattoriale è la moltiplicazione decrescente di un num es. 3! = 3x2x1 = 6

//FunctionFibonacciNumber();
Console.WriteLine(Factorial(5));
//Console.WriteLine(FunctionFibonacciNumber(9));

int Factorial(int number)
{
    if (number == 1)
    {
        return 1;
    }
    else
    {
        return number * Factorial(number - 1);
    }

}



//Fibonacci sequenza di numeri il cui numero successivo è la somma dei due numeri precedenti
//prendere la somma delle due somme precedenti 

int FunctionFibonacciNumber(int num)
{
    //numero + somma delle somme precedenti
}