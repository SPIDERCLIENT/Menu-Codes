public static void BoxESP()//UND
{
    foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
    {
        if (vrrig != GorillaTagger.Instance.offlineVRRig)
        {
            UnityEngine.Color thecolor = vrrig.playerColor;
            GameObject box = GameObject.CreatePrimitive(PrimitiveType.Cube);
            box.transform.position = vrrig.transform.position;
            box.transform.LookAt(GorillaTagger.Instance.headCollider.transform.position);
            box.GetComponent<Renderer>().material.color = Color.Lerp(new Color(0f, 1f, 0f, 0.5f), new Color(0f, 1f, 1f, 0.5f), Mathf.PingPong(Time.time, 1f));
            UnityEngine.Object.Destroy(box, Time.deltaTime);
        }
    }
}
