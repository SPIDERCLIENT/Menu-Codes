public static void SpazGliders()//UND
{
    if (ControllerInputPoller.instance.rightGrab)
    {
        foreach (GliderHoldable glider in UnityEngine.Object.FindObjectsOfType<GliderHoldable>())
        {
            if (glider.GetView.Owner == PhotonNetwork.LocalPlayer)
            {
                glider.gameObject.transform.rotation = Quaternion.Euler(new Vector3(UnityEngine.Random.Range(0, 360), UnityEngine.Random.Range(0, 360), UnityEngine.Random.Range(0, 360)));
            }
            else
            {
                glider.OnHover(null, null);
            }
        }
    }
}
