public static void HideSkeletons()//UND
{
    foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
    {
        GorillaBodyRenderer.SetAllSkeletons(allSkeletons: false);
    }
}
