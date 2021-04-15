using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicTargetMover : MonoBehaviour
{
    public float spinSpeed = 180.0f;
    public float motionMagnitude = 0.1f;
    public bool DoSpin = true;
    public bool DoMotion = false;

    // Update is called once per frame
    void Update()
    {
        //rotate along the y axis of the object
        if(DoSpin)
        gameObject.transform.Rotate(Vector3.up * spinSpeed * Time.deltaTime);

        //move up and down overtime
        if(DoMotion)
        gameObject.transform.Translate(Vector3.up * Mathf.Cos(Time.timeSinceLevelLoad) * motionMagnitude);
    }
}
