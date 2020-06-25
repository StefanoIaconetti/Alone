using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;
public class PlayerMovement : MonoBehaviour
{
    //Regular jump height
    const float constJumpHeight = 3f;

    //Creates an object of playercontrols to handle xbox joysticks
    PlayerControls controls;

    //Creates a character controller
    CharacterController charController;

    //Vector3 that holds the players movement
    Vector3 move;

    //Boolean that allows the player to jump or not
    private bool jump;

    //Speed of the player
     float speed = 12f;

    //Float of the player moving front to back
    float movingFrontBack;

    //Float of the player moving left to right
    float movingLeftRight;

    //Players jump height
     float jumpHeight = 3f;

    //Grabs the velocity of the player
    Vector3 velocity;

    //Gravity of the player when jumping/falling
    float gravity = -9.81f;

    public GameObject currentInteractionItem;

    QuestManager questManager;

    //Start method
    void Start(){
        //Grabs the CharacterController from the player object
        charController = GameObject.Find("/Player").GetComponent<CharacterController>();

        //Grabs the quest manager
        questManager = GameObject.Find("Managers/QuestManager").GetComponent<QuestManager>();
    }

    //Awake method
    void Awake()
    {
        //Grabs the PlayerControls
        controls = new PlayerControls();

        //Creates movement using the left joystick
        controls.APlayerMovement.LeftJoystickMovement.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.APlayerMovement.LeftJoystickMovement.canceled += ctx => move = Vector3.zero;

        //When the player jumps
        controls.APlayerMovement.AButtonPress.performed += ctx =>{

            //If the player holds the jump button then their height is greater than if it was a tap
            if(ctx.interaction is HoldInteraction){
                if (charController.isGrounded) { 
                    jump = true;
                    jumpHeight *= jumpHeight;
                }
                if (questManager.tutorialQuest.complete == false && questManager.tutorialQuest.currentStep == 2)
                {
                    questManager.tutorialQuest.objectiveCompleted = true;
                    questManager.objective = "tutorial";
                }
            }
            else{
                if (charController.isGrounded)
                {
                    //If they do not hold the button then they are just jumping the normal height
                    jump = true;
                }

                if (questManager.tutorialQuest.complete == false && questManager.tutorialQuest.currentStep == 2)
                {
                    questManager.tutorialQuest.objectiveCompleted = true;
                    questManager.objective = "tutorial";
                }
            }

        }; 




    }

    //Update method
    void Update()
    {
        //Checks to see if the player is grounded and their velocity is less than 0
        if(charController.isGrounded && velocity.y < 0)
        {   
            velocity.y = -2f;
        }

        //If the player has pressed the jump button and they are on the ground
        if(jump && charController.isGrounded)
        {   
            //Velocity increases
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
            //They are then not allowed to jump again
            jump = false;

            //Jumpheight is now back to normal jump height (This is incase they hold)
            jumpHeight = constJumpHeight;
        }

        //Grabs the input for vertical and moves the player frontwards and backwards
        movingFrontBack = move.x;

        //Grabs the input for horizontal and moves the player left and right
        movingLeftRight = move.y;

        Vector3 movement = transform.right * movingFrontBack + transform.forward * movingLeftRight;
        charController.Move(movement * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        charController.Move(velocity * Time.deltaTime);

        if (questManager.tutorialQuest.complete == false && questManager.tutorialQuest.currentStep == 1 && movingFrontBack > 0)
        {
            questManager.tutorialQuest.objectiveCompleted = true;
            questManager.objective = "tutorial";
        }


    }

    //Enable and disable for controller
    void OnEnable()
    {
        controls.APlayerMovement.Enable();
    }

    void OnDisable()
    {
        controls.APlayerMovement.Disable();
    }
}