using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationManager : MonoBehaviour
{
    
    public float rotationSpeed = 10f;
    public bool rotateX = false;
    public bool rotateY = false;
    public bool rotateZ = false;
    
    // Update is called once per frame
    void Update()
    {
        // smooth rotation on the y axis
        if (rotateY)
        {
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }
        // smooth rotation on the x axis
        if (rotateX)
        {
            transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime);
        }
        // smooth rotation on the z axis
        if (rotateZ)
        {
            transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
        }
    }
}
