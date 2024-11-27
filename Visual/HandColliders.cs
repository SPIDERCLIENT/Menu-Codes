public static void ShowHandHitboxes()//UND
{
    if (Codes.RightCircle == null)
    {
        Codes.RightCircle = GameObject.CreatePrimitive(0);
        Object.Destroy(Codes.RightCircle.GetComponent<Rigidbody>());
        Object.Destroy(Codes.RightCircle.GetComponent<Collider>());
        Object.Destroy(Codes.RightCircle.GetComponent<SphereCollider>());
        Codes.RightCircle.transform.localScale = GorillaLocomotion.Player.Instance.rightControllerTransform.localScale - new Vector3(0.72f, 0.72f, 0.72f);
        Codes.RightCircle.GetComponent<Renderer>().material.shader = Shader.Find("GUI/Text Shader");
        Codes.RightCircle.GetComponent<Renderer>().material.color = SettingsforMenu.MenuColor;
    }
    if (Codes.LeftCircle == null)
    {
        Codes.LeftCircle = GameObject.CreatePrimitive(0);
        Object.Destroy(Codes.LeftCircle.GetComponent<Rigidbody>());
        Object.Destroy(Codes.LeftCircle.GetComponent<Collider>());
        Object.Destroy(Codes.LeftCircle.GetComponent<SphereCollider>());
        Codes.LeftCircle.transform.localScale = GorillaLocomotion.Player.Instance.rightControllerTransform.localScale - new Vector3(0.72f, 0.72f, 0.72f);
        Codes.LeftCircle.GetComponent<Renderer>().material.shader = Shader.Find("GUI/Text Shader");
        Codes.LeftCircle.GetComponent<Renderer>().material.color = SettingsforMenu.MenuColor;
    }
    Codes.RightCircle.transform.position = GorillaLocomotion.Player.Instance.rightControllerTransform.position;
    Codes.LeftCircle.transform.position = GorillaLocomotion.Player.Instance.leftControllerTransform.position;
}

public static GameObject RightCircle;

public static GameObject LeftCircle;
