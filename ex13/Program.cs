  Console.Clear();
        Console.Write("Введите число: ");
        int n = int.Parse(Console.ReadLine()!);


        if (n > 99 && n < -99) 
       {
          while (n>999)
             n=n/10;
             return n=n%10;
         Console.Write(n);
         }
        else 
        Console.Write("третьей цифры нет");
       
    
