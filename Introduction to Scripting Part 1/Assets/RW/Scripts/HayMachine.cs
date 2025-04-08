using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementController : MonoBehaviour
{

    public int movementSpeed; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        UpdateMovement();
    }
    private void UpdateMovement()
    {
        float horitzontalInput = Input.GetAxisRaw("Horizontal");

        if ( horitzontalInput < 0)
        {
            transform.Translate(transform.right * -movementSpeed  * Time.deltaTime );

        }
        else if(  horitzontalInput > 0 )
        {
            transform.Translate(transform.right * movementSpeed  * Time.deltaTime );
        }
    }
}
