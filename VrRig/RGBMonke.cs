public static void RGBMonke()//UND
{
    if (SelectedRGBColor == 0)
    {
        colorr = Color.red;
    }
    if (SelectedRGBColor == 1)
    {
        colorr = Color.green;
    }
    if (SelectedRGBColor == 2)
    {
        colorr = Color.blue;
    }
    if (SelectedRGBColor == 3)
    {
        colorr = Color.cyan;
    }
    if (SelectedRGBColor == 4)
    {
        colorr = Color.white;
    }
    Codes.StartDelay(delegate
    {
        SelectedRGBColor++;
        SetPlayerColor(colorr);
        if (SelectedRGBColor > 4)
        {
            SelectedRGBColor = 0;
        }
    }, .19f);
    FlushRpcs();
}

public static Color colorr;

public static int SelectedRGBColor;

public static float Delay;

public static void StartDelay(Action action, float time)
{
    if (Time.time >= Delay + time)
    {
        Delay = Time.time;
        action();
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

public static void SetPlayerColor(Color color) // Working
{
    PlayerPrefs.SetFloat("redValue", color.r);
    PlayerPrefs.SetFloat("greenValue", color.g);
    PlayerPrefs.SetFloat("blueValue", color.b);
    GorillaTagger.Instance.UpdateColor(color.r, color.g, color.b);
    GorillaTagger.Instance.myVRRig.SendRPC("RPC_InitializeNoobMaterial", RpcTarget.All, new object[]
    {
        color.r,
        color.g,
        color.b
    });
}
