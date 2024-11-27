public static void GrabRocket()//UND
{
    if (ControllerInputPoller.instance.rightGrab)
    {
        GameObject.Find("RocketShip_Prefab").transform.localScale = new Vector3(0.05f, 0.05f, 0.05f);
        GameObject.Find("RocketShip_Prefab").transform.position = new Vector3(0f, -0.0075f, 0f);
        GameObject.Find("RocketShip_Prefab").transform.position = GorillaLocomotion.Player.Instance.rightControllerTransform.position;
    }
}
