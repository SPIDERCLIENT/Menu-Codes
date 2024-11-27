public static void SizeChanger()//UND
{
    if (ControllerInputPoller.instance.rightControllerPrimaryButton)
    {
        sizeScale = 1f;
    }
    if (ControllerInputPoller.instance.rightGrab)
    {
        sizeScale += 0.05f;
    }
    if (ControllerInputPoller.instance.leftGrab)
    {
        sizeScale -= 0.05f;
    }
    if (sizeScale <= 0)
    {
        sizeScale = 0.05f;
    }
    GorillaLocomotion.Player.Instance.scale = sizeScale;
}

public static float sizeScale = 1f;
