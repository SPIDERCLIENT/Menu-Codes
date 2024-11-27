public static void ParticleSpam()//UND
{
    if (ControllerInputPoller.instance.rightGrab)
    {
        ParticleSystem particleSystem = new GameObject("FireBreath").AddComponent<ParticleSystem>();
        particleSystem.transform.position = GorillaLocomotion.Player.Instance.rightControllerTransform.position;
        particleSystem.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        particleSystem.transform.rotation = GorillaLocomotion.Player.Instance.rightControllerTransform.rotation;
        particleSystem.GetComponent<Renderer>().material.shader = Shader.Find("GorillaTag/UberShader");
        particleSystem.GetComponent<Renderer>().material.color = SettingsforMenu.ParticalColor;
        particleSystem.Play();
        Object.Destroy(particleSystem.gameObject, 0.5f);
    }

    if (ControllerInputPoller.instance.leftGrab)
    {
        ParticleSystem particleSystem2 = new GameObject("FireBreath").AddComponent<ParticleSystem>();
        particleSystem2.transform.position = GorillaLocomotion.Player.Instance.leftControllerTransform.position;
        particleSystem2.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        particleSystem2.transform.rotation = GorillaLocomotion.Player.Instance.leftControllerTransform.rotation;
        particleSystem2.GetComponent<Renderer>().material.shader = Shader.Find("GorillaTag/UberShader");
        particleSystem2.GetComponent<Renderer>().material.color = SettingsforMenu.ParticalColor;
        particleSystem2.Play();
        Object.Destroy(particleSystem2.gameObject, 0.5f);
    }
}
