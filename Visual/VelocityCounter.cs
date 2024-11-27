public static void VelocityCounter()//UND
{
    if (ControllerInputPoller.instance.rightControllerPrimaryButton)
    {
        NotifiLib.SendNotification("<color=yellow> INFO </color> <color=cyan>Current Velocity [ </color>" + GorillaLocomotion.Player.Instance.InstantaneousVelocity + "<color=cyan> ] </color>");
    }
}
