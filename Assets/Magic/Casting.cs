using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Casting : MonoBehaviour
{

    //Creates an object of playercontrols to handle xbox joysticks
    PlayerControls controls;

    public GameObject elementalOrb;

    public GameObject bulletPrefab;
    //Position of barrel
    public Transform launchPosition;

    //Vector
    Vector3 objectPos;

    //Grabs the animator
    public Animator animator;

    void Start()
    {
        //Grabs the animator off of the DialogueBox
        animator = GameObject.Find("Player/Staff").GetComponent<Animator>();
    }

    void Awake()
    {
        //Grabs the PlayerControls
        controls = new PlayerControls();

        //When the player holds X
        controls.APlayerMovement.RTButtonPress.performed += ctx =>
        {
            IsCasting();
        };

    }



    void IsCasting()
    {


        GameObject bullet = OrbShot.SharedInstance.GetPooledObject();

        if (bullet != null)
        {
            bullet.transform.position = launchPosition.position;

            bullet.SetActive(true);
            bullet.GetComponent<Rigidbody>().velocity = transform.parent.forward * 100;

        }









        animator.SetTrigger("canCast");

    }
        //On Enable and disable for button presses
        void OnEnable()
    {
        controls.APlayerMovement.Enable();
    }

    void OnDisable()
    {
        controls.APlayerMovement.Disable();
    }
}
