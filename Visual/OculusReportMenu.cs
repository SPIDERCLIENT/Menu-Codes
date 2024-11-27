public static void OculusReportMenu()
{
    if (ControllerInputPoller.instance.rightGrab)
    {
        GorillaMetaReport metaReport = GameObject.Find("Miscellaneous Scripts").transform.Find("MetaReporting").GetComponent<GorillaMetaReport>();
        metaReport.gameObject.SetActive(true);
        metaReport.enabled = true;
        MethodInfo inf = typeof(GorillaMetaReport).GetMethod("StartOverlay", BindingFlags.NonPublic | BindingFlags.Instance);
        inf.Invoke(metaReport, null);
    }
}
