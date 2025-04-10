using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class HayMachine : MonoBehaviour
{
    public float movementSpeed;
    public float horizontalBoundary = 22;
    public float shootInterval;

    public GameObject hayBalePrefab;
    public Transform haySpawnpoint;
    private float shootTimer;

    public Transform modelParent;
    public GameObject blueModelPrefab;
    public GameObject yellowModelPrefab;
    public GameObject redModelPrefab;

    private void Start()
    {
        LoadModel();
    }

    private void LoadModel()
    {
        Destroy(modelParent.GetChild(0).gameObject);

        switch (GameSettings.hayMachineColor)
        {
            case HayMachineColor.Blue:
                blueModelPrefab.transform.position = new Vector3(0, 0, 0);
                blueModelPrefab.transform.rotation = Quaternion.Euler(0,0,0);
                Instantiate(blueModelPrefab, modelParent);
                break;

            case HayMachineColor.Yellow:
                yellowModelPrefab.transform.position = new Vector3(0, 0, 0);
                yellowModelPrefab.transform.rotation = Quaternion.Euler(0, 0, 0);
                Instantiate(yellowModelPrefab, modelParent);
                break;

            case HayMachineColor.Red:
                redModelPrefab.transform.position = new Vector3(0, 0, 0); 
                redModelPrefab.transform.rotation = Quaternion.Euler(0, 0, 0);
                Instantiate(redModelPrefab, modelParent);   
                break;
        }
    }

    // Update is called once per frame
    private void Update()
    {
        UpdateMovement();
        UpdateShooting();
    }

    private void UpdateMovement()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");

        if (horizontalInput < 0 && transform.position.x > -horizontalBoundary)
        {
            transform.Translate(transform.right * -movementSpeed * Time.deltaTime);
        }
        else if (horizontalInput > 0 && transform.position.x < horizontalBoundary)
        {
            transform.Translate(transform.right * movementSpeed * Time.deltaTime);
        }
    }

    private void UpdateShooting()
    {
        shootTimer -= Time.deltaTime;

        if (shootTimer <= 0 && Input.GetKey(KeyCode.Space))
        {
            shootTimer = shootInterval;
            ShootHay();
        }
    }

    private void ShootHay()
    {
        SoundManager.Instance.PlayShootClip();
        Instantiate(hayBalePrefab, haySpawnpoint.position, Quaternion.identity);
    }
}