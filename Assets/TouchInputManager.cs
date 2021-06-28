using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TouchInputManager : MonoBehaviour
{
    public delegate void TapAction(Touch t);
     public static event TapAction onTap;

    public Vector2 movement;
    public float tapMaxMovement = 50f;
    bool tapGesture = false;

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.touches[0];
            if (touch.phase == TouchPhase.Began)
            {
                movement = Vector2.zero;
                Debug.Log("Began");
            }
            else if (touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Stationary)
            {
                movement = movement + touch.deltaPosition;
                if(movement.magnitude>tapMaxMovement)
                {
                    tapGesture = true;
                    Debug.Log("Moved");
                }
            }
            else
            {
                if (!tapGesture)
                {
                    if (onTap != null)
                        onTap(touch);
                }
                tapGesture = false;
            }
           
        }
    }


}
