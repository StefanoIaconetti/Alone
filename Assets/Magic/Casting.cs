using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Casting : MonoBehaviour
{



    //Creates an object of playercontrols to handle xbox joysticks
    PlayerControls controls;

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
            Debug.Log("Cast");
            animator.SetTrigger("canCast");
            //animator.SetBool("canCast", false);
        };

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
