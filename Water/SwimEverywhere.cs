public static void AirSwim()//UND
{
    if (airSwimPart == null)
    {
        airSwimPart = UnityEngine.Object.Instantiate<GameObject>(GameObject.Find("Environment Objects/LocalObjects_Prefab/ForestToBeach/ForestToBeach_Prefab_V4/CaveWaterVolume"));
        airSwimPart.transform.localScale = new Vector3(5f, 5f, 5f);
        airSwimPart.GetComponent<Renderer>().enabled = false;
    }
    else
    {
        GorillaLocomotion.Player.Instance.audioManager.UnsetMixerSnapshot(0.1f);
        airSwimPart.transform.position = GorillaTagger.Instance.headCollider.transform.position + new Vector3(0f, 2.5f, 0f);
    }
}

public static GameObject airSwimPart = null;
