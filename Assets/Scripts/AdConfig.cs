using UnityEngine;

public static class AdConfig 
{
    public static string AppKey => GetAppKey();
    public static string BannerAdUnitId => GetBannerAdUnitId();
    public static string InterstitialAdUnitId => GetInterstitialAdUnitId();
    public static string RewardedVideoAdUnitId => GetRewardedVideoAdUnitId();

    static string GetAppKey()
    {
        return "28c3e90a5";
    }

    static string GetBannerAdUnitId()
    {
        return "nfm4lkpcbsq9xyvg";
    }

    static string GetInterstitialAdUnitId()
    {
        return "s49y3041zgd0ubwi";
    }

    static string GetRewardedVideoAdUnitId()
    {
        return "klchl2y02xnwxxm8";
    }
}
