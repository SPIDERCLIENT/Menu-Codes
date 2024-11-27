public static void FastSwim()//UND
{
    if (GorillaLocomotion.Player.Instance.InWater)
    {
        GorillaLocomotion.Player.Instance.gameObject.GetComponent<Rigidbody>().velocity *= 1.069f;
    }
}
