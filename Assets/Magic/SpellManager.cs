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

    public Button airButton;
    public Button fireButton;
    public Button earthButton;
    public Button waterButton;


    void Awake()
    {
        //Grabs the PlayerControls
        controls = new PlayerControls();

        //When the player holds Left Bumper
        controls.APlayerMovement.LeftBumperHold.performed += ctx =>
        {
            ButtonOnOff(true);
            MainEventSystem.active = false;
            eventSystemDisable.active = true;
            SpellHotBar.alpha = 1;

            //Eventsystem is now null so user can use other buttons
            eventSystem.SetSelectedGameObject(currentButton);
        };

        //When the player lets go of the left bumper
        controls.APlayerMovement.LeftBumperHold.canceled += ctx =>
        {
            ButtonOnOff(false);
            MainEventSystem.active = true;
            eventSystemDisable.active = false;
            SpellHotBar.alpha = 0;

            //Eventsystem is now null so user can use other buttons
            eventSystem.SetSelectedGameObject(null);

            //Quick bug fix, the event system stopped working and turning it off and on seemed to be a work around when using multiple event systems
            MainEventSystem.active = false;
            MainEventSystem.active = true;


        };


    }

    void ButtonOnOff(bool onOff)
    {
        if (onOff)
        {
            airButton.interactable = true;
            fireButton.interactable = true;
            earthButton.interactable = true;
            waterButton.interactable = true;
        }
        else
        {
            airButton.interactable = false;
            fireButton.interactable = false;
            earthButton.interactable = false;
            waterButton.interactable = false;
        }
        
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