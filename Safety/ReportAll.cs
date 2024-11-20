public static void ReportAll()//UND
{
    foreach (GorillaPlayerScoreboardLine ReportLine in UnityEngine.Object.FindObjectsOfType<GorillaPlayerScoreboardLine>())
    {
        if (ReportLine.linePlayer != null)
        {
            ReportLine.PressButton(true, GorillaPlayerLineButton.ButtonType.Report);
            ReportLine.reportButton.isOn = true;
            ReportLine.reportButton.UpdateColor();
        }
    }
}
