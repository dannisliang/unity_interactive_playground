using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FP_Control : MonoBehaviour
{
    //private Rigidbody rb;

    public float mouseSpeed;
    public float speed;
    public Transform Wall_1;

    private int count;

    void Start()
    {
        //rb = GetComponent<Rigidbody>();
        count = 1;
    }

    void LateUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        float mouseH = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        //this is to get input from the keyboard
        if (transform.localRotation.x < .4f && transform.localRotation.x > -.4f)
        {
            transform.Rotate(new Vector3(moveVertical, moveHorizontal, 0F));
        }
        else
        {
            moveVertical = transform.localRotation.x;
            transform.Rotate(new Vector3(moveVertical, moveHorizontal, 0F));
        }


        //this gets input from the mouse
        //50-320
        if (Input.GetMouseButton(0))
        {
            transform.Rotate(new Vector3(mouseY, mouseH, 0F));
        }
        //attempt to reset camera 

        if (Input.GetMouseButton(1))
        {
            transform.LookAt(Wall_1); 
        }
    }
}
