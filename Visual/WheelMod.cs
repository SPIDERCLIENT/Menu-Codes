public static void WheelMod()//UND
{
    if (ControllerInputPoller.instance.rightGrab)
    {
        GameObject Wheel1 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        GameObject Wheel2 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        GameObject QuestionableCarFormat = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        {
            Wheel1.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
            Wheel2.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
            QuestionableCarFormat.transform.localScale = new Vector3(0.55f, 0.3f, 0.55f);
            Wheel1.transform.rotation = GorillaLocomotion.Player.Instance.bodyCollider.transform.rotation;
            Wheel2.transform.rotation = GorillaLocomotion.Player.Instance.bodyCollider.transform.rotation;
            QuestionableCarFormat.transform.rotation = GorillaLocomotion.Player.Instance.bodyCollider.transform.rotation;
            Wheel1.transform.position = GorillaLocomotion.Player.Instance.bodyCollider.transform.position + new Vector3(0.25f, -0.15f, 0f);
            Wheel2.transform.position = GorillaLocomotion.Player.Instance.bodyCollider.transform.position + new Vector3(0f, -0.15f, 0.3f);
            QuestionableCarFormat.transform.position = GorillaLocomotion.Player.Instance.bodyCollider.transform.position + new Vector3(0f, -0.15f, 0.25f);
            Wheel1.GetComponent<Renderer>().material.color = new Color32(92, 52, 3, 1);
            Wheel2.GetComponent<Renderer>().material.color = new Color32(92, 52, 3, 1);
            QuestionableCarFormat.GetComponent<Renderer>().material.color = new Color32(64, 37, 3, 1);
            UnityEngine.Object.Destroy(Wheel1.GetComponent<MeshCollider>());
            UnityEngine.Object.Destroy(Wheel2.GetComponent<MeshCollider>());
            UnityEngine.Object.Destroy(QuestionableCarFormat.GetComponent<MeshCollider>());
            UnityEngine.Object.Destroy(Wheel1, Time.deltaTime);
            UnityEngine.Object.Destroy(Wheel2, Time.deltaTime);
            UnityEngine.Object.Destroy(QuestionableCarFormat, Time.deltaTime);
        }
    }
}
