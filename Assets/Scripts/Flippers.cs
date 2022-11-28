using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flippers : MonoBehaviour
{

    public float restPosition = 0.0f;
    public float pressedPosition = 45.0f;
    public float hitStrenght;
    public float flipperDamper = 150.0f;

    public string controlName;

    HingeJoint hinge;

    AudioSource flipperSound;

    // Start is called before the first frame update
    void Start()
    {
        hinge = GetComponent<HingeJoint>();
        hinge.useSpring = true;

        flipperSound = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame.
    void Update()
    {

        JointSpring mySpring = new JointSpring();
        mySpring.spring = hitStrenght;
        mySpring.damper = flipperDamper;

        if (Input.GetAxis(controlName) == 1)
        {
            mySpring.targetPosition = pressedPosition;
            flipperSound.Play(); //sounds plays while pressed without stopping... --------------toFix--------------
        }

        else
            mySpring.targetPosition = restPosition;


        hinge.spring = mySpring;
        hinge.useLimits = true; 
    }
}
