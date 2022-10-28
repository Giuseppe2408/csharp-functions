// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//programma
//stampa

int[] number = { 2, 6, 7, 5, 3, 9 };
StampaArray(number);
Console.WriteLine();

//quadrato con parametro
Quadrato(10);

//quadrato array

ElevaArrayAlQuadrato();

//somma array
int somma = 0;
SommaElementiArray();

//somma di tutti i numeri di quadrati


//funzioni
//funzione per stampare un array
void StampaArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("elemento " + (i + 1));
        Console.WriteLine(" " + array[i]);    
    }
}

//funzione quadrato
void Quadrato(int number)
{
   int power = number * number;
    Console.WriteLine("Il quadrato del numero è: " + power);
}
//funzione quadrato array
void ElevaArrayAlQuadrato()
{
    for (int i = 0; i < number.Length; i++)
    {
        int arrPower = number[i] * number[i];
        int[] newArray = new int[number.Length];
        newArray[i] = arrPower;
        Console.WriteLine("potenza di tutti i num " + newArray[i]);

    }
}

//funzioni somma array

void SommaElementiArray()
{
    for(int i = 0; i < number.Length; i++)
    {
        somma =  number[i] + somma;
        
    }
    Console.WriteLine("la somma dei numeri dell'array è: " + somma);
}
