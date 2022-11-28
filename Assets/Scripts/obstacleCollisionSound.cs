using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleCollisionSound : MonoBehaviour
{
    AudioSource collisionSound;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == ("Player"))
        {
            collisionSound.Play();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        collisionSound = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
