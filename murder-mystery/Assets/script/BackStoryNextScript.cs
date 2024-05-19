using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackStoryNextScript : MonoBehaviour
{
    Backstory backstory;
    void Start()
    {
        backstory = FindObjectOfType<Backstory>();
        backstory.gameObject.SetActive(true);
    }

    public void ContinueWithClues(){
        backstory.gameObject.SetActive(false);
    }

}
