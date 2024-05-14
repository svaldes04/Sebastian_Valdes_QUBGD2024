using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float jumpForce;
    public float gravityModifier;
    public bool onGround = true;
    public bool gameOver = false;
    private SpawnManager spawnScript;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
        spawnScript = GameObject.Find("Spawn Manager").GetComponent<SpawnManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && onGround){
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            onGround = false;
        }
    }

    void OnCollisionEnter(Collision collision){
        if (collision.gameObject.CompareTag("Ground")){
            onGround = true;
        } else if(collision.gameObject.CompareTag("Obstacle")){
            gameOver = true;
            spawnScript.StopSpawning();
            Debug.Log("Game over");
        }  
    }
}
