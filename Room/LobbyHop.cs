public static void LobbyHop()//UND
{
    if (!PhotonNetwork.InRoom && IsON)
    {
        JoinRandomRoom();
    }

    if (ControllerInputPoller.instance.rightControllerSecondaryButton)
    {
        if (PhotonNetwork.InRoom)
        {
            PhotonNetwork.Disconnect();
        }
        IsON = !IsON;
    }
}

private static bool IsON = false;
