using UnityEngine;
using System.Collections;
using System.IO;
using System.Text;

public class TextWest1Script : MonoBehaviour {
	
	
	void Start () {
		string txt = System.IO.File.ReadAllText (@"C:\Users\Brad\Desktop\TextDemo\textWest1.txt");
		GetComponent<TextMesh> ().text = txt;
		
		//GetComponent<TextMesh> ().fontStyle = FontStyle.BoldAndItalic;
		GetComponent<TextMesh> ().characterSize = 1;
		GetComponent<TextMesh> ().color = Color.black;
		GetComponent<TextMesh> ().text = txt;
	}
}