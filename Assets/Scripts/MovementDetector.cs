using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementDetector : MonoBehaviour
{
    public float flickSpeed; //reference speed of flicking device to be registered as an input command

    Ray ray;

    // Start is called before the first frame update
    void Start()
    {
        // ray = Camera.main.ViewportPointToRay(new Vector3 (0.5f, 0.5f, 0));

    }

    // private RaycastHit CreateForwardRaycast()
    // {
    //     RaycastHit hit;
    //     CreateForwardRaycast ray = new CreateForwardRaycast(transform.position, transform.forward);

    //     Physics.Raycast(ray, out hit, defaultLength);
    //     return hit;
    // }

    void FixedUpdate() //use to accomadate for Physics engine
    {

        // RaycastHit[] hits;
        // hits = Physics.RaycastAll(transform.position, transform.forward, 500.0f); //500 is a random value, might need to tune

        //update ray
        // ray = transform.position, transform.forward;
        RaycastHit hitData;
        ray = Camera.main.ViewportPointToRay(new Vector3 (0.5f, 0.5f, 0)); //works, but might not be efficient

        Debug.DrawRay(ray.origin, ray.direction*10);

        if (Input.gyro.rotationRate.x >= flickSpeed){

            Debug.Log("FLICK DETECTED");

            //raycast in direction of camera to check for buttons
            if (Physics.Raycast(ray, out hitData)){
                Debug.Log("Something is hit");
            }

        }

    }
}
