using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //enable gyroscope in device
        Input.gyro.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Input.gyro.attitude);
        //read gyroscope input
        transform.rotation = Input.gyro.attitude; //flipped so that correct directions are read


    }
}
