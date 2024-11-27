[Obsolete]
public static void BubbleDUME()
{
    GameObject bubbles = GameObject.Find("Player Objects/Player VR Controller/GorillaPlayer/TurnParent/Main Camera/UnderwaterVisualEffects/UnderwaterParticleEffects/UnderwaterBubbles");
    ParticleSystem component = GameObject.Find("Player Objects/Player VR Controller/GorillaPlayer/TurnParent/Main Camera/UnderwaterVisualEffects/UnderwaterParticleEffects/UnderwaterBubbles").GetComponent<ParticleSystem>();
    bubbles.SetActive(true);
    GameObject.Destroy(bubbles, 4f);
    bubbles.transform.position = GorillaLocomotion.Player.Instance.bodyCollider.transform.position;
    component.startLifetime = 30;
    component.maxParticles = 9999;
    component.emissionRate = 99999;
}
