using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    Clues clues;
    Clue1 clue1;
    void Start()
    {
        clues = FindObjectOfType<Clues>();
        clue1 = FindObjectOfType<Clue1>();
        clue1.GetComponent<Button>();

        clues.gameObject.SetActive(true);
        clue1.gameObject.SetActive(false);
        
    }

    void Update()
    {
        
    }

    public void OnClick() {

    }
}
