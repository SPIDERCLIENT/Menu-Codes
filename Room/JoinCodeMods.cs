public static void JoinCode(string code)//UND
{
    PhotonNetworkController.Instance.AttemptToJoinSpecificRoom(code, JoinType.Solo);
}

new ButtonInfo { buttonText = "Join Code MODS [UND]", method =() => Codes.JoinCode("MODS"), isTogglable = false},
