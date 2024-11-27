[Obsolete]
public static void FPSboost()//UND
{
    fps = true;
    if (fps)
    {
        QualitySettings.masterTextureLimit = 999999999;
        QualitySettings.masterTextureLimit = 999999999;
        QualitySettings.globalTextureMipmapLimit = 999999999;
        QualitySettings.maxQueuedFrames = 60;
    }
}

public static bool fps;
