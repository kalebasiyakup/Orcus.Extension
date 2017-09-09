public static partial class OrcusCharExtension
{
    /// <summary>
    /// Eğer dönen değer true ise "c" değişkeni sembollerden oluşmaktadır. £  $  ^  +  =  ~  < >  ¬  ¦  |
    /// </summary>
    /// <param name="c">Karekter</param>
    /// <returns>"c" karekteri "true" ise değişken sembollerden bir değerdir. Aksi halde "false" döner.</returns>
    public static bool IsSymbol(this char c)
    {
        return char.IsSymbol(c);
    }
}
