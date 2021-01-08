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

    //All the buttons that disable or enable depending
    public Button airButton;
    public Button fireButton;
    public Button earthButton;
    public Button waterButton;

    //The sphere on the staff so it can change materials
    public GameObject staffSphere;

    //All materials that will be used to chaange the staff and orb colours
    public Material airMaterial;
    public Material fireMaterial;
    public Material earthMaterial;
    public Material waterMaterial;

    //Check to see if the player is holding the hotbar button
    bool isHolding = false;

    //Grabs the orbshot script to allow us to change the pooled objects material
    public OrbShot orbShot;


    void Awake()
    {
        //Grabs the PlayerControls
        controls = new PlayerControls();

        //When the player holds Left Bumper
        controls.APlayerMovement.LeftBumperHold.performed += ctx =>
        {
            //Showing the player the hotbar, changing the event system and turning the buttons on
            isHolding = true;
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
            //Hiding the hotbar,changing the event system and turning the buttons off
            isHolding = false;
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


    //Update 
    void Update()
    {   //If the left bumper is held
        if (isHolding)
        {
            //Whatever the eventsystem is hovered over the colour of the staff changes
            currentButton = eventSystem.currentSelectedGameObject;
            changeColour();
        }
    }

    //Depending on what button is highlighted the staff changes and its orbshots
    void changeColour()
    {
        switch (currentButton.name)
        {
            case "Air":
                staffSphere.GetComponent<MeshRenderer>().material = airMaterial;
                orbShot.ChangeElement(airMaterial);
            break;

            case "Fire":
                staffSphere.GetComponent<MeshRenderer>().material = fireMaterial;
                orbShot.ChangeElement(fireMaterial);
                break;

            case "Earth":
                staffSphere.GetComponent<MeshRenderer>().material = earthMaterial;
                orbShot.ChangeElement(earthMaterial);
                break;

            case "Water":
                staffSphere.GetComponent<MeshRenderer>().material = waterMaterial;
                orbShot.ChangeElement(waterMaterial);
                break;
        }
    }

    //Turns the buttons on and off preventing the user to accidentally go to a button on another UI
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