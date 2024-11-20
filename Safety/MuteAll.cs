public static void MuteAll()//UND
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
}
