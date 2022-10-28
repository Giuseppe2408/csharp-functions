// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//programma
//stampa
Console.WriteLine("quanti numeri vuoi nell'array?");
int numArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("quali numeri vuoi nell'array?");
int[] number = new int[numArray];
for (int i = 0; i < numArray; i++)
{
    int numberInArray = Convert.ToInt32(Console.ReadLine());
    number[i] = numberInArray;  
}

StampaArray(number);
Console.WriteLine();

//quadrato con parametro
Quadrato(10);

//quadrato array
ElevaArrayAlQuadrato(number);
Console.WriteLine("la somma dei numeri dell'array è: " + SommaElementiArray(number));

//somma  array di tutti i numeri e di tutti i numeri di quadrati


SommaElementiArray(number);





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
int Quadrato(int number)
{
    int power = number * number;
    Console.WriteLine("Il quadrato del numero è: " + power);
    return power;
}
//funzione quadrato array
int[] ElevaArrayAlQuadrato(int[] array)
{

    int[] newArray = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        int arrPower = array[i] * array[i];
        
        newArray[i] = arrPower;

        Console.WriteLine("potenza di " + array[i] + " è " + newArray[i]);


    }
    

    Console.WriteLine("la somma delle potenze dei numeri dell'array è: " + SommaElementiArray(newArray));
    
    return newArray;
    


}

//funzioni somma array

int SommaElementiArray(int[] array)
{
    
    int somma = 0;
    for (int i = 0; i < array.Length; i++)
    {
        
        somma =  array[i] + somma;
              
    }
    
    
    return somma;

}
