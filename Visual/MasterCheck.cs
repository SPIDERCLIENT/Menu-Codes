public static void MasterCheck()//UND
{
    if (ControllerInputPoller.instance.rightControllerPrimaryButton)
    {
        if (PhotonNetwork.IsMasterClient)
        {
            NotifiLib.SendNotification("<color=grey>[</color><color=green>SUCCESS</color><color=grey>]</color> <color=white>You are master client.</color>");
        }
        else
        {
            NotifiLib.SendNotification("<color=grey>[</color><color=red>ERROR</color><color=grey>]</color> <color=white>You are not master client.</color>");
        }
    }
}
