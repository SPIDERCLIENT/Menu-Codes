public static void LaggyRig()//UND
{
    if (Time.time > laggyRigDelay)
    {
        GorillaTagger.Instance.offlineVRRig.enabled = true;
        LagRigStuff = true;
        laggyRigDelay = Time.time + 0.5f;
    }
    else
    {
        if (LagRigStuff)
        {
            LagRigStuff = false;
        }
        else
        {
            GorillaTagger.Instance.offlineVRRig.enabled = false;
        }
    }
}

public static bool LagRigStuff = false;

public static float laggyRigDelay = 0f;
