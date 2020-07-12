using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : Quest
{

    //Quest manager
    QuestManager manager;
   
    //Tutorial values are set
    public Tutorial()
    {
         description = "Lets learn the basics";
           title = "Tutorial";
        currentStep = 0;
         currentObjective = "";
         objectiveCompleted = false;
         complete = false;
    }

    //Finds the quest manager
    void Start()
    {
        manager = GameObject.Find("Managers/QuestManager").GetComponent<QuestManager>();
    }
    
    //Checks the current step and sets it
    public void StartNewObjective()
    {
        manager = GameObject.Find("Managers/QuestManager").GetComponent<QuestManager>();

        //Finds what step the user is on and calls its respective method
        switch (currentStep)
        {
            case 0:
                LookStep();
                break;
            case 1:
                MoveStep();
                break;
            case 2:
                JumpStep();
                break;
            case 3:
                TalkStep();
                break;
            case 4:
                EndQuest();
                break;
        }
        
        //As long as the current active quest is tutorial itsinformation is displayed and updated
        if (manager.activeQuest == "tutorial")
        {
            manager.title.text = title;
            manager.step.text = currentObjective;
        }
    }


    //When the user jumps
    void JumpStep()
    {
        currentObjective = "Jump by pressing the A button";
        
        if (objectiveCompleted == true)
        {
            objectiveCompleted = false;
            currentStep = 3;
            StartNewObjective();
        }


    }

    //When the user looks using the right thumbstick
    void LookStep()
    {
        currentObjective = "Look by using the right analog stick";

        if (objectiveCompleted == true)
        {
            objectiveCompleted = false;
            currentStep = 1;
            StartNewObjective();
        }
    }

    //When the user moves using the left thumbstick 
    void MoveStep()
    {

        currentObjective = "Move by using the left analog stick";

        if (objectiveCompleted == true)
        {
            objectiveCompleted = false;
            currentStep = 2;
            StartNewObjective();
        }

    }

    //When the user talk to a npc
    void TalkStep()
    {
        currentObjective = "Talk to someone by holding the x button";

        if (objectiveCompleted == true)
        {
            objectiveCompleted = false;
            currentStep = 4;
            StartNewObjective();
        }
    }

    //Quest is ended
    new public void EndQuest()
    {
        currentObjective = "Quest Complete!";
        complete = true;
    }

}
