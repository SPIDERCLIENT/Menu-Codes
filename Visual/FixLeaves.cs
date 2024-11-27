public static void FixLeaves()//UND
{
    foreach (GameObject l in leaves)
    {
        l.SetActive(true);
    }
    leaves.Clear();
}

public static List<GameObject> leaves = new List<GameObject> { };
