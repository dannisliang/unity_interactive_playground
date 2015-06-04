using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class TextOutput : MonoBehaviour {
    public Text countText;

    private int count;

    void Start()
    {
        SetCountText();
    }

    void FixedUpdate()
    {
        SetCountText();

    }

    void SetCountText()
    {
        if (transform.localRotation.x > .4)
        {
            countText.text = "Over";
        }
        else
        {
            countText.text = transform.localRotation.x.ToString();
        }

        if (transform.localRotation.x < -.4f)
        {
            countText.text = "Over";
        }
    }
}
