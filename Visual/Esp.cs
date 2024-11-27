public static void Esp()//UND
{
    foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
    {
        if (!vrrig.isOfflineVRRig && !vrrig.isMyPlayer && vrrig.mainSkin.material.name.Contains("fected"))
        {
            vrrig.mainSkin.material.shader = Shader.Find("GUI/Text Shader");
            if (Codes.ESPColor == 0)
            {
                vrrig.mainSkin.material.color = new Color(9f, 0f, 0f, 0.5f);
            }
            else
            {
                vrrig.playerColor.a = 0.5f;
                vrrig.mainSkin.material.color = vrrig.playerColor;
                vrrig.playerColor.a = 1f;
            }
        }
        else if (!vrrig.isOfflineVRRig && !vrrig.isMyPlayer)
        {
            vrrig.mainSkin.material.shader = Shader.Find("GUI/Text Shader");
            vrrig.mainSkin.material.shader = Shader.Find("GUI/Text Shader");
            if (Codes.ESPColor == 0)
            {
                vrrig.mainSkin.material.color = new Color(0f, 9f, 0f, 0.5f);
            }
            else
            {
                vrrig.playerColor.a = 0.5f;
                vrrig.mainSkin.material.color = vrrig.playerColor;
                vrrig.playerColor.a = 1f;
            }
        }
    }
    Codes.ESPStuff = true;
}

private static int ESPColor;

private static bool ESPStuff = false;
