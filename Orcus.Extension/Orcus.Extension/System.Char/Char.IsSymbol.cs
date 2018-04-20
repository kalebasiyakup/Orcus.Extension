using System;

public static partial class OrcusCharExtension
{
    /// <summary>
    /// Eğer dönen değer true ise "char" değişkeni sembollerden oluşmaktadır. £  $  ^  +  =  ~  < >  ¬  ¦  |
    /// </summary>
    /// <param name="char">Karekter</param>
    /// <returns>"char" karekteri "true" ise değişken sembollerden bir değerdir. Aksi halde "false" döner.</returns>
    public static bool IsSymbol(this char @char)
    {
        return Char.IsSymbol(@char);
    }
}
