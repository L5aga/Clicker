using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Diagnostics;



public class UI : MonoBehaviour
{
    public TextMeshProUGUI clickerText;

    public static UIManager instance;


    private void Awake()
    {
        if (instance == null)
        {
            instance == this;
        }
        else
        {
            Destoy(this);
            Debug.LogWarning("There is alredy an instance of UiManager");
        }
    }

    public void UpdateClicks(int clicks)
    {
        clickerText.text = clicks.ToString();
    }
}
