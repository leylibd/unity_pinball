using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballSpawn : MonoBehaviour
{
    Vector3 startPos;
    public GameObject hole;
    public GameObject ballPrefab;
    public GameObject newBall;

    public float force = 5.0f;

    AudioSource startSound;

    bool justSpawned = false;
    

    // Start is called before the first frame update
    void Start()

    {
        startSound = GetComponent<AudioSource>();
        //CALL SPAWNING FUNC HERE 
        startPos = transform.position;
        Debug.Log("start pos set");
        
        reSpawn();
        Debug.Log("spawned");
        

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown && justSpawned)
        {
            Debug.Log("im here");
            newBall.GetComponent<Rigidbody>().AddForce(0, 0, force);
            //Debug.Log("key force pressed ");
            justSpawned = false;
        }
            

        bool dead = hole.GetComponent<gameOverTrigger>().isDead; //referencing to trigger hole
        
        if (dead  && newBall == null)
        {
            dead = false;
            reSpawn();
        }

    }

    /*void Spawn()
    {
        //GameObject newBall = Instantiate(ball);

        //newBall = Instantiate(ballPrefab, startPos, Quaternion.identity) as GameObject;
        newBall = Instantiate(ballPrefab) as GameObject;

    }*/

    void reSpawn()
    {

        StartCoroutine(spawnDelay());
        newBall = Instantiate(ballPrefab, startPos, Quaternion.identity) as GameObject;
        Debug.Log("respawned!!");
        justSpawned = true;

        startSound.Play();
        startSound.PlayDelayed(0.5f);

    }

    IEnumerator spawnDelay()
    {
        yield return new WaitForSeconds(2f); //doesn't work :( --------------toFix-------------- https://docs.unity3d.com/ScriptReference/WaitForSeconds.html
        //workaround for delayed spawning: can place a collider a bit far from the table hole so it gets destroyed a few seconds after it falls through the hole
        Debug.Log("waited");


    }
}