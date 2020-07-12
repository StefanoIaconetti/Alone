using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    //Name of the NPC
    public string NPCname = "";

    //Dialogue managar
    DialogueManager dialogueManager;

    //Playermovement script
    PlayerMovement playerMovement;

    public NPCType npcType;


    public string choice1;
    public string choice2;
    public string choice3;

    public void Awake()
    {
        //Finds the current Dialogue manager
        dialogueManager = GameObject.Find("Managers/DialogueManager").GetComponent<DialogueManager>();

        //Grabs the player movement so he cant move during dialogue
        playerMovement = GameObject.Find("Player").GetComponent<PlayerMovement>();
    }



    //When the player enters
    public void OnTriggerEnter(Collider character)
    {
        //The current name on the manager script is now this current npc
        if (character.gameObject.name == "Player")
        {
            dialogueManager.currentNPC = this;
        }
    }

    //When the player leaves
    public void OnTriggerExit(Collider character)
    {
            ExitReset();

            dialogueManager.StartStopMoving(false);
    }

    //Resets the currentNPC
    public void ExitReset()
    {
        dialogueManager.currentNPC = null;
    }

    //There are 2 different types of npcs
    public enum NPCType
    {
        NPC,
        QuestGiver
    }
}
