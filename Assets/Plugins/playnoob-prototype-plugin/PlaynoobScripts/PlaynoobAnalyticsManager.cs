using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Facebook.Unity;
//using GameAnalyticsSDK;

public class PlaynoobAnalyticsManager : Singleton<PlaynoobAnalyticsManager>
{
    void Start()
    {
        InitSDKS();
    }


    public void InitSDKS()
    {
        //AppsFlyerManager.Instance.InitAppsFlyer();
        //InitializeFBSDK();
        //GameAnalytics.Initialize();

    }


    #region Appmatrica Implementation

    //public void SendEvent(string name, Dictionary<string, object> data)
    //{
    //    if (AppMetrica.Instance != null)
    //    {
    //        AppMetrica.Instance.ReportEvent(name, data);
    //    }
    //}


    //public void SendLevelStart()
    //{

    //    Dictionary<string, object> data = new Dictionary<string, object>();

    //    int gamesPlayed = PlayerPrefs.GetInt(PlaynoobConstants.GamesPlayed) + 1; // Increase only when level start happens
    //    PlayerPrefs.SetInt(PlaynoobConstants.GamesPlayed, gamesPlayed);

    //    data["level_number"] = PlayerPrefs.GetInt(PlaynoobConstants.CurrentLevel); // sequential number of level
    //    data["level_name"] = "Level_" + LevelLoader.Instance.Actual_Level_Index().ToString(); // the actual level number shown up top
    //    data["level_count"] = gamesPlayed; // total number of games played

    //    data["level_loop"] = LevelLoader.Instance.levelLoopIndex(); // the number of passage of level after finishing all looped level
    //    data["level_random"] = 0; // is the level randomly generated
    //    data["level_type"] = "normal"; // type of level
    //    SendEvent("level_start", data);
    //}


    //public void SendLevelEnd(bool win)
    //{
    //    int gamesPlayed = PlayerPrefs.GetInt(PlaynoobConstants.GamesPlayed);

    //    Dictionary<string, object> data = new Dictionary<string, object>();
    //    data["level_number"] = PlayerPrefs.GetInt(PlaynoobConstants.CurrentLevel); // sequential number of level
    //    data["level_name"] = "Level_" + LevelLoader.Instance.Actual_Level_Index().ToString(); // the actual level number shown up top
    //    data["level_count"] = gamesPlayed; // total number of games played
    //    data["level_loop"] = LevelLoader.Instance.levelLoopIndex(); // the number of passage of level after finishing all looped level
    //    data["level_random"] = 0; // is the level randomly generated
    //    data["level_type"] = "normal"; // type of level

    //    data["result"] = win ? "win" : "lose"; //level finish type

    //    //TODO: Implement progress if you track the level progress
    //    //int levelProgress = GameplayPanelControl.Instance.levelProgress;
    //    //if (win) levelProgress = 100;
    //    //data["progress"] = levelProgress;

    //    SendEvent("level_finish", data);
    //}

    //private void OnApplicationQuit()
    //{
    //    AppMetrica.Instance.SendEventsBuffer();
    //}

    //private void OnApplicationPause(bool pause)
    //{
    //    AppMetrica.Instance.SendEventsBuffer();
    //}

    #endregion


    #region Facebook implementation

    //void InitializeFBSDK()
    //{
    //    if (!FB.IsInitialized)
    //    {
    //        // Initialize the Facebook SDK
    //        FB.Init(InitCallback, OnHideUnity);

    //        //Debug.LogError("FB Initializing..");
    //    }
    //    else
    //    {
    //        // Already initialized, signal an app activation App Event
    //        FB.ActivateApp();

    //        //Debug.LogError("FB Unity Already Initialized..");
    //    }
    //}

    //private void InitCallback()
    //{
    //    //Debug.LogError("Init Callback Received..");
    //    if (FB.IsInitialized)
    //    {
    //        // Signal an app activation App Event
    //        FB.ActivateApp();
    //        // Continue with Facebook SDK
    //        // ...
    //        //Debug.LogError("FB Unity  Initialized.");
    //    }
    //    else
    //    {
    //        //Debug.LogError("FB Unity Failed to Initialize the Facebook SDK");
    //    }
    //}

    //private void OnHideUnity(bool isGameShown)
    //{
    //    if (!isGameShown)
    //    {
    //        // Pause the game - we will need to hide
    //        //Time.timeScale = 0;
    //    }
    //    else
    //    {
    //        // Resume the game - we're getting focus again
    //        //Time.timeScale = 1;
    //    }
    //}
    #endregion
}
