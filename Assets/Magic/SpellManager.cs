using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellManager : MonoBehaviour
{
    //Creates an object of playercontrols to handle xbox joysticks
    PlayerControls controls;

    void Awake()
    {
        //Grabs the PlayerControls
        controls = new PlayerControls();

        //When the player holds Left Bumper
        controls.APlayerMovement.LeftBumperHold.performed += ctx =>
        {

            Debug.Log("IsHolding");
           


        };


        //When the player holds Left Bumper
        controls.APlayerMovement.LeftBumperHold.canceled += ctx =>
        {
                Debug.Log("IsntHolding");
         


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