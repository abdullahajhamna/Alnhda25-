using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charactercontroller : MonoBehaviour
{
    public float movementSpeed = 0.1f; 
    public float touchSensitivity = 0.5f; 

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                float hMovement = touch.deltaPosition.x * touchSensitivity * Time.deltaTime;
                float vMovement = touch.deltaPosition.y * touchSensitivity * Time.deltaTime;

                transform.Translate(new Vector3(hMovement, 0, vMovement));
            }
        }
    }
}
