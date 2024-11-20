public static void RandomGhostCode()//UND
{
    string[] roomNames =
    {
        "666",
        "DAISY09",
        "PBBV",
        "SREN17",
        "SREN18",
        "AI",
        "GHOST",
        "J3VU",
        "RUN",
        "BOT",
        "TIPTOE",
        "SPIDER",
        "STATUE",
        "BANSHEE",
        "RABBIT",
        "ERROR",
        "ISEEYOUBAN"
    };
    int num = new System.Random().Next(roomNames.Length);
    PhotonNetworkController.Instance.AttemptToJoinSpecificRoom(roomNames[num], JoinType.Solo);
}
