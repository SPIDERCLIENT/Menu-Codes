public static void CircleMonkeys()// UND
{
    if (PhotonNetwork.CurrentRoom != null)
    {
        foreach (NetPlayer player in PhotonNetwork.PlayerListOthers)
        {
            VRRig vrrig = GorillaGameManager.instance.FindPlayerVRRig(player);
            if (vrrig != null && !vrrig.isOfflineVRRig && !vrrig.isMyPlayer)
            {
                GameObject gameObject = GameObject.CreatePrimitive(0);
                Object.Destroy(gameObject.GetComponent<BoxCollider>());
                Object.Destroy(gameObject.GetComponent<Rigidbody>());
                Object.Destroy(gameObject.GetComponent<Collider>());
                gameObject.GetComponent<MeshRenderer>().material.SetColor("_Color", Color.magenta);
                gameObject.transform.rotation = Quaternion.identity;
                gameObject.transform.localScale = new Vector3(2f, 2f, 2f);
                gameObject.transform.position = vrrig.transform.position;
                gameObject.GetComponent<MeshRenderer>().material = vrrig.mainSkin.material;
                Object.Destroy(gameObject, Time.deltaTime);

            }
        }
    }
}
