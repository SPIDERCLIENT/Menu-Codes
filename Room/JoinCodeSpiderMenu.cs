public static void JoinCode(string code)//UND
{
    PhotonNetworkController.Instance.AttemptToJoinSpecificRoom(code, JoinType.Solo);
}

new ButtonInfo { buttonText = "Join Code SPIDERMENU [UND]", method =() => Codes.JoinCode("SPIDERMENU"), isTogglable = false},
