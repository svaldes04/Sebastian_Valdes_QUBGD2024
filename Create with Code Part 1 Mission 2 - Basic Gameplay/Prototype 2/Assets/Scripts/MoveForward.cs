using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 40.0f;
    private float upperBound = 30;
    private float lowerBound = -10;

    // Update is called once per frame
    void Update()
    {
        // Move forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        // Destroy GameObject if out of bounds
        if(transform.position.z > upperBound)
        {
            Destroy(gameObject);
        } else if(transform.position.z < lowerBound){
            Destroy(gameObject);
            // Debug.Log("Game Over!");
            Debug.Log("you missed an animal");
        }
    }
}
