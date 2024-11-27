public static void Strobe()//UND
{
    if (SelectedRGBColor == 0)
    {
        colorr = Color.red;
    }
    if (SelectedRGBColor == 1)
    {
        colorr = Color.green;
    }
    if (SelectedRGBColor == 2)
    {
        colorr = Color.blue;
    }
    if (SelectedRGBColor == 3)
    {
        colorr = Color.cyan;
    }
    if (SelectedRGBColor == 4)
    {
        colorr = Color.white;
    }
    Codes.StartDelay(delegate
    {
        SelectedRGBColor++;
        SetPlayerColor(colorr);
        if (SelectedRGBColor > 4)
        {
            SelectedRGBColor = 0;
        }
    }, .09f);
    FlushRpcs();
}
