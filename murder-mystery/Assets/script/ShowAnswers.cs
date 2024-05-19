using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowAnswers : MonoBehaviour
{
    MurderSelect murder;
    void Start()
    {
        murder = FindObjectOfType<MurderSelect>();

        murder.gameObject.SetActive(true);
    }

    public void Murder() {
        murder.gameObject.SetActive(false);
    }

}
