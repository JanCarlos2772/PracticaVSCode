namespace PracticaVSCode;

class Matriz
{
    public void CrearUna()
    {
        /*
         string [] fraudulentOrderIDs = new string[3];
       
        fraudulentOrderIDs[0] = "A123";
        fraudulentOrderIDs[1] = "B456";
        fraudulentOrderIDs[2] = "C789";
        //fraudulentOrderIDs[3] = "D000";

        */ 

        /*  
        Declaracion  de matriz con inicializacion inmediata.
        También puede ver una sintaxis anterior que se usa para inicializar una matriz{Usando llaves}.
 
          string[] fraudulentOrderIDs = { "A123", "B456", "C789" };
        */

        //Este ejemplo usa la sintaxis de Expresión de colección, que se introdujo en C# 12.
        string [] fraudulentOrderIDs = ["A123", "B456", "C789"];

        Console.WriteLine($"Primero: {fraudulentOrderIDs[0]}.");
        Console.WriteLine($"Segundo: {fraudulentOrderIDs[1]}.");
        Console.WriteLine($"Tercero: {fraudulentOrderIDs[2]}.");

        //Reasignando el valor del primer elemento de la matriz
        fraudulentOrderIDs[0] = "F000";

        Console.WriteLine($"Reasignar primero: {fraudulentOrderIDs[0]}");
        //Uso de la Propiedad Length para contar el numero de elemtos  o el tamaño de la matriz.
        Console.WriteLine($"The are {fraudulentOrderIDs.Length} fraudulent orders to process.");

        /*La instrucción foreach ofrece una manera sencilla y limpia de iterar los elementos de una matriz. 
        La instrucción foreach procesa los elementos de matriz en orden creciente de índice, comenzando con el 
        índice 0 y terminando con el índice Length - 1. Usa una variable temporal para contener el valor del elemento
         de matriz asociado a la iteración actual. Cada iteración ejecutará el bloque de código que se encuentra debajo 
         de la declaración foreach.*/

         /*por favor, dime un manera en Csharp para yo almacenar y luego mostrar, el indice y al lado el elemento del array
          que le corresponde, en un array mientras uso un foreach para recorrer el array*/

         string[] names = ["Rowena", "Robin", "Bao"];
         foreach(string name in names)
         {
            string  i = String.IndexOf(names);
            Console.WriteLine("");
         }




    }

}
