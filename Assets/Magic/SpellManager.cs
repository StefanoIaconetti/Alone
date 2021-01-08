using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SpellManager : MonoBehaviour
{
    //Creates an object of playercontrols to handle xbox joysticks
    PlayerControls controls;
    public CanvasGroup SpellHotBar;
    public GameObject currentButton;
    public EventSystem eventSystem;
    public GameObject eventSystemDisable;
    public GameObject MainEventSystem;

    Button airButton;
    Button fireButton;
    Button earthButton;
    Button waterButton;


    void Awake()
    {
        //Grabs the PlayerControls
        controls = new PlayerControls();

        //When the player holds Left Bumper
        controls.APlayerMovement.LeftBumperHold.performed += ctx =>
        {
            MainEventSystem.active = false;
            eventSystemDisable.active = true;
            SpellHotBar.alpha = 1;

            //Eventsystem is now null so user can use other buttons
            eventSystem.SetSelectedGameObject(currentButton);
            Debug.Log("IsHolding");
        };

        //When the player lets go of the left bumper
        controls.APlayerMovement.LeftBumperHold.canceled += ctx =>
        {
            MainEventSystem.active = true;
            eventSystemDisable.active = false;
            SpellHotBar.alpha = 0;

            //Eventsystem is now null so user can use other buttons
            eventSystem.SetSelectedGameObject(null);
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