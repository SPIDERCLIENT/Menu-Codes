public static void BecomeDAISY09()//UND
{
    ChangeName("DAISY09");
    SetPlayerColor(new Color32(255, 81, 231, 255));
}

public static void SetPlayerColor(Color color) // Working
{
    PlayerPrefs.SetFloat("redValue", color.r);
    PlayerPrefs.SetFloat("greenValue", color.g);
    PlayerPrefs.SetFloat("blueValue", color.b);
    GorillaTagger.Instance.UpdateColor(color.r, color.g, color.b);
    GorillaTagger.Instance.myVRRig.SendRPC("RPC_InitializeNoobMaterial", RpcTarget.All, new object[]
    {
        color.r,
        color.g,
        color.b
    });
}

public static void ChangeName(string newName)
{
    PhotonNetwork.LocalPlayer.NickName = newName;
    GorillaTagger.Instance.offlineVRRig.playerName = newName;
    GorillaComputer.instance.currentName = newName;
    GorillaComputer.instance.savedName = newName;
    GorillaComputer.instance.offlineVRRigNametagText.text = newName;
    PlayerPrefs.SetString("playerName", newName);
    PlayerPrefs.Save();
}