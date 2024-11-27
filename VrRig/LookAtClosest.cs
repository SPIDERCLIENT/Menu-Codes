public static void LookAtClosest()//UND
{
    if (ControllerInputPoller.instance.rightControllerIndexFloat > 0f)
    {
        GorillaTagger.Instance.offlineVRRig.enabled = false;
        GameObject gameObject = GameObject.CreatePrimitive(0);
        Object.Destroy(gameObject.GetComponent<Rigidbody>());
        Object.Destroy(gameObject.GetComponent<SphereCollider>());
        gameObject.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        gameObject.transform.position = GorillaTagger.Instance.rightHandTransform.position;
        gameObject.GetComponent<Renderer>().material.color = SettingsforMenu.MenuColor;
        GameObject gameObject2 = GameObject.CreatePrimitive(0);
        Object.Destroy(gameObject2.GetComponent<Rigidbody>());
        Object.Destroy(gameObject2.GetComponent<SphereCollider>());
        gameObject2.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        gameObject2.transform.position = GorillaTagger.Instance.leftHandTransform.position;
        gameObject2.GetComponent<Renderer>().material.color = SettingsforMenu.MenuColor;
        Object.Destroy(gameObject, Time.deltaTime);
        Object.Destroy(gameObject2, Time.deltaTime);
        VRRig vrrig = GorillaGameManager.instance.FindPlayerVRRig(Codes.GetClosestPlayer());//
        GorillaTagger.Instance.offlineVRRig.headConstraint.LookAt(vrrig.transform.position);//
    }
    else
    {
        GorillaTagger.Instance.offlineVRRig.enabled = true;
    }
}

public static Player GetClosestPlayer()
{
    Player result = null;
    float num = float.MaxValue;
    foreach (Player player in PhotonNetwork.PlayerListOthers)
    {
        float num2 = Vector3.Distance(GorillaTagger.Instance.offlineVRRig.transform.position, GorillaGameManager.instance.FindPlayerVRRig(player).transform.position);
        if (num2 <= num)
        {
            num = num2;
            result = player;
        }
    }
    return result;
}
