public static void Disguise()//UND //WIP
{
    Color color;
    color = UnityEngine.Random.ColorHSV();
    namelist.Add("GAY");
    namelist.Add("SPIDR");
    namelist.Add("ON");
    namelist.Add("CKC");
    namelist.Add("DISGUISEDMAN");
    namelist.Add("SKIPPIY");
    namelist.Add("TOILET");
    namelist.Add("BAGUETTE");
    namelist.Add("WASSSAP");
    namelist.Add("HMMM");
    namelist.Add("ME");
    namelist.Add("GTAG");
    namelist.Add("BOB");
    namelist.Add("MONKE");
    GorillaTagger.Instance.offlineVRRig.enabled = false;
    GorillaTagger.Instance.offlineVRRig.transform.position = new Vector3(-66.7989f, 12.5422f, -82.6815f);
    if (GorillaComputer.instance.friendJoinCollider.playerIDsCurrentlyTouching.Contains(PhotonNetwork.LocalPlayer.UserId))
    {
        string randomname = namelist[UnityEngine.Random.Range(0, 13)];
        PhotonNetwork.NickName = randomname;
        GorillaComputer.instance.savedName = randomname;
        PlayerPrefs.SetString("playerName", randomname);
        PlayerPrefs.Save();
        GorillaTagger.Instance.UpdateColor(color.r, color.g, color.b);
        Debug.Log("local");
        GorillaTagger.Instance.myVRRig.SendRPC("RPC_InitializeNoobMaterial", RpcTarget.All, new object[]
        {
            color.r,
            color.g,
            color.b,
            false
        });
        GorillaTagger.Instance.offlineVRRig.enabled = true;
    }
}

public static List<string> namelist = new List<string>();
