using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateHay : MonoBehaviour
{

    public Space space;
    public Vector3 movementSpeed; 
    public float RotationVelocity_x; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(RotationVelocity_x * Time.deltaTime,0,0);

        transform.Translate(movementSpeed * Time.deltaTime, space);

    }
}
