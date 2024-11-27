public static void GrabBraclets()//UND
{
    if (ControllerInputPoller.instance.leftGrab)
    {
        GorillaTagger.Instance.myVRRig.SendRPC("EnableNonCosmeticHandItemRPC", RpcTarget.All, new object[]
        {
            false,
            false
        });
        GorillaTagger.Instance.myVRRig.SendRPC("EnableNonCosmeticHandItemRPC", RpcTarget.All, new object[]
        {
            true,
            true
        });
        FlushRpcs();
    }
    if (ControllerInputPoller.instance.rightGrab)
    {
        GorillaTagger.Instance.myVRRig.SendRPC("EnableNonCosmeticHandItemRPC", RpcTarget.All, new object[]
        {
            false,
            true
        });
        GorillaTagger.Instance.myVRRig.SendRPC("EnableNonCosmeticHandItemRPC", RpcTarget.All, new object[]
        {
            true,
            false
        });
        FlushRpcs();
    }
}

public static void FlushRpcs()
{
    GorillaNot.instance.rpcCallLimit = int.MaxValue;
    PhotonNetwork.RemoveRPCs(PhotonNetwork.LocalPlayer);
    PhotonNetwork.OpCleanActorRpcBuffer(PhotonNetwork.LocalPlayer.ActorNumber);
    PhotonNetwork.OpCleanRpcBuffer(GorillaTagger.Instance.myVRRig.GetView);
    PhotonNetwork.RemoveBufferedRPCs(GorillaTagger.Instance.myVRRig.ViewID, null, null);
}
