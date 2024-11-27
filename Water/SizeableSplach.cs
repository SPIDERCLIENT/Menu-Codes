public static void ChangeSizeOfWater()//UND
{
    if (ControllerInputPoller.instance.rightGrab && ControllerInputPoller.instance.leftGrab)
    {
        FlushRpcs();
        Vector3 position = GorillaLocomotion.Player.Instance.rightControllerTransform.transform.position;
        Vector3 position2 = GorillaLocomotion.Player.Instance.leftControllerTransform.transform.position;
        Quaternion rotation = GorillaLocomotion.Player.Instance.rightControllerTransform.transform.rotation;
        Quaternion rotation2 = GorillaLocomotion.Player.Instance.leftControllerTransform.transform.rotation;
        Vector3 vector = (position + position2) / 2f;
        Quaternion quaternion = Quaternion.Lerp(rotation, rotation2, 0.5f);
        float num = Vector3.Distance(position, position2);
        GorillaTagger.Instance.myVRRig.GetView.RPC("RPC_PlaySplashEffect", 0, new object[]
        {
             vector,
             quaternion,
             num,
             num,
             false,
             true
        });
    }
    else
    {
        if (ControllerInputPoller.instance.rightGrab)
        {
            FlushRpcs();
            GorillaTagger.Instance.myVRRig.GetView.RPC("RPC_PlaySplashEffect", 0, new object[]
            {
                 GorillaLocomotion.Player.Instance.rightControllerTransform.transform.position,
                 GorillaTagger.Instance.offlineVRRig.transform.rotation,
                 0.3f,
                 0.3f,
                 false,
                 true
            });
        }
        if (ControllerInputPoller.instance.leftGrab)
        {
            FlushRpcs();
            GorillaTagger.Instance.myVRRig.GetView.RPC("RPC_PlaySplashEffect", 0, new object[]
            {
                 GorillaLocomotion.Player.Instance.leftControllerTransform.transform.position,
                 GorillaTagger.Instance.offlineVRRig.transform.rotation,
                 0.3f,
                 0.3f,
                 false,
                 true
            });
        }
    }
    if (ControllerInputPoller.instance.rightControllerSecondaryButton)
    {
        Vector3 position3 = GorillaTagger.Instance.offlineVRRig.headMesh.transform.position;
        Quaternion quaternion2 = Quaternion.Euler(90f, 0f, 0f);
        GorillaTagger.Instance.myVRRig.GetView.RPC("RPC_PlaySplashEffect", 0, new object[]
        {
             position3 + new Vector3(0f, 0.5f, 0f),
             quaternion2,
             0.3f,
             0.3f,
             false,
             false
        });
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
