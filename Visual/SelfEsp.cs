public static void SelfEsp()//UND
{
    GorillaTagger.Instance.offlineVRRig.mainSkin.material.shader = Shader.Find("GUI/Text Shader");
    GorillaTagger.Instance.offlineVRRig.mainSkin.material.color = (Codes.Infected(GorillaTagger.Instance.offlineVRRig) ? new Color32(byte.MaxValue, 0, 0, 50) : new Color32(0, byte.MaxValue, 0, 50));
}
