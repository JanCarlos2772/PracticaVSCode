namespace PracticaVSCode;

class Renovar_suscripcion
{
    public void Renovar()
    {
        Random random = new Random();   
        int daysUntilExpiration = random.Next(12);
        int discountPercentage = 0;
        Console.WriteLine(discountPercentage + "" + daysUntilExpiration + "Empieza despues de esto.");
        

        if(daysUntilExpiration == 0)
        {
            Console.WriteLine("Tu suscripcion ha expirado.");
        }
        else if(daysUntilExpiration == 1)
        {
            discountPercentage = 20;
            Console.WriteLine("Tu suscripcion expira en un dia!");
        }
        else if(daysUntilExpiration <= 5)
        {
            discountPercentage = 10;
            Console.WriteLine($"Tu suscripcion expirara en {daysUntilExpiration} dias.");
        }
        
        else if (daysUntilExpiration <= 10)
        {
            Console.WriteLine("Tu suscripcion expirara pronto. Renueva ahora!");

        }
        if(discountPercentage > 0)
        {
            Console.WriteLine($"Renueva ahora y ahorra un {discountPercentage}%!");
        }

        
    }    

}               