using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;

public class Throwable : MonoBehaviour
{
    //Force is the strength at which it is thrown
    float force = 1000;
    
    //Vector
    Vector3 objectPos;

    //Distance at which the place would be in range to grab the object
    float distance;

    //Object that represents where the player is looking
    GameObject objectPlacement;

    //Checks if the player is holding the ball
    bool isHolding = false;

    //Permission for the player to throw
    bool nowThrow;

    //Check to see if the ball has been grabbed
    bool isGrabbed;

    //Creates an object of playercontrols to handle xbox joysticks
    PlayerControls controls;

    // Start is called before the first frame update
    void Start(){
        //Rigidbodys gravity is false one grabbed
        this.GetComponent<Rigidbody>().useGravity = false;

        //Finds the object that represents where the player is holding
        objectPlacement = GameObject.Find("Player/Camera/ObjectPlacement");
    }

    // Update is called once per frame
    void Update(){
        //Grabs the distance from the player to the object
        distance = Vector3.Distance(this.gameObject.transform.position, objectPlacement.transform.position);

        //If the distance is more than 4 then the player cannot hold
        if(distance >= 4f){
            isHolding = false;
        }

        //If isHolding is true
        if (isHolding == true){

            //The velocity is set to Vector3.zero
            this.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;

            //Object is now placed where the objectPlacement gameobject it
            this.gameObject.transform.SetParent(objectPlacement.transform);

            //If nowThrow is true
            if (nowThrow == true){
                //Force is added to the object
                this.gameObject.GetComponent<Rigidbody>().AddForce(objectPlacement.transform.forward * force);

                //Isholding and nowthrow are now false
                isHolding = false;
                nowThrow = false;
            }
            //If the ball is let go
        }else{
            //The vector3 is now the gameobjects position
            objectPos = this.gameObject.transform.position;
            //The objects parent is no longer the player
            this.gameObject.transform.SetParent(null);
            //Gravity is back on
            this.gameObject.GetComponent<Rigidbody>().useGravity = true;
            //Position of the gameobject is now the vector
            this.gameObject.transform.position = objectPos;
        }
    }


    void Awake(){
        //Grabs the PlayerControls
        controls = new PlayerControls();

        //When the holds x to pick up
        controls.APlayerMovement.XButtonHold.performed += ctx => {

            if (ctx.interaction is HoldInteraction){
                //If the distance is less than 4 meaning it is in range
                if (distance <= 4f){
                    //Its now holding the object
                    isHolding = true;

                    //Gravity is turned off but the ball now detects collisions so it does not go through walls
                    this.gameObject.GetComponent<Rigidbody>().useGravity = false;
                    this.gameObject.GetComponent<Rigidbody>().detectCollisions = true;

                    
                }
            }
        };

        //If the player taps RT while they are holding the object
        controls.APlayerMovement.RTButtonPress.performed += ctx =>{
            if (isHolding == true && ctx.interaction is TapInteraction){
                //Player can now throw
                nowThrow = true;
            }
        };
       }

    //On Enable and disable for joystick movement
    void OnEnable(){
        controls.APlayerMovement.Enable();
    }

    void OnDisable(){
        controls.APlayerMovement.Disable();
    }
}
