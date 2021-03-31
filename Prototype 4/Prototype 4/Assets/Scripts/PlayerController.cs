using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private GameObject focalPoint;
    private Rigidbody playerRb;

    public bool hasPowerUp;
    public float powerUpStrength = 16.0f;

    public GameObject powerupIndicator;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("FocalPoint");
    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        playerRb.AddForce(focalPoint.transform.forward * speed * Time.deltaTime * forwardInput);

        powerupIndicator.transform.position = transform.position + new Vector3(0, 0.5f, 0);
    }

    //This block allows player to collect power ups, destroys power up prefab
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PowerUp"))
        {
            hasPowerUp = true;
            Destroy(other.gameObject);
            Debug.Log("POWER UP!");

            StartCoroutine(PowerUpCountdownRoutine());

            powerupIndicator.gameObject.SetActive(true);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && hasPowerUp)
        {
            //Gets the enemies rigidbody component so we can have access to its physical properties
            Rigidbody enemyRigidbody = collision.gameObject.GetComponent<Rigidbody>();
            //Get the position of the enemy in relation to the player
            Vector3 awayFromPlayer = (collision.gameObject.transform.position - transform.position);
            //Logs the collision between the player and enemies with pickup
            Debug.Log("Player has collided with " + collision.gameObject + "with powerup set to "+ hasPowerUp);
            //Kicks enemies back OnCollision with player
            enemyRigidbody.AddForce(awayFromPlayer * powerUpStrength, ForceMode.Impulse);
        }
    }
   
    IEnumerator PowerUpCountdownRoutine()
    {
        yield return new WaitForSeconds(7); hasPowerUp = false;
        powerupIndicator.gameObject.SetActive(false);
    }
}
