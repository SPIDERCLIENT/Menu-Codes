public static void SplachSelf()//UND
{
    if (ControllerInputPoller.instance.rightControllerIndexFloat == 1f && WaterAndSoundStuff < Time.time)
    {
        WaterAndSoundStuff = Time.time + 0.5f;
        GorillaTagger.Instance.myVRRig.GetView.RPC("RPC_PlaySplashEffect", 0, new object[]
        {
                    RigManager.GetOwnVRRig().transform.position,
                    UnityEngine.Random.rotation,
                    4f,
                    100f,
                    true,
                    false
        });
    }
}

public static float WaterAndSoundStuff = 0f;
