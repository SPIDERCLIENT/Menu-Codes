public static void CaseohMonke()//UND
{
    VRRig vrrig = GorillaTagger.Instance.offlineVRRig;
    UnityEngine.Color vrrigcolor = vrrig.playerColor;
    GameObject belly = GameObject.CreatePrimitive(UnityEngine.PrimitiveType.Sphere);
    belly.transform.position = vrrig.transform.position + vrrig.transform.forward * 0.2f + Vector3.down * 0.3f;
    belly.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
    belly.transform.LookAt(vrrig.transform.transform);
    belly.GetComponent<Renderer>().material = GorillaTagger.Instance.offlineVRRig.mainSkin.material;
    belly.GetComponent<Renderer>().material.color = GorillaTagger.Instance.offlineVRRig.mainSkin.material.color;
    UnityEngine.Object.Destroy(belly, Time.deltaTime);
    UnityEngine.Object.Destroy(belly.GetComponent<Collider>());
}
