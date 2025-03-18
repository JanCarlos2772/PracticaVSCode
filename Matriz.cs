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

    }

}
