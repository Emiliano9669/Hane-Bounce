using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movible : MonoBehaviour
{

    public int speed;
    private bool wasGrabbed = false;


    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0); // get first touch since touch count is greater than zero


            if (touch.phase == TouchPhase.Stationary || touch.phase == TouchPhase.Moved)
            {
                // get the touch position from the screen touch to world point
                Vector3 touchedPos = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, 10));

                float resultX = Mathf.Abs(touchedPos.x - this.transform.position.x);
                float resultY = Mathf.Abs(touchedPos.y - this.transform.position.y);
                print("entramos a segunda fase");
                if ((resultX < 1 && resultY < 1) || (wasGrabbed == true))
                {
                    print("entramos a tercera fase");
                    wasGrabbed = true;
                    // lerp and set the position of the current object to that of the touch, but smoothly over time.
                    transform.position = Vector3.Lerp(this.transform.position, touchedPos, Time.deltaTime * speed);
                }
            }
        }
        else
        {
            print("sin touch");
            wasGrabbed = false;
        }
    }



}