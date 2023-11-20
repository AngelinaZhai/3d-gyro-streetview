using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// using UnityEngine.PhysicsModule;

public class MovementDetector : MonoBehaviour
{
    public float flickSpeed; //reference speed of flicking device to be registered as an input command

    // Ray ray;
    int currentID = 0;
    public static GameObject currentObject;

    // Start is called before the first frame update
    void Start()
    {
        // ray = Camera.main.ViewportPointToRay(new Vector3 (0.5f, 0.5f, 0));
        currentObject = null;
        currentID = 0;

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

        RaycastHit[] hits;
        // RaycastHit hits;
        hits = Physics.RaycastAll(transform.position, transform.forward, 500.0f); //500 is a random value, might need to tune

        //update ray
        // ray = transform.position, transform.forward;
        RaycastHit[] hitData;
        // ray = Camera.main.ViewportPointToRay(new Vector3 (0.5f, 0.5f, 0)); //works, but might not be efficient

        // Debug.DrawRay(ray.origin, ray.direction*400);

        // if (Physics.Raycast(ray, out hitData)){
        //     Debug.Log("Something is hit");
        // } //this works

        if (Input.gyro.rotationRate.x >= flickSpeed){

            Debug.Log("FLICK DETECTED");

            for (int i = 0; i < hits.Length; i++){
                RaycastHit hit = hits[i];
                int id = hit.collider.gameObject.GetInstanceID();
                // Debug.Log(id); //this is working
                
                if (currentID != id) {
                    currentID = id;
                    currentObject = hit.collider.gameObject;

                    string name = currentObject.name;

                    Debug.Log(name); //this works

                    if (name == "Button"){
                        Debug.Log("NEXT FOUND");
                        currentObject.GetComponent<Button>().onClick.Invoke();
                    }
                }


            }

            //raycast in direction of camera to check for buttons
            // if (Physics.Raycast(ray, out hitData)){
            //     Debug.Log("Something is hit");
            //     // Debug.Log(hitData);
                
            // }

        }

    }
}
