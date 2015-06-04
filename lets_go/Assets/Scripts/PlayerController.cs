using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed;
    public float mouseSpeed;
    public Text countText;
    public Text winText;

    private Rigidbody rb;
    private int count;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.text = "PICK UP THE GOLD!";
    }

    void FixedUpdate()
    {
        int new_count = 0;
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");

        float mouseH = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        Vector3 mouseMovement = new Vector3(mouseH, 0f, mouseY); 

        //this is to get input from the keyboard 
        rb.AddForce(movement * speed);
        //this gets input from the mouse
        if (Input.GetKey("e"))
        {
            rb.AddForce(mouseMovement * mouseSpeed);
        }

        //this is useless but makes the ball bounce pretty cool
        if (new_count != count)
        {
            //float incYvalue = .25F;
            //float positionY = transform.position.y + incYvalue;
            //transform.position = new Vector3(transform.position.x, transform.position.y + .25F, transform.position.z);
            
        }

        if (transform.position.y < 0)
        {
            winText.text= "You LOSE! MUHHHHHHH";
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
            transform.localScale = new Vector3(transform.localScale.x + .5F, transform.localScale.x + .5F, transform.localScale.x + .5F);
        }
        //Destroy(other.gameObject);
    }

    void SetCountText()
    {
        countText.text = "Score: " + count.ToString();
        if (count == 12)
        {
            countText.text = "";
            winText.text = "ALL GOLD HAS BEEN COLLECTED!";
        }
        else
        {
            winText.text = "";
        }
    }
}
