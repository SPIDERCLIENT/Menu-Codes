public static void CustomScreens()
{
    if (motdboards == 1)
    {
        mat.color = new Color32(4, 60, 4, byte.MaxValue);
    }
    GameObject computerScreen = GameObject.Find("Environment Objects/LocalObjects_Prefab/TreeRoom/TreeRoomInteractables/GorillaComputerObject/ComputerUI/monitor/monitorScreen");
    computerScreen.GetComponent<Renderer>().material = mat;

    GameObject forestScreen = GameObject.Find("Environment Objects/LocalObjects_Prefab/TreeRoom/TreeRoomBoundaryStones/BoundaryStoneSet_Forest/wallmonitorforestbg");
    forestScreen.GetComponent<Renderer>().material = mat;

    GameObject boards = GameObject.Find("Environment Objects/LocalObjects_Prefab/TreeRoom").transform.GetChild(102).gameObject;
    boards.GetComponent<Renderer>().material = mat;

    GameObject forestboard = GameObject.Find("Environment Objects/LocalObjects_Prefab/Forest/").transform.GetChild(23).gameObject;
    forestboard.GetComponent<Renderer>().material = mat;

    GameObject citywelcomescreen = GameObject.Find("Environment Objects/LocalObjects_Prefab/TreeRoom/TreeRoomBoundaryStones/BoundaryStoneSet_City/Wallmonitor_Small_Prefab").transform.GetChild(1).gameObject;
    citywelcomescreen.GetComponent<Renderer>().material = mat;

    GameObject cloudwelcomescreen = GameObject.Find("Environment Objects/LocalObjects_Prefab/TreeRoom/TreeRoomBoundaryStones/BoundaryStoneSet_Clouds/Wallmonitor_Small_Prefab").transform.GetChild(1).gameObject;
    cloudwelcomescreen.GetComponent<Renderer>().material = mat;

    GameObject cityboard = GameObject.Find("Environment Objects/LocalObjects_Prefab/City_WorkingPrefab/").transform.GetChild(119).gameObject;
    cityboard.GetComponent<Renderer>().material = mat;

    GameObject ATMandstoreandcitystuff = GameObject.Find("Environment Objects/LocalObjects_Prefab/City_WorkingPrefab/").transform.GetChild(29).gameObject;
    ATMandstoreandcitystuff.GetComponent<Renderer>().material = mat;

    GameObject Arcadeboard1 = GameObject.Find("Environment Objects/LocalObjects_Prefab/City_WorkingPrefab/BoundaryStoneSet/").transform.GetChild(1).gameObject;
    Arcadeboard1.GetComponent<Renderer>().material = mat;
}

public static int motdboards = 1;

public static Material mat = new Material(Shader.Find("GorillaTag/UberShader"));

