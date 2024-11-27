public static void TapAllCrystals()//UND
{
    if (ControllerInputPoller.instance.rightControllerIndexFloat == 1f)
    {
        if (Time.time > CrystalDelay)
        {
            foreach (GorillaCaveCrystal Tap in UnityEngine.Object.FindObjectsOfType<GorillaCaveCrystal>())
            {
                Tap.OnTap(1f);
                FlushRpcs();
            }
            CrystalDelay = Time.time + 0.1f;
        }
    }
}

private static float CrystalDelay = 0f;

public static void FlushRpcs()
{
    GorillaNot.instance.rpcCallLimit = int.MaxValue;
    PhotonNetwork.RemoveRPCs(PhotonNetwork.LocalPlayer);
    PhotonNetwork.OpCleanActorRpcBuffer(PhotonNetwork.LocalPlayer.ActorNumber);
    PhotonNetwork.OpCleanRpcBuffer(GorillaTagger.Instance.myVRRig.GetView);
    PhotonNetwork.RemoveBufferedRPCs(GorillaTagger.Instance.myVRRig.ViewID, null, null);
}
