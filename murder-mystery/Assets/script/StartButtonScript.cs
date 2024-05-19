using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButtonScript : MonoBehaviour
{
    StartScreen startScreen;

    void Start()
    {
        startScreen = FindObjectOfType<StartScreen>();
        startScreen.gameObject.SetActive(true);
    }

    public void StartGame(){
        startScreen.gameObject.SetActive(false);
    }

}
