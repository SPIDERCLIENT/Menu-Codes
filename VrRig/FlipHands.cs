public static void FlipHands()//UND
{
    Vector3 lh = GorillaTagger.Instance.leftHandTransform.position;
    Vector3 rh = GorillaTagger.Instance.rightHandTransform.position;
    Quaternion lhr = GorillaTagger.Instance.leftHandTransform.rotation;
    Quaternion rhr = GorillaTagger.Instance.rightHandTransform.rotation;

    GorillaLocomotion.Player.Instance.rightControllerTransform.transform.position = lh;
    GorillaLocomotion.Player.Instance.leftControllerTransform.transform.position = rh;

    GorillaLocomotion.Player.Instance.rightControllerTransform.transform.rotation = lhr;
    GorillaLocomotion.Player.Instance.leftControllerTransform.transform.rotation = rhr;
}
