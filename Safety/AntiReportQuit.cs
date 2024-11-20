public static void AntiReportQuit()//UND
{
    foreach (GorillaPlayerScoreboardLine line in GorillaScoreboardTotalUpdater.allScoreboardLines)
    {
        if (line.linePlayer == NetworkSystem.Instance.LocalPlayer)
        {
            foreach (VRRig rig in GorillaParent.instance.vrrigs)
            {
                if (rig != GorillaTagger.Instance.offlineVRRig)
                {
                    float rightDistance = Vector3.Distance(rig.rightHandTransform.position, line.reportButton.transform.position);
                    float leftDistance = Vector3.Distance(rig.leftHandTransform.position, line.reportButton.transform.position);
                    if (rightDistance < 0.38f || leftDistance < 0.38f)
                    {
                        UnityEngine.Application.Quit();
                        NotifiLib.SendNotification("<color=black>[!]</color> A Fattie " + RigManager.GetPlayerFromVRRig(rig).NickName + " (" + RigManager.GetPlayerFromVRRig(rig).UserId + ") tried to report you!");
                    }
                }
            }
        }
    }
}
