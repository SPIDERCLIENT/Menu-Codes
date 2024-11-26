public static void CreatePublic()//UND
{
    CreateRoom(RandomRoomName(), true);
}

public static void CreateRoom(string roomName, bool isPublic)
{
    PhotonNetworkController.Instance.currentJoinTrigger = GorillaComputer.instance.GetJoinTriggerForZone("forest");
    RoomConfig roomConfig = new RoomConfig()
    {
        createIfMissing = true,
        isJoinable = true,
        isPublic = isPublic,
        MaxPlayers = PhotonNetworkController.Instance.GetRoomSize(PhotonNetworkController.Instance.currentJoinTrigger.networkZone),
        CustomProps = new ExitGames.Client.Photon.Hashtable()
        {
            { "gameMode", PhotonNetworkController.Instance.currentJoinTrigger.GetFullDesiredGameModeString() },
            { "platform", (string)typeof(PhotonNetworkController).GetField("platformTag", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(PhotonNetworkController.Instance) }
        }
    };
    NetworkSystem.Instance.ConnectToRoom(roomName, roomConfig);
}


public static string RandomRoomName()
{
    string text = "";
    for (int i = 0; i < 4; i++)
    {
        text += NetworkSystem.roomCharacters.Substring(Random.Range(0, NetworkSystem.roomCharacters.Length), 1);
    }
    if (GorillaComputer.instance.CheckAutoBanListForName(text))
    {
        return text;
    }
    return RandomRoomName();
}
