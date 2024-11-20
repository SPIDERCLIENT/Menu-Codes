public static void JoinRandom()//UND
{
    PhotonNetwork.Disconnect();
    GorillaNetworkJoinTrigger component = GameObject.Find("Environment Objects/TriggerZones_Prefab/JoinRoomTriggers_Prefab/JoinPublicRoom - Forest, Tree Exit").GetComponent<GorillaNetworkJoinTrigger>();
    PhotonNetworkController.Instance.AttemptToJoinPublicRoom(component, 0);
}
