public static void SlingshotSelf()
{
    GorillaTagger.Instance.offlineVRRig.reliableState.activeTransferrableObjectIndex[0] = 212;
    if (GorillaTagger.Instance.offlineVRRig.slingshot == null)
    {
        GameObject.Find("Player Objects/Local VRRig/Local Gorilla Player/rig/body/Slingshot Chest Snap/DropZoneAnchor/Slingshot").SetActive(true);
    }
    else
    {
        GorillaTagger.Instance.offlineVRRig.slingshot.gameObject.SetActive(true);
    }
}
