public static void BubblesSpamLeft()// UND
{
    GameObject bubbles = GameObject.Find("Player Objects/Player VR Controller/GorillaPlayer/TurnParent/Main Camera/UnderwaterVisualEffects/UnderwaterParticleEffects/UnderwaterBubbles");
    if (ControllerInputPoller.instance.leftGrab)
    {
        for (int i = 0; i < 5; i++)
        {
            GameObject newBubble = GameObject.Instantiate(bubbles);
            newBubble.SetActive(true);
            newBubble.transform.localScale = new Vector3(1f, 1f, 1f);

            newBubble.transform.position = GorillaLocomotion.Player.Instance.leftControllerTransform.position;

            GameObject.Destroy(newBubble, 2f);
        }
    }
}
