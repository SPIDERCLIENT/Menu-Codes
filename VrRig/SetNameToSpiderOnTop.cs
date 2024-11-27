public static void SetNameToSpiderOnTop()//UND
{
    ChangeName("SpiderOnTop");
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