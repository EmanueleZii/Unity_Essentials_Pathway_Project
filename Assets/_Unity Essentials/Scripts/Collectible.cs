using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public float rotationspeed = 0.5f;
    public GameObject onCollectEffect;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotationspeed, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) {
            // Destroy the collectible
            Destroy(gameObject);
            // instantiate the particle effect
            Instantiate(onCollectEffect, transform.position, transform.rotation);
        }
        
    }
}
