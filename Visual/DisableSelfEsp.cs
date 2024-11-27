public static void DisableSelfEsp()//UND
{
    GorillaTagger.Instance.offlineVRRig.mainSkin.material.shader = Shader.Find("GorillaTag/UberShader");
}
