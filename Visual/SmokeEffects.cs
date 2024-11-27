public static void SmokeEffects()//UND
{
    GameObject.Find("Environment Objects/05Maze_PersistentObjects/RocketShip_Prefab/RocketShip_FX").transform.localScale = new Vector3(0.05f, 0.05f, 0.05f);
    UnityEngine.GameObject.Find("Environment Objects/05Maze_PersistentObjects/RocketShip_Prefab/RocketShip_FX").gameObject.SetActive(true);
    UnityEngine.GameObject.Find("Environment Objects/05Maze_PersistentObjects/RocketShip_Prefab/RocketShip_FX").gameObject.GetComponent<ParticleSystem>().Play();
    UnityEngine.GameObject.Find("Environment Objects/05Maze_PersistentObjects/RocketShip_Prefab/RocketShip_FX").gameObject.transform.position = GorillaTagger.Instance.headCollider.gameObject.transform.position;
}
