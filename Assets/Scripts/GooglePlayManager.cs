using System.Collections;
using System.Collections.Generic;
using GooglePlayGames;
using UnityEngine;

public class GooglePlayManager : MonoBehaviour
{
    private bool isConnectedToGooglePlay;
    // Use this for initialization
    void Start()
    {
        // authenticate user:
        PlayGamesPlatform.Activate();
        Social.localUser.Authenticate((bool success) => {
            isConnectedToGooglePlay = success;
        });
    }
    
    public void ShowLeaderBoard()
    {
        if (isConnectedToGooglePlay)
            Social.ShowLeaderboardUI();
    }
}