using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Import_Text : MonoBehaviour {
    Text text;

    void FixedUpdate()
    {
        string txt = System.IO.File.ReadAllText(@"C:\Users\James\Desktop\main.txt");
        text = GetComponent<Text>();
        text.text = txt;
    }
}
