using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppsFlyerMMP : MonoBehaviour {

    void Start()
    {
        // For detailed logging
        //AppsFlyer.setIsDebug (true);
        AppsFlyer.setAppsFlyerKey("aTYJZVwsYCTz8BbnbrDbxL");
#if UNITY_IOS
        //Mandatory - set your AppsFlyer’s Developer key.
        
        //Mandatory - set your apple app ID
        //NOTE: You should enter the number only and not the "ID" prefix
        AppsFlyer.setAppID ("YOUR_APP_ID_HERE");
        AppsFlyer.trackAppLaunch ();
#elif UNITY_ANDROID
        //Mandatory - set your Android package name
        AppsFlyer.setAppID("com.belizard.spacecolony");
        //Mandatory - set your AppsFlyer’s Developer key.
        AppsFlyer.init("aTYJZVwsYCTz8BbnbrDbxL", "AppsFlyerTrackerCallbacks");

        AppsFlyer.setCustomerUserID("659231");

        //For getting the conversion data in Android, you need to this listener.
        //AppsFlyer.loadConversionData("AppsFlyerTrackerCallbacks");

#endif
    }


    public static void ElementsCollected(int batch)
    {
        Dictionary<string, string> elementsCollected = new Dictionary<string, string>();
        elementsCollected.Add("quantity", batch.ToString());
        AppsFlyer.trackRichEvent("elements_collected", elementsCollected);
        //AppsFlyer.loadConversionData("AppsFlyerTrackerCallbacks");

        //To get the callbacks
        //AppsFlyer.createValidateInAppListener ("AppsFlyerTrackerCallbacks", "onInAppBillingSuccess", "onInAppBillingFailure");

    }

    public static void LevelCompleted()
    {

        Dictionary<string, string> levelCompleted = new Dictionary<string, string>();
        levelCompleted.Add("quantity", "1");
        AppsFlyer.trackRichEvent("level_completed", levelCompleted);
        //AppsFlyer.loadConversionData("AppsFlyerTrackerCallbacks");

        //To get the callbacks
        //AppsFlyer.createValidateInAppListener ("AppsFlyerTrackerCallbacks", "onInAppBillingSuccess", "onInAppBillingFailure");

    }
    public static void Score100()
    {
        Debug.Log("AppsFlyerMMP: Score 100");
        Dictionary<string, string> score100 = new Dictionary<string, string>();
        score100.Add("score", "1");
        AppsFlyer.trackRichEvent("score_100", score100);
    }
    public static void Score150()
    {
        Debug.Log("AppsFlyerMMP: Score 150");
        Dictionary<string, string> score150 = new Dictionary<string, string>();
        score150.Add("score", "1");
        AppsFlyer.trackRichEvent("score_150", score150);
    }
    public static void Score200()
    {
        Debug.Log("AppsFlyerMMP: Score 200");
        Dictionary<string, string> score200 = new Dictionary<string, string>();
        score200.Add("score", "1");
        AppsFlyer.trackRichEvent("score_200", score200);
    }
    public static void Score250()
    {
        Debug.Log("AppsFlyerMMP: Score 250");
        Dictionary<string, string> score250 = new Dictionary<string, string>();
        score250.Add("score", "1");
        AppsFlyer.trackRichEvent("score_250", score250);
    }

    public static void PerfectTap()
    {
        Debug.Log("AppsFlyerMMP: Perfect Tap");
        Dictionary<string, string> perfectTap = new Dictionary<string, string>();
        perfectTap.Add("perfect_tap", "1");
        AppsFlyer.trackRichEvent("perfect_tap", perfectTap);
    }
    public static void FiveAstronauts()
    {
        Debug.Log("AppsFlyerMMP: 5 Astronauts");
        Dictionary<string, string> fiveAstronauts = new Dictionary<string, string>();
        fiveAstronauts.Add("five_astronauts", "1");
        AppsFlyer.trackRichEvent("five_astronauts", fiveAstronauts);
    }
    public static void TenAstronauts()
    {
        Debug.Log("AppsFlyerMMP: 10 Astronauts");
        Dictionary<string, string> tenAstronauts = new Dictionary<string, string>();
        tenAstronauts.Add("ten_astronauts", "1");
        AppsFlyer.trackRichEvent("ten_astronauts", tenAstronauts);
    }
}
