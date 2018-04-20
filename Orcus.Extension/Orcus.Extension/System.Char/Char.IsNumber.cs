using System;

public static partial class OrcusCharExtension
{
    /// <summary>
    /// Eğer dönen değer true ise "char" değişken bir rakamdır.
    /// </summary>
    /// <param name="char">Karekter</param>
    /// <returns>"char" karekteri sayısal ise "true" döner. Aksi halde "false" döner.</returns>
    public static bool IsNumber(this char @char)
    {
        return Char.IsNumber(@char);
    }
}
