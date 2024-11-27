public static void DisableEsp()//UND
{
    foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
    {
        if (vrrig != GorillaTagger.Instance.offlineVRRig)
        {
            vrrig.mainSkin.material.shader = Shader.Find("GorillaTag/UberShader");
        }
    }
}
