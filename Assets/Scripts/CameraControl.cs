using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{

    public float speed = 3.5f;
    private float X;
    private float Y;

    private float startPos;

    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    startPos = touch.position.x;
                    break;

                case TouchPhase.Moved:
                    if (startPos > touch.position.x)
                    {
                        transform.Rotate(Vector3.up, -speed * Time.deltaTime);
                    }
                    else if (startPos < touch.position.x)
                    {
                        transform.Rotate(Vector3.up, speed * Time.deltaTime);
                    }
                    break;

             }
        }
        
    }
}
