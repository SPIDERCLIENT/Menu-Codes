public static void ChangeSkyColor()//UND
{
    {
        Sky++;
    }
    if (Sky == 1)
    {
        Codes.GreenSky();
    }
    if (Sky == 2)
    {
        Codes.WhiteSky();
    }
    if (Sky == 3)
    {
        Codes.MagentaSky();
    }
    if (Sky == 4)
    {
        Codes.CyanSky();
    }
    if (Sky == 5)
    {
        Codes.GreySky();
    }
    if (Sky == 6)
    {
        Codes.RedSky();
    }
    if (Sky == 7)
    {
        Codes.BlueSky();
    }
    if (Sky == 8)
    {
        Codes.YellowSky();
    }
    if (Sky == 9)
    {
        Codes.BlackSky();
    }
    if (Sky == 10)
    {
        Codes.CustomSky();
    }
    if (Sky == 11)
    {
        Codes.FixSky();
    }
    if (Sky == 12)
    {
        Codes.FixSky();
        Sky = 0;
    }

    string[] Sky1 = new string[] { "None", "Green", "White", "Magenta", "Cyan", "Grey", "Red", "Blue", "Yellow", "Black", "Spider", "Fix", "None", };
    Main.GetIndex("Sky Color:").overlapText = "Sky Color: <color=white>[</color><color=white>" + Sky1[Sky] + "</color><color=white>]</color>";
}

public static void RedSky()//UND
{
    Renderer SkyObject = GameObject.Find("Environment Objects/LocalObjects_Prefab/Standard Sky").GetComponent<Renderer>();
    SkyObject.material.shader = Shader.Find("GorillaTag/UberShader");
    SkyObject.material.color = Color.red;
}

public static void WhiteSky()//UND
{
    Renderer SkyObject = GameObject.Find("Environment Objects/LocalObjects_Prefab/Standard Sky").GetComponent<Renderer>();
    SkyObject.material.shader = Shader.Find("GorillaTag/UberShader");
    SkyObject.material.color = Color.white;
}

public static void MagentaSky()//UND
{
    Renderer SkyObject = GameObject.Find("Environment Objects/LocalObjects_Prefab/Standard Sky").GetComponent<Renderer>();
    SkyObject.material.shader = Shader.Find("GorillaTag/UberShader");
    SkyObject.material.color = Color.magenta;
}

public static void CyanSky()//UND
{
    Renderer SkyObject = GameObject.Find("Environment Objects/LocalObjects_Prefab/Standard Sky").GetComponent<Renderer>();
    SkyObject.material.shader = Shader.Find("GorillaTag/UberShader");
    SkyObject.material.color = Color.cyan;
}

public static void GreySky()//UND
{
    Renderer SkyObject = GameObject.Find("Environment Objects/LocalObjects_Prefab/Standard Sky").GetComponent<Renderer>();
    SkyObject.material.shader = Shader.Find("GorillaTag/UberShader");
    SkyObject.material.color = Color.gray;
}

public static void BlackSky()//UND
{
    Renderer SkyObject = GameObject.Find("Environment Objects/LocalObjects_Prefab/Standard Sky").GetComponent<Renderer>();
    SkyObject.material.shader = Shader.Find("GorillaTag/UberShader");
    SkyObject.material.color = Color.black;
}

public static void YellowSky()//UND
{
    Renderer SkyObject = GameObject.Find("Environment Objects/LocalObjects_Prefab/Standard Sky").GetComponent<Renderer>();
    SkyObject.material.shader = Shader.Find("GorillaTag/UberShader");
    SkyObject.material.color = Color.yellow;
}

public static void BlueSky()//UND
{
    Renderer SkyObject = GameObject.Find("Environment Objects/LocalObjects_Prefab/Standard Sky").GetComponent<Renderer>();
    SkyObject.material.shader = Shader.Find("GorillaTag/UberShader");
    SkyObject.material.color = Color.blue;
}

public static void GreenSky()//UND
{
    Renderer SkyObject = GameObject.Find("Environment Objects/LocalObjects_Prefab/Standard Sky").GetComponent<Renderer>();
    SkyObject.material.shader = Shader.Find("GorillaTag/UberShader");
    SkyObject.material.color = Color.green;
}
public static void CustomSky()//UND
{
    Renderer SkyObject = GameObject.Find("Environment Objects/LocalObjects_Prefab/Standard Sky").GetComponent<Renderer>();
    SkyObject.material.shader = Shader.Find("GorillaTag/UberShader");
    SkyObject.material = Image.SpiderImage;
}

public static void FixSky()//UND
{
    GameObject.Find("Environment Objects/LocalObjects_Prefab/Standard Sky").GetComponent<Renderer>().material.shader = Shader.Find("Gorilla/DayNightLerpSkyMaterial");
}

private static int Sky = 0;
