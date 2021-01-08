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
        animator = GameObject.Find("Player/Camera/Staff").GetComponent<Animator>();
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



    void IsCasting(){

        GameObject orb = OrbShot.SharedInstance.GrabOrb();
        if (orb != null) {

            if (orb != null) {
                orb.transform.position = launchPosition.position;

                orb.SetActive(true);
                orb.GetComponent<Rigidbody>().velocity = transform.parent.forward * 100;

            }
            animator.SetTrigger("canCast");

            StopCoroutine(DelayInactive(orb));
            StartCoroutine(DelayInactive(orb));
        }
    }


    //Adds a delay when the text plays
    public IEnumerator DelayInactive(GameObject orb)
    {
        //Waits for 5 seconds
        yield return new WaitForSeconds(3f);

        orb.SetActive(false);


        yield return null;
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
