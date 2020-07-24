using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Terminal : MonoBehaviour
{
    //Hacking manager 
    HackingManager hackingManager;

    //Each terminal will have their own 4 digit code
    public string code = "0000";
    public int terminalNumber;
    public bool completed;

    void Awake()
    {
        //Finds the current Dialogue manager
        hackingManager = GameObject.Find("Managers/HackingManager").GetComponent<HackingManager>();
    }




    //When the player enters
    public void OnTriggerEnter(Collider character)
    {
        //The current name on the manager script is now this current npc
        if (character.gameObject.name == "Player")
        {
            hackingManager.isAccessing = true;
            hackingManager.currentTerminal = this;
        }
    }

    //When the player leaves
    public void OnTriggerExit(Collider character)
    {
        hackingManager.isAccessing = false;
        hackingManager.currentTerminal = null;
    }
}
