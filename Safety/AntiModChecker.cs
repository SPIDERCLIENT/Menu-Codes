public static void AntiModChecker()//UND
{
    Hashtable hashtable = new Hashtable();
    hashtable.Add("mods", null);
    Hashtable hashtable2 = hashtable;
    PhotonNetwork.LocalPlayer.SetCustomProperties(hashtable2, null, null);
}
