public class passStrength
{
    //Sjekker om lengden av passordet er mer enn 10

    //Sjekker om passordet inneholder symboler
    public bool pSymbols(string password)
    {
        foreach (char c in password)
        {
            if (!char.IsLetterOrDigit(c))
            {
                return true;
            }
            
        }
        Console.Write(" Missing symbols ");
        
        return false;
    }
}