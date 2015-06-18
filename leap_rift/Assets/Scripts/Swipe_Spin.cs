using UnityEngine;
using System.Collections;
using Leap;

public class Swipe_Spin : MonoBehaviour{
    Controller controller;
    public float minimumSwipeLength = 50;
    public float minimumSwipeVelocity = 200;
    public float spinAngle = 45;

    public GameObject whatToSpin;

    void Start()
    {
        controller = new Controller();
        controller.EnableGesture(Gesture.GestureType.TYPE_SWIPE);
        controller.Config.SetFloat("Gesture.Swipe.MinLength", minimumSwipeLength);
        controller.Config.SetFloat("Gesture.Swipe.MinVelocity", minimumSwipeVelocity);
        controller.Config.Save();
    }

    void Update()
    {
        Frame frame = controller.Frame();
        GestureList gesturelist = frame.Gestures();
        //for dictating which hand 
        Hand whichHand = frame.Hands.Frontmost;
        if (whichHand.IsRight)
        {
            for (int i = 0; i < gesturelist.Count; i++)
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
            }
        }
    }
}
