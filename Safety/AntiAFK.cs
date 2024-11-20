public static void AntiAFK()//UND
{
    PhotonNetworkController.Instance.disableAFKKick = false;
}

public static void DisableAntiAFK()//UND
{
    PhotonNetworkController.Instance.disableAFKKick = true;
}
