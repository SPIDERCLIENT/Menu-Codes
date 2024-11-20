public static void MuteAllAndReportAll()//UND
{
    foreach (GorillaPlayerScoreboardLine MuteLine in UnityEngine.Object.FindObjectsOfType<GorillaPlayerScoreboardLine>())
    {
        if (MuteLine.linePlayer != null)
        {
            MuteLine.PressButton(true, GorillaPlayerLineButton.ButtonType.Mute);
            MuteLine.muteButton.isOn = true;
            MuteLine.muteButton.UpdateColor();
        }
    }

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
