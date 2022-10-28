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
int[] newArray = new int[number.Length];

ElevaArrayAlQuadrato();

//somma  array di tutti i numeri e di tutti i numeri di quadrati
int somma = 0;
int sommaPotenza = 0;
SommaElementiArray();



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
        
        newArray[i] = arrPower;
        Console.WriteLine("potenza di " + number[i] + " è " + newArray[i]);

    }
    
}

//funzioni somma array

void SommaElementiArray()
{
    
    for (int i = 0; i < number.Length; i++)
    {
        
        somma =  number[i] + somma;
        sommaPotenza = newArray[i] + sommaPotenza;
        
    }
    Console.WriteLine("la somma dei numeri dell'array è: " + somma);
    Console.WriteLine("la somma delle potenze è: " + sommaPotenza);
    
}
