public static void ChangeTirgerSkinColor()//UND
{
    if (PhotonNetwork.InRoom)
    {
        foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
        {
            if (vrrig.mainSkin.sharedMaterials[0].name.Contains("TigerSkinBody"))
            {
                vrrig.mainSkin.sharedMaterials[0].color = vrrig.playerColor;
            }
        }
    }
    else
    {
        VRRig offlineVRRig = GorillaTagger.Instance.offlineVRRig;
        if (offlineVRRig.mainSkin.sharedMaterials[0].name.Contains("TigerSkinBody"))
        {
            offlineVRRig.mainSkin.sharedMaterials[0].color = offlineVRRig.playerColor;
        }
    }
}
