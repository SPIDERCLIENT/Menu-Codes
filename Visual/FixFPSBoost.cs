[Obsolete]
public static void FixFPSBoost()//UND
{
    if (fps)
    {
        QualitySettings.masterTextureLimit = default;
        QualitySettings.masterTextureLimit = default;
        QualitySettings.globalTextureMipmapLimit = default;
        QualitySettings.maxQueuedFrames = default;
        fps = false;
    }
}

public static bool fps;
