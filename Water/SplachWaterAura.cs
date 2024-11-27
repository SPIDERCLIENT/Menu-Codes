public static void SplachWaterAura()//UND
{
    if (ControllerInputPoller.instance.rightControllerIndexFloat == 1f)
    {
        foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
        {
            if (Vector3.Distance(vrrig.transform.position, RigManager.GetOwnVRRig().transform.position) <= 9 && vrrig.playerText1.text != PhotonNetwork.LocalPlayer.NickName && vrrig.playerText2.text != PhotonNetwork.LocalPlayer.NickName)
            {
                GorillaTagger.Instance.myVRRig.GetView.RPC("RPC_PlaySplashEffect", 0, new object[]
                {
                    vrrig.transform.position,
                    UnityEngine.Random.rotation,
                    4f,
                    100f,
                    true,
                    false
                });
            }
        }
    }
}
