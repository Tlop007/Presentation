public class Sestava
{
    // Veškerá základní identita pro daný objekt...
    /// <summary>
    /// Při kliknutí, se zdědí index objektu...
    /// </summary>
    public static byte Index { get; set; }
    /// <summary>
    /// Kontrola, aktivace kliknutí na daný objekt...
    /// </summary>
    public static bool Active { get; set; }

    // Přehled hry...
    /// <summary>
    /// Kontrola výskyt konce hry...
    /// </summary>
    public static bool KonecHry { get; set; }
    /// <summary>
    /// Kontrola při výskytu aktivace Fade efektu...
    /// </summary>
    public static bool ActiveFade { get; set; }
    /// <summary>
    /// Kontrola výskyt restartu...
    /// </summary>
    public static bool Restart { get; set; }
    /// <summary>
    /// Výskyt počet kol...
    /// </summary>
    public static int PocetHer { get; set; }
}
