public static void Tracers()//UND
{
    if (PhotonNetwork.CurrentRoom != null)
    {
        foreach (VRRig rig in GorillaParent.instance.vrrigs)
        {
            if (!rig.isOfflineVRRig && !rig.isMyPlayer)
            {
                GameObject lines = new GameObject("Line");
                LineRenderer lr = lines.AddComponent<LineRenderer>();
                var color = Color.Lerp(new Color(0f, 1f, 0f, 0.5f), new Color(0f, 1f, 1f, 0.5f), Mathf.PingPong(Time.time, 1f));
                lr.startColor = color;
                lr.endColor = color;
                lr.startWidth = 0.03f;
                lr.endWidth = 0.03f;
                lr.positionCount = 2;
                lr.useWorldSpace = true;
                lr.SetPosition(0, GorillaLocomotion.Player.Instance.rightControllerTransform.position);
                lr.SetPosition(1, rig.transform.position);
                lr.material.shader = Shader.Find("GUI/Text Shader");
                UnityEngine.Object.Destroy(lr, Time.deltaTime);
                UnityEngine.Object.Destroy(lines, Time.deltaTime);
            }
        }
    }
}
