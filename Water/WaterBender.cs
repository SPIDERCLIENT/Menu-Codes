public static void WaterBender()//UND
{
    if (ControllerInputPoller.instance.rightGrab && Time.time > Codes.WaterBendCooldown + 0.4f)
    {
        Codes.WaterBendCooldown = Time.time;
        GorillaTagger.Instance.myVRRig.GetView.RPC("RPC_PlaySplashEffect", 0, new object[]
        {
            GorillaLocomotion.Player.Instance.rightControllerTransform.position,
            GorillaLocomotion.Player.Instance.rightControllerTransform.rotation,
            1f,
            250f,
            true,
            false
        });
    }
    if (ControllerInputPoller.instance.leftGrab && Time.time > Codes.WaterBendCooldown + 0.4f)
    {
        Codes.WaterBendCooldown = Time.time;
        GorillaTagger.Instance.myVRRig.GetView.RPC("RPC_PlaySplashEffect", 0, new object[]
        {
            GorillaLocomotion.Player.Instance.leftControllerTransform.position,
            GorillaLocomotion.Player.Instance.leftControllerTransform.rotation,
            1f,
            250f,
            true,
            false
        });
    }
}

public static float WaterBendCooldown;
