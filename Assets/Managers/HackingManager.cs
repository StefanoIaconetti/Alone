using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;
using System.IO;
using UnityEngine.EventSystems;

public class HackingManager : MonoBehaviour
{
    //Journal varibles
    public GameObject journal;
    public Text journalName;
    public Text journalText;
    public Text journalPage;

    //Creating an object of xmlReader
    XMLReader xmlReader = new XMLReader();


    int pageNumber = 1;

    //Text
    Text code;

     //Grabs the canvas ground of the terminal
     CanvasGroup terminalPanel;
    CanvasGroup journalPanel;

    //Checks to see if the user is accessing
    public bool isAccessing;
    
    //Creates an object of playercontrols to handle xbox joysticks
    PlayerControls controls;

    //Array of buttons
    public Button[] buttonList;

    //Gameobject of the first button to set it
    GameObject button;

    //This array will hold the code at all times
    string arrayToString = "0000";

    //Will be set when the player moves into the terminal
    public string codeSolution;

    //Grabs the playermovement script
    PlayerMovement playerMovement;

    //Will update depending on which input they are putting in
    int inputNumber = 0;

    //Will hold an array of chars
    char[] charArray;

    public Terminal currentTerminal;

    //Name of the file that the journal is on
    string fileLoadName = @"JournalXML";

    //Creates a text asset 
    TextAsset xmlFile;

    //Grabs the name and the line
    protected string[] lineName;
    string data;



    // Start is called before the first frame update
    void Start()
    {
        //Loading the xml file as a textAsset
        var fileRead = (TextAsset)Resources.Load(fileLoadName);

        //xmlFile is now the textasset
        xmlFile = fileRead;

        //Grabs the canvas group of the journal
        journalPanel = GameObject.Find("Canvas/Journal").GetComponent<CanvasGroup>();

        //Grabs the canvas group of the hacking terminal
        terminalPanel = GameObject.Find("Canvas/HackingTerminal").GetComponent<CanvasGroup>();
        
        //Grabs the first button of the canvas
        button = GameObject.Find("Canvas/HackingTerminal/Panel/Button1");

        //Grabs the code Text 
        code = GameObject.Find("Canvas/HackingTerminal/CodeText").GetComponent<Text>();

        //Grabs the player movement so he cant move during dialogue
        playerMovement = GameObject.Find("Player").GetComponent<PlayerMovement>();

        
        //The data is now the xml.text
        data = xmlFile.text;
    }

    void Awake()
    {
        //Grabs the PlayerControls
        controls = new PlayerControls();

        //When the player holds X
        controls.APlayerMovement.XButtonHold.performed += ctx =>
        {
            if (currentTerminal.completed == false){
                //If the player holds X then the hacking menu opens
                if (ctx.interaction is HoldInteraction && isAccessing)
                {
                    StartStopMoving(true);
                }
            }
            else
            {

                StartStopMoving(true);
            }

        };

        //When the player presses b
        controls.APlayerMovement.RightDPad.performed += ctx => {

            if (currentTerminal.completed == true)
            {
                PageChange(true);
            }

        };

        //When the player presses b
        controls.APlayerMovement.LeftDPad.performed += ctx => {

            if (currentTerminal.completed == true)
            {
                PageChange(false);
            }

        };


        //When the player presses b
        controls.APlayerMovement.BButtonPress.performed += ctx => {

            //If the player holds B then the dhacking menu dissapears
            if (ctx.interaction is TapInteraction && isAccessing)
            {
                StartStopMoving(false);
            }

        };
    }

    //Whenever a button is pressed on the hacking menu then this is called
    public void HackingButtonPress(int number)
    {  
        //Goes through the only possible options
        switch (number)
        {
            //If the button 1 is pressed then that means the user is attempting to backspace
            case 10:
                InputNumber('1', true);
                break;
            case 11:
                Access();
                break;
                //
            default:
                //If 10 or 11 werenot inputted then the user is puting a number attempting to solve
                char converted = ConvertIntToChar(number);
                InputNumber(converted, false);
               break;

        }
    }

    //Will open and close the hacking menu 
    public void StartStopMoving(bool openClose)
    {
        //If the user closes the menu
        if (openClose == false)
        {
            //Menu dissapears
            terminalPanel.alpha = 0;

            journalPanel.alpha = 0;

            //Player cannow move
            playerMovement.enabled = true;
            
            //Eventsystem is now null so user can use other buttons
            EventSystem.current.SetSelectedGameObject(null);
            
            //Disables the buttons
            EnableDisable(buttonList, false);

            //Resets the code attempts
            Reset();
        }
        else
        {
            //If the user opens the menu then the first button is set to the eventsystem
            EventSystem.current.SetSelectedGameObject(button);

            if(currentTerminal.completed == false)
            {
                //Menu appears
                terminalPanel.alpha = 1;
            }
            else
            {
                journalPanel.alpha = 1;
                PageChange(true);
            }

            //User cant move
            playerMovement.enabled = false;

            //Enables the buttons
            EnableDisable(buttonList, true);
            pageNumber = 0;
        }
    }

        //Depending on if the user is closing or opening the menu
        void EnableDisable(Button[] buttons, bool offOn)
        {
            foreach(Button interButton in buttons)
            {
            //If they opened the menu the buttons become active
                if (offOn)
                {

                    interButton.interactable = true;
                }
                //Otherwise they are false
                else
                {

                    interButton.interactable = false;
                }
            }
        }



    //Reset will reset the previous input
    void Reset()
    {
        //Loops through the array setting all values to 0
        for (int i = 0; i < charArray.Length; i++)
        {
            charArray[i] = '0';
        }
        //Input number is reset to 0
        inputNumber = 0;
        //Array is set to 0000 and the ui is aswell 
        arrayToString = "0000";
        code.text = arrayToString;
    }

     //Method that accepts the numbers given by the user
     void InputNumber(char input, bool backSpace){

        //char array grabs the string and makes it into chars
        charArray = arrayToString.ToCharArray();


        //If the user is removing numbers
        if (backSpace)
        {
           //As long as they are not at the first digit the input number decreases 
            if (inputNumber != 0)
            {
                charArray[inputNumber - 1] = '0';
                inputNumber--;
            }
            //If they are on input number 0 then the charaacter is only changed 
            else
            {
                charArray[inputNumber] = '0';
            }
        }
        //If the user is inputting numbers
        else
        {
            //Switch case depending on if they are inputting the first, second, third or fourth number
            switch (inputNumber)
            {
                //Depending on the number a different character in the array is changed with the number the user chose
                case 0:
                    charArray[0] = input;
                    inputNumber++;
                    break;
                case 1:
                    charArray[1] = input;
                    inputNumber++;
                    break;
                case 2:
                    charArray[2] = input;
                    inputNumber++;
                    break;
                case 3:
                    charArray[3] = input;
                    inputNumber++;
                    break;
            }
        }
             //Array is set to nothing
             arrayToString = "";
        
        //Array is now changed to what the charArray had
            foreach (char character in charArray)
            {
                arrayToString += character + "";
            }
            //Ui text is changed to the new array
            code.text = arrayToString;
    }

    //Will check if the terminal will open
    void Access(){
        if (arrayToString.Equals(currentTerminal.code)){
            //If the answer is correct then something will happen
            terminalPanel.alpha = 0;
            currentTerminal.completed = true;

            StartStopMoving(true);
        }

    }
    
    //Char conversion
    char ConvertIntToChar(int character)
    {
        char returnVar = 'l';
        
        //Depending on the character given a char is replaced and returned
        switch (character)
        {
            case 0:
                returnVar = '0';
                break;
            case 1:
                returnVar = '1';
                break;
            case 2:
                returnVar = '2';
                break;
            case 3:
                returnVar = '3';
                break;
            case 4:
                returnVar = '4';
                break;
            case 5:
                returnVar = '5';
                break;
            case 6:
                returnVar = '6';
                break;
            case 7:
                returnVar = '7';
                break;
            case 8:
                returnVar = '8';
                break;
            case 9:
                returnVar = '9';
                break;

        }

        return returnVar;
    }

    

    void PageChange(bool turn)
    {

        lineName = xmlReader.parseXml(data, currentTerminal.journalName);


        if (turn && pageNumber < 2)
        {
            Debug.Log("Increase");
            pageNumber++;
        }else if (turn == false && pageNumber > 0){
            Debug.Log("Increase");
            pageNumber--;
        }

        Debug.Log(pageNumber);
        switch (pageNumber)
        {
            case 1:

                journalText.text = lineName[1];
                break;

            case 2:
                Debug.Log("Worked");
                journalText.text = lineName[2];
                break;
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
