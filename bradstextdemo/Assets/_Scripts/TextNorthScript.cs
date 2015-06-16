using UnityEngine;
using System.Collections;
using System.IO;
using System.Text;

public class TextNorthScript : MonoBehaviour {

	
	void Start () {
		string txt = System.IO.File.ReadAllText (@"C:\Users\Brad\Desktop\TextDemo\textNorth.txt");
		GetComponent<TextMesh> ().text = txt;

		//GetComponent<TextMesh> ().fontStyle = FontStyle.Italic;
		GetComponent<TextMesh> ().characterSize = 1;
		GetComponent<TextMesh> ().color = Color.white;
		GetComponent<TextMesh> ().text = txt;
        GetComponent<TextAsset
	}
}