public static void Draw()//UND
{
    if (ControllerInputPoller.instance.rightGrab)
    {
        DrawCube = GameObject.CreatePrimitive(0);
        UnityEngine.Object.Destroy(DrawCube.GetComponent<SphereCollider>());
        UnityEngine.Object.Destroy(DrawCube.GetComponent<Rigidbody>());
        DrawCube.GetComponent<Renderer>().material.SetColor("_Color", Color.black);
        DrawCube.transform.position = GorillaLocomotion.Player.Instance.rightControllerTransform.position;
        DrawCube.transform.localScale = new Vector3(DrawSize, DrawSize, DrawSize);
    }
}

public static GameObject DrawCube = null;
