public static partial class OrcusStringExtension
{
    public static string CleanTurkishCharacter(this string value)
    {
        value.ThrowIfNull(nameof(value));

        var mesaj = value;
        var oldValue = new[] { 'ö', 'Ö', 'ü', 'Ü', 'ç', 'Ç', 'İ', 'ı', 'Ğ', 'ğ', 'Ş', 'ş' };
        var newValue = new[] { 'o', 'O', 'u', 'U', 'c', 'C', 'I', 'i', 'G', 'g', 'S', 's' };
        for (var i = 0; i < oldValue.Length; i++)
            mesaj = mesaj.Replace(oldValue[i], newValue[i]);

        return mesaj;
    }
}
