public static void RespawnGliders()//UND
{
    foreach (GliderHoldable glider in UnityEngine.Object.FindObjectsOfType<GliderHoldable>())
    {
        if (glider.GetView.Owner == PhotonNetwork.LocalPlayer)
        {
            glider.Respawn();
        }
        else
        {
            glider.OnHover(null, null);
        }
    }
}
