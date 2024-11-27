public static void Lowhz()//UND
{
    GorillaZiplineSettings[] ziplineSettings = UnityEngine.Object.FindObjectsOfType<GorillaZiplineSettings>();
    GorillaZipline[] gorillaZiplines = UnityEngine.Object.FindObjectsOfType<GorillaZipline>();
    foreach (GorillaZiplineSettings gorillaZiplineSettings in ziplineSettings)
    {
        gorillaZiplineSettings.minSlidePitch = 50f;
        gorillaZiplineSettings.maxSlidePitch = 50f;
        gorillaZiplineSettings.maxSlideVolume = 50f;
        gorillaZiplineSettings.maxSpeed = 50f;
        gorillaZiplineSettings.gravityMulti = 50f;
        gorillaZiplineSettings.friction = 50f;
        gorillaZiplineSettings.maxFriction = 50f;
        gorillaZiplineSettings.maxFrictionSpeed = 50f;
    }
}
