//Stefano Iaconetti
//Controller look
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerLook : MonoBehaviour
{
    //Creates a reference to the player controls script 
    PlayerControls controls;

    //Creates the sensitivity of the players look
    float controllerSensitivity = 100f;
    
    //Creates playerBody
    Transform playerBody;

    //Rotation x
    float rotationX = 0f;

    //The vector of look
    Vector3 look;


    QuestManager questManager;

    //Start method
    void Start(){
        //finds the transform of the Player object
       playerBody = transform.Find("/Player");
        //Grabs the quest manager
        questManager = GameObject.Find("Managers/QuestManager").GetComponent<QuestManager>();
    }
    
    //Awake method
    void Awake()
    {
        //Controls becomes an object of PlayerControls
        controls = new PlayerControls();
        
        //Right joystick movement (Xbox controller)
        controls.APlayerMovement.RightJoystickMovement.performed += ctx => look = ctx.ReadValue<Vector2>();
        controls.APlayerMovement.RightJoystickMovement.canceled += ctx => look = Vector3.zero;

          
    }

    // Update is called once per frame
    void Update()
    {
        //Calculating so the player can look left,right,up,down
        float controllerX = look.x * controllerSensitivity * Time.deltaTime;
        float controllerY = look.y * controllerSensitivity * Time.deltaTime;

        //Rotation x is -= to the controllerY from above
        rotationX -= controllerY;

        //Rotation x is limited to 90 so the player cannot flip
        rotationX = Mathf.Clamp(rotationX, -90f, 90f);

        //Allows the player to then turn
        transform.localRotation = Quaternion.Euler(rotationX, 0f, 0f);
        playerBody.Rotate(Vector3.up * controllerX);

        //If the tutorial quest isnt completed and they are on the 0 step
        if (questManager.tutorialQuest.complete == false && questManager.tutorialQuest.currentStep == 0 && (rotationX > 0 || rotationX < 0) && questManager.tutorialQuest.objectiveCompleted == false)
        {
            questManager.CompleteObjective("tutorial");

        }

    }

    //On Enable and disable for joystick movement
     void OnEnable()
    {
        controls.APlayerMovement.Enable();
    }

    void OnDisable()
    {
        controls.APlayerMovement.Disable();
    }

}