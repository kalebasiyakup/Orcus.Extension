public static partial class OrcusCharExtension
{
    /// <summary>
    /// Eğer dönen değer true ise "c" değişken bir harfdir.
    /// </summary>
    /// <param name="c">Karekter</param>
    /// <returns>"c" karekteri "true" ise değişken harflerden oluşan bir değerdir. Aksi halde "false" döner.</returns>
    public static bool IsLetter(this char c)
    {
        return char.IsLetter(c);
    }
}
