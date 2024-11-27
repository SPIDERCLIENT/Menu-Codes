public static void BubblesCrash()// UND
{
    GameObject bubbles = GameObject.Find("Player Objects/Player VR Controller/GorillaPlayer/TurnParent/Main Camera/UnderwaterVisualEffects/UnderwaterParticleEffects/UnderwaterBubbles");
    for (int i = 0; i < 5000; i++)
    {
        GameObject newBubble = GameObject.Instantiate(bubbles);
        newBubble.SetActive(true);
        newBubble.transform.localScale = new Vector3(1f, 1f, 1f);
        newBubble.transform.position = GorillaLocomotion.Player.Instance.rightControllerTransform.position;

        GameObject.Destroy(newBubble, 9f);
    }
}
