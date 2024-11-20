public static void NukeModCheckers()//UND
{
    foreach (Player player in PhotonNetwork.PlayerList)
    {
        Hashtable hashtable = new Hashtable();
        hashtable.Add("mods", "SPIDER ON TOP SPIDER ON TOP SPIDER ON TOP SPIDER ON TOP SPIDER ON TOP SPIDER ON TOP SPIDER ON TOP SPIDER ON TOP SPIDER ON TOP SPIDER ON TOP SPIDER ON TOP v");
        Hashtable hashtable2 = hashtable;
        player.SetCustomProperties(hashtable2, null, null);
    }
}
