using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroCamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Input.gyro.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(Input.gyro.attitude);
        //read gyroscope input
        Vector3 previousAngle = transform.eulerAngles;
        Vector3 gyroInput = -Input.gyro.rotationRateUnbiased;

        Vector3 newAngle = previousAngle + gyroInput * Time.deltaTime * Mathf.Rad2Deg;
        newAngle.x = 0.0f;
        newAngle.z = 0.0f; //anchors the angle to avoid confusion
        transform.eulerAngles = newAngle;
    }
}
