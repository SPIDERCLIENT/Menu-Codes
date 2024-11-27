public static void DisableWater()//UND
{
    GameObject water = GameObject.Find("Beach/B_WaterVolumes");
    Transform waterTransform = water.transform;
    for (int i = 0; i < waterTransform.childCount; i++)
    {
        GameObject v = waterTransform.GetChild(i).gameObject;
        v.layer = LayerMask.NameToLayer("TransparentFX");
    }
}
