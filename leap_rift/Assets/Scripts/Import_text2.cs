using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Import_text2 : MonoBehaviour {
    Text text;

    void FixedUpdate()
    {
        string txt = System.IO.File.ReadAllText(@"C:\Users\James\Desktop\two.txt");
        text = GetComponent<Text>();
        text.text = txt;
    }
}
