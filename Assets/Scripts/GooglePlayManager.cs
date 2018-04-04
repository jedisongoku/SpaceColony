using System.Collections;
using System.Collections.Generic;
using GooglePlayGames;
using UnityEngine;

public class GooglePlayManager : MonoBehaviour
{
    //Shows whether the user is connected or not to Google Play
    private bool isConnectedToGooglePlay;

    // Use this for initialization
    void Start()
    {
        //Activate google play
        PlayGamesPlatform.Activate();

        //Sign in
        Social.localUser.Authenticate((bool success) => {
            isConnectedToGooglePlay = success;
        });
    }
    
    //Show the leader board if the user is signed in
    public void ShowLeaderBoard()
    {
        if (isConnectedToGooglePlay)
            Social.ShowLeaderboardUI();
    }
}