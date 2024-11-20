public static void LeftTriggerDisconnect()//UND
{
    if (ControllerInputPoller.instance.leftControllerIndexFloat == 1f)
    {
        PhotonNetwork.Disconnect();
    }
}
