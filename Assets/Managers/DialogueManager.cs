using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;
using System.IO;
using UnityEngine.EventSystems;

public class DialogueManager : MonoBehaviour
{

    //Texts holding the dialogue and name
    Text dialogue;
    Text nameDialogue;

    //Texts that will update depending on the npc that the player walks into 
    Text choice1Text;
    Text choice2Text;
    Text choice3Text;


    public NPC currentNPC;

    public NPC.NPCType npcType;

    GameObject choice;

    //Creating an object of xmlReader
    XMLReader xmlReader = new XMLReader();
    
    //The current line of the user
    string line;

    //Creates an object of playercontrols to handle xbox joysticks
    PlayerControls controls;

    //Creates a text asset 
     TextAsset xmlFile;

    //Grabs the name and the line
    protected string[] lineName;
    string data;

    //Grabs the animator
    public Animator animator;

    //Grabs the playermovement script
    PlayerMovement playerMovement;

    QuestManager questManager;

    //Name of the file that the dialogue and names are on
    string fileLoadName = @"ScriptXML";

        // Start is called before the first frame update
        void Start(){

        //Loading the xml file as a textAsset
        var fileRead = (TextAsset)Resources.Load(fileLoadName);
        
        //xmlFile is now the textasset
        xmlFile = fileRead;

        //Finds the corresponding game object and gets the text script off of them so it can be updated 
        dialogue = GameObject.Find("Canvas/DialogueBox/Dialogue").GetComponent<Text>();
        nameDialogue = GameObject.Find("Canvas/DialogueBox/NameBox").GetComponent<Text>();

        //Grabs the animator off of the DialogueBox
        animator = GameObject.Find("Canvas/DialogueBox").GetComponent<Animator>();

        //Grabs the player movement so he cant move during dialogue
        playerMovement = GameObject.Find("Player").GetComponent<PlayerMovement>();

        //Grabs the 3 texts from the buttons so everytime the player has different options when talking to different characters
        choice1Text = GameObject.Find("Canvas/DialogueBox/DialogueOptions/Option1/Text").GetComponent<Text>();
        choice2Text = GameObject.Find("Canvas/DialogueBox/DialogueOptions/Option2/Text").GetComponent<Text>();
        choice3Text = GameObject.Find("Canvas/DialogueBox/DialogueOptions/Option3/Text").GetComponent<Text>();

        choice = GameObject.Find("Canvas/DialogueBox/DialogueOptions/Option1");

        //Grabs the quest manager
        questManager = GameObject.Find("Managers/QuestManager").GetComponent<QuestManager>();

        //The data is now the xml.text
        data = xmlFile.text;
    }

    //Awake method
    void Awake(){
        //Grabs the PlayerControls
        controls = new PlayerControls();
        
        //When the player holds X
        controls.APlayerMovement.XButtonHold.performed += ctx => {

            //If the player holds X then the dialogue starts
            if (ctx.interaction is HoldInteraction && currentNPC != null)
            {
                //Calls triggered function which starts dialogue
                Triggered(0);

                if (questManager.tutorialQuest.complete == false && questManager.tutorialQuest.currentStep == 3)
                {
                    questManager.tutorialQuest.objectiveCompleted = true;
                    questManager.objective = "tutorial";
                }
            }

        };


        //When the player presses b
        controls.APlayerMovement.BButtonPress.performed += ctx => {

            //If the player holds B then the dialogue stops
            if (ctx.interaction is TapInteraction && currentNPC != null)
            {
                StartStopMoving(false);
            }

        };
    }


    //Adds a delay when the text plays
    public IEnumerator SentenceWrite(string sentence)
    {
        //Text is set to nothing
        dialogue.text = "";

        //Foreach loops through and adds a letter each time giving the effect
        foreach (char letter in sentence.ToCharArray())
        {
            dialogue.text += letter;
            yield return null;
        }
    }

    //When npc is triggered then make dialoge box show
    virtual public void Triggered(int option)
    {
        //Player cant move now
        playerMovement.enabled = false;

        //Switch case depending on the option pressed
        switch(option){
            //If its the first interaction
            case 0:
                //UI appears    
                StartStopMoving(true);
                //Sets the name and line

                lineName = xmlReader.parseXml(data, currentNPC.NPCname);
                nameDialogue.text = lineName[0];
                
                //Choices are set
                choice1Text.text = currentNPC.choice1;
                choice2Text.text = currentNPC.choice2;
                choice3Text.text = currentNPC.choice3;
                break;

            case 1:
                //Sets the name and line with option 1
                lineName = xmlReader.parseXml(data, currentNPC.NPCname + option);
                nameDialogue.text = lineName[0];
                break;

            case 2: 
                //Sets the name and line with option 2
                lineName = xmlReader.parseXml(data, currentNPC.NPCname + option);
                nameDialogue.text = lineName[0];
                break;

            case 3:
                //Sets the name and line with option 2
                lineName = xmlReader.parseXml(data, currentNPC.NPCname + option);
                nameDialogue.text = lineName[0];
                break;
        }
        //Stops the current coroutines
        StopAllCoroutines();
        StartCoroutine(SentenceWrite(lineName[1]));
    }
    
    //OnClicks for all 3 options
    public void Option1OnPress()
    {
        Triggered(1);
        if (npcType == NPC.NPCType.QuestGiver)
        {
            questManager.GiveQuest();
        }
    }

    public void Option2OnPress()
    {
        Triggered(2);
    }

    public void Option3OnPress()
    {
        Triggered(3);
        StartStopMoving(false);
    }

    //Function that changes the animation of the text box depending on the boolean given
    public void StartStopMoving(bool openClose)
    {
        //If false is given then the player can move and the text box is gone
        if(openClose == false)
        {
            EventSystem.current.SetSelectedGameObject(null);
            animator.SetBool("IsOpen", false);
            playerMovement.enabled = true;
        }
        else
        {
            EventSystem.current.SetSelectedGameObject(choice);
            //If its true then the player cant move and the text box appears
            animator.SetBool("IsOpen", true);
            playerMovement.enabled = false;
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
