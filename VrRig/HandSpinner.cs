public static void HandSpinner()//UND
{
    VRMap rightHand = GorillaTagger.Instance.offlineVRRig.rightHand;
    VRMap leftHand = GorillaTagger.Instance.offlineVRRig.leftHand;
    rightHand.trackingRotationOffset.y = rightHand.trackingRotationOffset.y + 10f;
    leftHand.trackingRotationOffset.y = leftHand.trackingRotationOffset.y + 10f;
}
