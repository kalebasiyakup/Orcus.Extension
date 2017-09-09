public static partial class OrcusCharExtension
{
    /// <summary>
    /// Eğer dönen değer true ise "c" değişken bir rakamdır.
    /// </summary>
    /// <param name="c">Karekter</param>
    /// <returns>"c" karekteri "true" ise değişken "0" dan "9" a kadar bir değerdir. Aksi halde "false" döner.</returns>
    public static bool IsDigit(this char c)
    {
        return char.IsDigit(c);
    }
}
