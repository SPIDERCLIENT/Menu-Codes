public static void ShowNetworkTriggers()
{
    GameObject TriggergameObject = GameObject.Find("Environment Objects/TriggerZones_Prefab/JoinRoomTriggers_Prefab");
    for (int i = 0; i < TriggergameObject.transform.childCount; i++)
    {
        Transform child = TriggergameObject.transform.GetChild(i);
        if (child.gameObject.activeSelf)
        {
            Cube(child.position, child.rotation, child.localScale, Color.blue);
        }
    }
}

public static void Cube(Vector3 position, Quaternion rotation, Vector3 scale, Color color)
{
    GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
    UnityEngine.Object.Destroy(cube, Time.deltaTime);
    UnityEngine.Object.Destroy(cube.GetComponent<Collider>());
    UnityEngine.Object.Destroy(cube.GetComponent<Rigidbody>());
    cube.transform.position = position;
    cube.transform.localScale = scale;
    cube.transform.rotation = rotation;
    Color clr = color;
    clr.a = 0.25f;
    cube.GetComponent<Renderer>().material.shader = Shader.Find("GorillaTag/UberShader");
    cube.GetComponent<Renderer>().material.color = SettingsforMenu.Network;
}
