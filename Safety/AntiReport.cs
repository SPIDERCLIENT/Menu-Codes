public static void AntiReport()//UND
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
                    if (rightDistance < 0.45f || leftDistance < 0.45f)
                    {
                        PhotonNetwork.Disconnect();
                        NotifiLib.SendNotification("<color=red>[!]</color> A Bitch " + RigManager.GetPlayerFromVRRig(rig).NickName + " (" + RigManager.GetPlayerFromVRRig(rig).UserId + ") tried to report you!");
                    }
                }
            }
        }
    }
}
