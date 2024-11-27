public static void GrabHead()//UND
{
    if (ControllerInputPoller.instance.rightGrab)
    {
        if (!IsHeadGrabbed)
        {
            OriginalHeadPosition = GorillaTagger.Instance.offlineVRRig.headMesh.transform.position;
            IsHeadGrabbed = true;
        }
        GorillaTagger.Instance.offlineVRRig.headMesh.transform.position = GorillaLocomotion.Player.Instance.rightControllerTransform.position;
    }
    else if (IsHeadGrabbed)
    {
        GorillaTagger.Instance.offlineVRRig.headMesh.transform.position = OriginalHeadPosition;
        IsHeadGrabbed = false;
    }
}

public static Vector3 OriginalHeadPosition;

public static bool IsHeadGrabbed = false;
