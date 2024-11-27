public static void Beacons()//UND
{
    foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
    {
        if (vrrig != GorillaTagger.Instance.offlineVRRig)
        {
            GameObject gameObject = new GameObject("Line");
            LineRenderer lineRenderer = gameObject.AddComponent<LineRenderer>();
            Color playerColor = vrrig.playerColor;
            lineRenderer.startColor = playerColor;
            lineRenderer.endColor = playerColor;
            lineRenderer.startWidth = 0.025f;
            lineRenderer.endWidth = 0.025f;
            lineRenderer.positionCount = 2;
            lineRenderer.useWorldSpace = true;
            lineRenderer.SetPosition(0, vrrig.transform.position + new Vector3(0f, 9999f, 0f));
            lineRenderer.SetPosition(1, vrrig.transform.position - new Vector3(0f, 9999f, 0f));
            lineRenderer.material.shader = Shader.Find("GUI/Text Shader");
            UnityEngine.Object.Destroy(gameObject, Time.deltaTime);
        }
    }
}
