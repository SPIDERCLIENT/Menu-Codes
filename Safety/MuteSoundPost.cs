public static void MuteSoundPost()
{
    foreach (SoundPostMuteButton muteButton in UnityEngine.Object.FindObjectsOfType<SoundPostMuteButton>())
    {
        muteButton.ButtonActivation();
    }
}
