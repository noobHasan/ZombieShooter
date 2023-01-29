using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using AppsFlyerSDK;

public class AppsFlyerManager : MonoBehaviour//, IAppsFlyerConversionData
{

    public static AppsFlyerManager Instance;

    public string devKey;
    public string appID;


    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(this);
    }

    //public void InitAppsFlyer()
    //{
    //    AppsFlyer.initSDK(devKey, appID, this);
    //    AppsFlyer.startSDK();

    //}


    //public void onConversionDataSuccess(string conversionData)
    //{
    //    AppsFlyer.AFLog("onConversionDataSuccess", conversionData);
    //    Dictionary<string, object> conversionDataDictionary = AppsFlyer.CallbackStringToDictionary(conversionData);
    //}

    //public void onConversionDataFail(string error)
    //{
    //    AppsFlyer.AFLog("onConversionDataFail", error);
    //}

    //public void onAppOpenAttribution(string attributionData)
    //{
    //    AppsFlyer.AFLog("onAppOpenAttribution", attributionData);
    //    Dictionary<string, object> attributionDataDictionary = AppsFlyer.CallbackStringToDictionary(attributionData);
    //}

    //public void onAppOpenAttributionFailure(string error)
    //{
    //    AppsFlyer.AFLog("onAppOpenAttributionFailure", error);
    //}

}
