public class passStrength
{
    //Sjekker om lengden av passordet er mer enn 10
    public bool pLength(int length)
    {
        if(length > 10)
        {
            return true;
        } 
        Console.Write(" Password is too short ");
        return false;
    }
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