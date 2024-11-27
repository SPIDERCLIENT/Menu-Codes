public static void NoFingerMovement()//UND
{
    ControllerInputPoller.instance.leftControllerGripFloat = 0f;
    ControllerInputPoller.instance.rightControllerGripFloat = 0f;
    ControllerInputPoller.instance.leftControllerIndexFloat = 0f;
    ControllerInputPoller.instance.rightControllerIndexFloat = 0f;
    ControllerInputPoller.instance.leftControllerPrimaryButton = false;
    ControllerInputPoller.instance.leftControllerSecondaryButton = false;
    ControllerInputPoller.instance.rightControllerPrimaryButton = false;
    ControllerInputPoller.instance.rightControllerSecondaryButton = false;
}
