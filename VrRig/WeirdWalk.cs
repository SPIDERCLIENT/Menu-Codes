public static void FreezeRigLimbs()//UND
{
    if (ControllerInputPoller.instance.rightGrab)
    {
        GorillaTagger.Instance.offlineVRRig.enabled = false;

        GorillaTagger.Instance.offlineVRRig.transform.position = GorillaTagger.Instance.bodyCollider.transform.position + new Vector3(0f, 0.15f, 0f);
        GorillaTagger.Instance.myVRRig.transform.position = GorillaTagger.Instance.bodyCollider.transform.position + new Vector3(0f, 0.15f, 0f);

        GorillaTagger.Instance.offlineVRRig.transform.rotation = GorillaTagger.Instance.bodyCollider.transform.rotation;
        GorillaTagger.Instance.myVRRig.transform.rotation = GorillaTagger.Instance.bodyCollider.transform.rotation;

        //GorillaTagger.Instance.offlineVRRig.head.rigTarget.transform.rotation = GorillaTagger.Instance.headCollider.transform.rotation;

        GameObject l = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        UnityEngine.Object.Destroy(l.GetComponent<Rigidbody>());
        UnityEngine.Object.Destroy(l.GetComponent<SphereCollider>());

        l.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        l.transform.position = GorillaTagger.Instance.leftHandTransform.position;

        GameObject r = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        UnityEngine.Object.Destroy(r.GetComponent<Rigidbody>());
        UnityEngine.Object.Destroy(r.GetComponent<SphereCollider>());

        r.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        r.transform.position = GorillaTagger.Instance.rightHandTransform.position;

        l.GetComponent<Renderer>().material.color = SettingsforMenu.MenuColor;
        r.GetComponent<Renderer>().material.color = SettingsforMenu.MenuColor;

        UnityEngine.Object.Destroy(l, Time.deltaTime);
        UnityEngine.Object.Destroy(r, Time.deltaTime);
    }
    else
    {
        GorillaTagger.Instance.offlineVRRig.enabled = true;
    }
}
