public static void RigLerping()//UND
{
    foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
    {
        if (vrrig != GorillaTagger.Instance.offlineVRRig)
        {
            vrrig.lerpValueBody = 1f;
            vrrig.lerpValueFingers = 1f;
        }
    }
}
