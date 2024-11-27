public static void RemoveBracelet()//UND
{
    GorillaTagger.Instance.myVRRig.SendRPC("EnableNonCosmeticHandItemRPC", RpcTarget.All, new object[]
    {
        false,
        true
    });
    GorillaTagger.Instance.myVRRig.SendRPC("EnableNonCosmeticHandItemRPC", RpcTarget.All, new object[]
    {
        false,
        false
    });
    FlushRpcs();
}

public static void FlushRpcs()
{
    GorillaNot.instance.rpcCallLimit = int.MaxValue;
    PhotonNetwork.RemoveRPCs(PhotonNetwork.LocalPlayer);
    PhotonNetwork.OpCleanActorRpcBuffer(PhotonNetwork.LocalPlayer.ActorNumber);
    PhotonNetwork.OpCleanRpcBuffer(GorillaTagger.Instance.myVRRig.GetView);
    PhotonNetwork.RemoveBufferedRPCs(GorillaTagger.Instance.myVRRig.ViewID, null, null);
}
