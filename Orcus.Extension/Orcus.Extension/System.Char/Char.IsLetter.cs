using System;

public static partial class OrcusCharExtension
{
    /// <summary>
    /// Eğer dönen değer true ise "char" değişken bir harfdir.
    /// </summary>
    /// <param name="char">Karekter</param>
    /// <returns>"char" karekteri "true" ise değişken harflerden oluşan bir değerdir. Aksi halde "false" döner.</returns>
    public static bool IsLetter(this char @char)
    {
        return Char.IsLetter(@char);
    }
}
