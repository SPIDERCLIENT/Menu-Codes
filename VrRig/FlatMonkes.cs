public static void FlatMonkes()//UND
{
    foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
    {
        if (!vrrig.isOfflineVRRig)
        {
            vrrig.transform.localScale = new Vector3(0.01f, 1f, 1f);
        }
    }
}
