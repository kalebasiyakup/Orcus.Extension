using System;

public static partial class OrcusCharExtension
{
    /// <summary>
    /// Eğer dönen değer true ise "char" değişken bir rakamdır.
    /// </summary>
    /// <param name="_char">Karekter</param>
    /// <returns>"char" karekteri sayısal ise "true" döner. Aksi halde "false" döner.</returns>
    public static bool IsNumber(this char _char)
    {
        return Char.IsNumber(_char);
    }
}
