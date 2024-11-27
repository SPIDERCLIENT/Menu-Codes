public static void DisableHorror()//UND
{
    BetterDayNightManager.instance.SetTimeOfDay(3);
    Camera.main.farClipPlane = Camera.main.farClipPlane;
}
