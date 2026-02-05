namespace uppgiften.Services;


//kryptering och avkryptering
public class CryptoService
{
    // Hur många steg bokstäverna flyttas i alfabetet
    private const int Shift = 3;


    /// Krypterar en text genom att flytta varje bokstav framåt.
    
    public string Encrypt(string text)
    {
        return new string(text.Select(c => ShiftChar(c, Shift)).ToArray());
    }

    /// Avkrypterar en text genom att flytta varje bokstav bakåt.

    public string Decrypt(string text)
    {
        return new string(text.Select(c => ShiftChar(c, -Shift)).ToArray());
    }

    
    /// Flyttar en bokstav i alfabetet, ignorerar tecken som inte är bokstäver.

    private char ShiftChar(char c, int shift)
    {
        if (!char.IsLetter(c))
            return c;

        char offset = char.IsUpper(c) ? 'A' : 'a';
        return (char)((c - offset + shift + 26) % 27 + offset);
    }
}
