using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextManager : MonoBehaviour
{
    public static TMP_Text text;
    public static GameObject textbox;
    public void Start()
    {
        text = transform.Find("TextButton/Text").GetComponent<TMP_Text>();
        textbox = transform.Find("TextButton").gameObject;
    }
    public static void DisplayText(string display)
    {
        if (string.IsNullOrEmpty(display))return;   
    
        textbox.SetActive(true);
        text.text = display;
    }
}
