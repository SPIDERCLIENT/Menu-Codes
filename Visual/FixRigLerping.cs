public static void FixRigLerping()//UND
{
    foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
    {
        if (vrrig != GorillaTagger.Instance.offlineVRRig)
        {
            vrrig.lerpValueBody = GorillaTagger.Instance.offlineVRRig.lerpValueBody;
            vrrig.lerpValueFingers = GorillaTagger.Instance.offlineVRRig.lerpValueFingers;
        }
    }
}
