public static void RemoveLeaves()//UND
{
    foreach (GameObject l in Resources.FindObjectsOfTypeAll<GameObject>())
    {
        if (l.activeSelf && l.name.Contains("fallleaves"))
        {
            l.SetActive(false);
            leaves.Add(l);
        }
    }
}

public static List<GameObject> leaves = new List<GameObject> { };
