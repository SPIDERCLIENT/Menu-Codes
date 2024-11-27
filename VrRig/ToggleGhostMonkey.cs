public static void ToggleGhostMonkey()//UND
{
    if (ControllerInputPoller.instance.rightControllerPrimaryButton && Time.time > Codes.GhostCooldown + 1f)
    {
        Codes.GhostCooldown = Time.time;
        Codes.InGhostState = !Codes.InGhostState;
    }
    if (Codes.InGhostState)
    {
        GorillaTagger.Instance.offlineVRRig.enabled = false;
        GameObject gameObject = GameObject.CreatePrimitive(0);
        Object.Destroy(gameObject.GetComponent<Rigidbody>());
        Object.Destroy(gameObject.GetComponent<SphereCollider>());
        gameObject.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        gameObject.transform.position = GorillaTagger.Instance.rightHandTransform.position;
        gameObject.GetComponent<Renderer>().material.color = SettingsforMenu.MenuColor;
        GameObject gameObject2 = GameObject.CreatePrimitive(0);
        Object.Destroy(gameObject2.GetComponent<Rigidbody>());
        Object.Destroy(gameObject2.GetComponent<SphereCollider>());
        gameObject2.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        gameObject2.transform.position = GorillaTagger.Instance.leftHandTransform.position;
        gameObject2.GetComponent<Renderer>().material.color = SettingsforMenu.MenuColor;
        Object.Destroy(gameObject, Time.deltaTime);
        Object.Destroy(gameObject2, Time.deltaTime);
    }
    else
    {
        GorillaTagger.Instance.offlineVRRig.enabled = true;
    }
}

public static bool InGhostState = false;

public static float GhostCooldown;
