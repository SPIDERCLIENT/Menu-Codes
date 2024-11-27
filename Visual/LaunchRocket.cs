public static void LaunchRocket()//UND
{
    GameObject.Find("Environment Objects/05Maze_PersistentObjects/RocketShip_Prefab").GetComponent<ScheduledTimelinePlayer>().timeline.Stop();
    GameObject.Find("Environment Objects/05Maze_PersistentObjects/RocketShip_Prefab").GetComponent<ScheduledTimelinePlayer>().timeline.Play();
}
