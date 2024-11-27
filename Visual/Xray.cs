public static void Xray()//UND
{
    try
    {
        foreach (GameObject friedchicken in Resources.FindObjectsOfTypeAll(typeof(GameObject)))
        {
            Renderer renderer = friedchicken.GetComponent<Renderer>();
            if (renderer != null)
            {
                foreach (Material mat in renderer.materials)
                {
                    Color color = mat.color;
                    color.a = 0.5f;
                    mat.color = color;
                    mat.SetFloat("_Mode", 3);
                    mat.SetInt("_SrcBlend", (int)(BlendMode)5);
                    mat.SetInt("_DstBlend", (int)(BlendMode)10);
                    mat.SetInt("_ZWrite", 0);
                    mat.renderQueue = 3000;
                }
            }
        }
    }
    catch
    {
        NotifiLib.SendNotification("Your game is broken, reload the mod/game to fix errors.");
    }
}
