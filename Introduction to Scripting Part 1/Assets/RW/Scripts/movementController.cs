using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HayMachine : MonoBehaviour
{
    public GameObject hayBalePrefab;
    public Transform haySpawnpoint; 
    public float shootInterval; 
    private float shootTimer; 

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
        UpdateShooting();

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

    private void ShootHay()
    {

        Instantiate(hayBalePrefab, haySpawnpoint.position, Quaternion.identity);

    }
    private void UpdateShooting()
    {
        shootTimer -= Time.deltaTime; // 1

        if (shootTimer <= 0 && Input.GetKey(KeyCode.Space)) // 2
        {
            shootTimer = shootInterval; // 3
            ShootHay(); // 4
        }
    }

}
