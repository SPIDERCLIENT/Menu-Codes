public static void TracerOrbit()//UND
{
    l += 5f * Time.deltaTime;
    GameObject o = GameObject.CreatePrimitive(PrimitiveType.Sphere);
    o.gameObject.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
    UnityEngine.GameObject.Destroy(o.gameObject.GetComponent<SphereCollider>());
    o.gameObject.GetComponent<Renderer>().material.color = Color.Lerp(new Color(0f, 1f, 0f, 0.5f), new Color(0f, 1f, 1f, 0.5f), Mathf.PingPong(Time.time, 1f));
    float x = GorillaTagger.Instance.offlineVRRig.headConstraint.transform.position.x + 0.6f * Mathf.Cos(l);
    float y = GorillaTagger.Instance.offlineVRRig.headConstraint.transform.position.y + -1f;
    float z = GorillaTagger.Instance.offlineVRRig.headConstraint.transform.position.z + 0.6f * Mathf.Sin(l);
    o.gameObject.transform.position = new Vector3(x, y, z);
    GameObject gameObject = new GameObject("Line");
    LineRenderer lineRenderer = gameObject.AddComponent<LineRenderer>();
    UnityEngine.Color M = Color.Lerp(new Color(0f, 1f, 0f, 0.5f), new Color(0f, 1f, 1f, 0.5f), Mathf.PingPong(Time.time, 1f));
    UnityEngine.Color B = Color.Lerp(new Color(0f, 1f, 0f, 0.5f), new Color(0f, 1f, 1f, 0.5f), Mathf.PingPong(Time.time, 1f));
    lineRenderer.startColor = B;
    lineRenderer.endColor = M;
    lineRenderer.startWidth = 0.02f;
    lineRenderer.endWidth = 0.02f;
    lineRenderer.positionCount = 2;
    lineRenderer.useWorldSpace = true;
    lineRenderer.SetPosition(0, o.gameObject.transform.position);
    lineRenderer.SetPosition(1, GorillaTagger.Instance.headCollider.gameObject.transform.position);
    lineRenderer.material.shader = Shader.Find("GUI/Text Shader");
    UnityEngine.Object.Destroy(lineRenderer, Time.deltaTime);
    UnityEngine.Object.Destroy(gameObject, Time.deltaTime);
    UnityEngine.GameObject.Destroy(o.gameObject, 0.2f);
}
