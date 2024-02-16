using System;

class Program {
  
  public static void Main (string[] args) {
    Console.WriteLine ("Enter the Philippine Bank Note: ");
    if (decimal.TryParse(Console.ReadLine(), out decimal denomination)) 
    {
      banknotePersonality (denomination);
    }
    else
    {
      Console.WriteLine($"Invalid Denomination: {denomination}");
    }
  }

  public static void banknotePersonality (decimal denomination)
  {
    string person = "No person is found";

    switch (denomination)
    {
    case 1:
      person = "Jose Rizal is found in 1 php.";
      break;
    case 5:
      person = "Emilio Aguinaldo is found in 5 php.";
      break;
    case 10:
      person = "Andres Bonifacio & Apolinario Mabini are found in 10 php.";
      break;
    case 20:
      person = "Manuel L. Quezon is found in 20 php.";
      break;
    case 50:
      person = "Sergio Osmena is found in 50 php.";
      break;
    case 100:
      person = "Manuel Roxas is found in 100 php.";
      break;
    case 200:
      person = " Diosdado Macapagal is found in 200 php.";
      break;
    case 500:
      person = "Benigno Sr. & Corazon Aquino are found in 500 php.";
      break;
    case 1000:
      person = "Jose Abad Santos, Vicente Lim, & Josefa Llanes Escoda are found in 1000 php.";
      break;
    default:
      Console.WriteLine($"Invalid Denomination: {denomination}");
      return;
      }
      Console.WriteLine($"Personality found: {person}");
      
    
    }
  }
  
  
  
  
    