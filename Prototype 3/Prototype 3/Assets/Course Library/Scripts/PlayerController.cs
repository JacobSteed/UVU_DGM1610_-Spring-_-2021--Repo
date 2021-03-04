using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float jumpForce;
    public float gravityMod;
    // Keep player from double jumping
    public bool isOnGround = true;
    //
    public bool isGameOver = false;

    private Animator playerAnim;
   
    // Start is called before the first frame update
    void Start()
    {
        //Gravity Mod and Jump Force
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityMod;

        playerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !isGameOver)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;

            playerAnim.SetTrigger("Jump_trig");
        }
    }
    
    // Collision to prevent double jumping
    private void OnCollisionEnter(Collision collision)
    {
       if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
       // Coliding with an object = Game Over
       else if (collision.gameObject.CompareTag("Obsticle"))
        {
            isGameOver = true;
            Debug.Log("Game Over!!!");
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);
        }
    }
}
