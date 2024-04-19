using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float cooldown = 0.0f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (cooldown <= 0.0f && Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            cooldown = 1.0f;
        }

        if(cooldown > 0.0f)
        {
            cooldown -= Time.deltaTime;
        }
    }
}
