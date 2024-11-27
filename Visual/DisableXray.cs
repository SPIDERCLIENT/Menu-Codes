public static void DisableXray()//UND
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
                    color.a = 1.0f;
                    mat.color = color;
                    mat.SetFloat("_Mode", 0);
                    mat.SetInt("_SrcBlend", (int)(BlendMode)1);
                    mat.SetInt("_DstBlend", (int)(BlendMode)0);
                    mat.SetInt("_ZWrite", 1);
                    mat.renderQueue = -1;
                }
            }
        }
    }
    catch
    {
        NotifiLib.SendNotification("Your game is broken, reload the mod/game to fix errors.");
    }
}
