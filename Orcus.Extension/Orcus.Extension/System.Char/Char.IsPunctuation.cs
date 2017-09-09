public static partial class OrcusCharExtension
{
    /// <summary>
    /// Eğer dönen değer true ise "c" değişkeni noktalama işaretlerinden oluşmaktadır. !  "  %  &  *  (  )  _  -  {  }  [  ]  :  @  ;  '  #  ?  ,  .
    /// </summary>
    /// <param name="c">Karekter</param>
    /// <returns>"c" karekteri "true" ise değişken noktalama işaretlerinden oluşan bir değerdir. Aksi halde "false" döner.</returns>
    public static bool IsPunctuation(this char c)
    {
        return char.IsPunctuation(c);
    }
}
