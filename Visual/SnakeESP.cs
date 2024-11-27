public static void SnakeESP()//UND
{
    if (PhotonNetwork.InLobby || PhotonNetwork.InRoom)
    {
        foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
        {
            if (vrrig != GorillaTagger.Instance.offlineVRRig)
            {
                Vector3 position = vrrig.transform.position;
                GameObject gameObject = new GameObject("Line");
                LineRenderer lineRenderer = gameObject.AddComponent<LineRenderer>();
                Color startColor = Color.Lerp(new Color(0f, 1f, 0f, 0.5f), new Color(0f, 1f, 1f, 0.5f), Mathf.PingPong(Time.time, 1f));
                Color endColor = new Color32(0, 0, 0, 125);
                lineRenderer.startColor = startColor;
                lineRenderer.endColor = endColor;
                OVRExtensions.ToColorf(lineRenderer.endColor);
                lineRenderer.startWidth = 0.070f;
                lineRenderer.endWidth = 0.070f;
                lineRenderer.transform.LookAt(GorillaTagger.Instance.headCollider.transform.position);
                lineRenderer.useWorldSpace = true;
                lineRenderer.positionCount = 2;
                lineRenderer.SetPosition(0, position);
                lineRenderer.SetPosition(1, position + new Vector3(0f, 0f, 0.1f));
                lineRenderer.material.shader = Shader.Find("GUI/Text Shader");
                UnityEngine.Object.Destroy(gameObject, 4f);
            }
        }
    }
}
