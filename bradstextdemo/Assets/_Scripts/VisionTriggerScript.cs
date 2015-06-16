using UnityEngine;
using System.Collections;

public class VisionTriggerScript : MonoBehaviour {
	

	
	void OnTriggerEnter (Collider other) {
		//IF VISIONCENTER ENTERS TEXT COLLIDER, CHANGE COLOR AND EXPAND
		/*if (other.tag == "TextBox") {
			//Debug.Log(other.name);
			other.GetComponent<TextMesh> ().color = Color.blue;
			other.GetComponent<TextMesh> ().characterSize = 5;
			//Destroy (other.gameObject);
		}
		*/

		//IF VISIONCENTER ENTERS NORTH TEXT COLLIDER, EXPAND
		if (other.tag == "NorthText") {
			other.GetComponent<TextMesh> ().characterSize = 1.3f;
		}

		//IF VISIONCENTER ENTERS EAST TEXT COLLIDER, EXPAND
		if (other.tag == "EastText") {
			other.GetComponent<TextMesh> ().color = Color.green;
		}

		//IF VISIONCENTER ENTERS SOUTH TEXT COLLIDER, EXPAND
		if (other.tag == "SouthText") {
			//other.GetComponent<TextMesh> ().characterSize = 1.1f;
		}

		//IF VISIONCENTER ENTERS WEST TEXT COLLIDER, EXPAND
		if (other.tag == "WestText") {
			other.GetComponent<TextMesh> ().color = Color.blue;
		}
	}

	void OnTriggerExit (Collider other) {
		//AFTER VISIONCENTER EXITS TEXT COLLIDER, CLONE ORIGINAL TEXT OBJECT, THEN DELETE THE ORIGINAL
		/*if (other.tag == "TextBox") {
			GameObject newText = Instantiate(other.gameObject);
			newText.name = other.name;
			Destroy (other.gameObject);
		}
		*/

		//AFTER VISIONCENTER EXITS NORTH TEXT COLLIDER, CLONE ORIGINAL NORTH TEXT OBJECT, THEN DELETE THE ORIGINAL
		if (other.tag == "NorthText") {
			GameObject newText = Instantiate (other.gameObject);
			newText.name = other.name;
			Destroy (other.gameObject);
		}

		//AFTER VISIONCENTER EXITS EAST TEXT COLLIDER, CLONE ORIGINAL EAST TEXT OBJECT, THEN DELETE THE ORIGINAL
		if (other.tag == "EastText") {
			GameObject newText = Instantiate(other.gameObject);
			newText.name = other.name;
			Destroy (other.gameObject);
		}

		//AFTER VISIONCENTER EXITS SOUTH TEXT COLLIDER, CLONE ORIGINAL SOUTH TEXT OBJECT, THEN DELETE THE ORIGINAL
		if (other.tag == "SouthText") {
			GameObject newText = Instantiate(other.gameObject);
			newText.name = other.name;
			Destroy (other.gameObject);
		}

		//AFTER VISIONCENTER EXITS WEST TEXT COLLIDER, CLONE ORIGINAL WEST TEXT OBJECT, THEN DELETE THE ORIGINAL
		if (other.tag == "WestText") {
			GameObject newText = Instantiate(other.gameObject);
			newText.name = other.name;
			Destroy (other.gameObject);
		}
	}
	
}
