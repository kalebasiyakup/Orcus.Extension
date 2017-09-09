public static partial class OrcusCharExtension
{
    /// <summary>
    /// Eğer dönen değer true ise "c" değişken bir rakamdır.
    /// </summary>
    /// <param name="c">Karekter</param>
    /// <returns>"c" karekteri sayısal ise "true" döner. Aksi halde "false" döner.</returns>
    public static bool IsNumber(this char c)
    {
        return char.IsNumber(c);
    }
}
