public static void MakeAllRGB()//UND
{
    float time = Time.time;
    float Red = Mathf.Sin(time * 2f) * 0.5f + 0.5f;
    float Green = Mathf.Sin(time * 1.5f) * 0.5f + 0.5f;
    float Blue = Mathf.Sin(time * 2.5f) * 0.5f + 0.5f;
    foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
    {
        vrrig.mainSkin.material.color = new Color(Red, Green, Blue);
    }
}
