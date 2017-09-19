public class Rozpolozeni
{
    public int index { get; set; }
    public bool xY { get; set; }
    public float minusPlus { get; set; }

    public Rozpolozeni(int Index, bool XY, float MinusPlus)
    {
        index = Index;
        xY = XY;
        minusPlus = MinusPlus;
    }
}
