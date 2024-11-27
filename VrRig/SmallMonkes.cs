public static void SmallMonkes()//UND
{
    foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
    {
        if (!vrrig.isOfflineVRRig)
        {
            vrrig.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        }
    }
}
