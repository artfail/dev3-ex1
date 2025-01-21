using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;

using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;

public class TouchMove : MonoBehaviour
{
    void Awake()
    {
        EnhancedTouchSupport.Enable();
    }
}












/*

    public Transform paddle;

    void Update()
    {
        if (Touch.activeTouches.Count > 0)
        {
            Touch touch = Touch.activeTouches[0];

            if (touch.phase == TouchPhase.Began || touch.phase == TouchPhase.Moved)
            {
                Vector2 newPos = Camera.main.ScreenToWorldPoint(touch.screenPosition);
                newPos.y = paddle.position.y;
                paddle.position = newPos;
            }
        }
    }
    */