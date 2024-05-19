using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using TMPro;

public class Writer : MonoBehaviour
{
   public TextMeshProUGUI output;
   public TMP_InputField input;
   private string notes;

   public void write(){
        notes += input.text;
        notes += " ";
        output.text = notes;
        input.gameObject.SetActive(false);
        input.text = "";
   }

   public void reappear(){
    input.gameObject.SetActive(true);
   }
}
