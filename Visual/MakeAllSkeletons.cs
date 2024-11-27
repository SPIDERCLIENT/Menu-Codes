public static void MakeAllSkeletons()//UND
{
    foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
    {
        //if (!FirstPersonXRaySpecs.IsWearing)
        {
            GorillaBodyRenderer.SetAllSkeletons(allSkeletons: true);
        }
    }
}
