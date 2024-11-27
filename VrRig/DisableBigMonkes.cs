public static void DisableBigMonkes()//UND
{
    foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
    {
        if (!vrrig.isOfflineVRRig)
        {
            vrrig.transform.localScale = new Vector3(1, 1, 1);
        }
    }
}
