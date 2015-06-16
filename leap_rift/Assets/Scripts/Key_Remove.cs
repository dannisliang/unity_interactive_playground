using UnityEngine;
using System.Collections;

public class Key_Remove : MonoBehaviour {
    public KeyCode toggle = KeyCode.T;
	private bool isActive = true;
	// Update is called once per frame
	void Update () {
	if (Input.GetKeyDown(KeyCode.Z))
    {
      isActive = !isActive;
      foreach (Transform child_transform in transform)
      {
        child_transform.gameObject.SetActive(isActive);
      }
    }
	}
}