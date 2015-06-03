using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

    public float speed;
    public float xangle, yangle, zangle;

	// Update is called once per frame
	void Update () 
    {
        transform.Rotate(new Vector3(xangle, yangle, zangle) * Time.deltaTime * speed);   
	}
}
