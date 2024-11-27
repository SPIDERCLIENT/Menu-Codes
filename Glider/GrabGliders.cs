public static void GrabGliders()//UND
{
    if (ControllerInputPoller.instance.rightGrab)
    {
        foreach (GliderHoldable glider in UnityEngine.Object.FindObjectsOfType<GliderHoldable>())
        {
            glider.gameObject.transform.position = GorillaTagger.Instance.rightHandTransform.position;
        }
    }
}
