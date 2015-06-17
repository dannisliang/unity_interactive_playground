using UnityEngine;
using System.Collections;
using Leap;

public class Swipe_Gesture : MonoBehaviour {
    Controller controller; 
    public float minimumSwipeLength = 50;
    public float minimumSwipeVelocity = 200;


	void Start () {
        controller = new Controller();
        controller.EnableGesture(Gesture.GestureType.TYPE_SWIPE);
        controller.Config.SetFloat("Gesture.Swipe.MinLength", minimumSwipeLength);
        controller.Config.SetFloat("Gesture.Swipe.MinVelocity", minimumSwipeVelocity);
        controller.Config.Save();
	}
	
	void Update () {
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
                    }
                    if (swipeDirection.x > 0)
                    {
                        Debug.Log("Right");
                    }
                }
            }
        }
	}
}
