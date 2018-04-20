using System;

public static partial class OrcusCharExtension
{
    /// <summary>
    /// Eğer dönen değer true ise "char" değişken bir rakamdır.
    /// </summary>
    /// <param name="char">Karekter</param>
    /// <returns>"char" karekteri "true" ise değişken "0" dan "9" a kadar bir değerdir. Aksi halde "false" döner.</returns>
    public static bool IsDigit(this char @char)
    {
        return Char.IsDigit(@char);
    }
}
