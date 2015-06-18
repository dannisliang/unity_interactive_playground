using UnityEngine;
using System.Collections;
using Leap;

public class Circle_Gesture : MonoBehaviour {
    Controller controller;

    public GameObject whatToSpin;

    void Start()
    {
        controller = new Controller();
        controller.EnableGesture(Gesture.GestureType.TYPE_CIRCLE);
        controller.Config.SetFloat("Gesture.Circle.MinRadius", 100f);
        controller.Config.SetFloat("Gesture.Circle.MinArc", 1.52f);
        controller.Config.Save();
    }

    void LateUpdate()
    {
        Frame frame = controller.Frame();
        GestureList gesturelist = frame.Gestures();
        for (int i = 0; i < gesturelist.Count; i++)
        {
            Gesture gesture = gesturelist[i];
            if (gesture.Type == Gesture.GestureType.TYPECIRCLE)
            {
                Debug.Log("circle");
                whatToSpin.transform.Rotate(Vector3.up, 90 * Time.deltaTime);
            }
        }

            /*for (int i = 0; i < gesturelist.Count; i++)
            {
                Gesture gesture = gesturelist[i];
                if (gesture.Type == Gesture.GestureType.TYPESWIPE)
                {
                    SwipeGesture swipe = new SwipeGesture(gesture);
                    Vector swipeDirection = swipe.Direction;
                    if (swipeDirection.x < 0)
                    {
                        Debug.Log("Left");
                        whatToSpin.transform.Rotate(Vector3.up, spinAngle * Time.deltaTime);
                    }
                    if (swipeDirection.x > 0)
                    {
                        Debug.Log("Right");
                        whatToSpin.transform.Rotate(Vector3.up, -spinAngle * Time.deltaTime);
                    }
                }
            }*/
    }
}
