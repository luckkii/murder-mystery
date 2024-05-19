using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Decipher : MonoBehaviour
{
    public TextMeshProUGUI output;
    public TMP_InputField input;

    public GameObject clue;
    public Canvas canvas;

    public string cipher;

    public void check(){
        if (!input.text.Equals(cipher)){
            output.text = "Try again";
        }
        else {
            output.text = "Correct!";
            canvas.gameObject.SetActive(false);
            clue.gameObject.SetActive(true);
            Debug.Log("it worked");
        }

    }
}
