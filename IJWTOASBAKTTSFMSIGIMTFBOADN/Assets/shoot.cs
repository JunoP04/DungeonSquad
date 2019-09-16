using UnityEngine;
using System.Collections;

public class shoot : MonoBehaviour
{

    public float xAngle, yAngle, zAngle;
    void Update()
    {
        // Move the object forward along its z axis 1 unit/second.
        transform.Translate(Vector3.right * Time.deltaTime * 2);
        transform.Rotate(xAngle, yAngle, Time.deltaTime * 2, Space.Self);
        // Move the object upward in world space 1 unit/second.
        //transform.Translate(Vector3.up * Time.deltaTime, Space.World);
    }
}