using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : Quest
{
    QuestManager manager;
   

    public Tutorial()
    {
         description = "Lets learn the basics";
           title = "Tutorial";
        currentStep = 0;
         currentObjective = "";
         objectiveCompleted = false;
         complete = false;
    }


    void Start()
    {
        manager = GameObject.Find("Managers/QuestManager").GetComponent<QuestManager>();
    }
    
    public void StartObjective()
    {
        manager = GameObject.Find("Managers/QuestManager").GetComponent<QuestManager>();

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
        
        if (manager.activeQuest == "tutorial")
        {
            manager.title.text = title;
            manager.step.text = currentObjective;
        }
    }



    void JumpStep()
    {
        currentObjective = "Jump by pressing the A button";
        
        if (objectiveCompleted == true)
        {
            objectiveCompleted = false;
            currentStep = 3;
        }


    }

    void LookStep()
    {
        currentObjective = "Look by using the right analog stick";

        if (objectiveCompleted == true)
        {
            objectiveCompleted = false;
            currentStep = 1;
        }
    }

    void MoveStep()
    {

        currentObjective = "Move by using the left analog stick";

        if (objectiveCompleted == true)
        {
            objectiveCompleted = false;
            currentStep = 2;
        }

    }

    void TalkStep()
    {
        currentObjective = "Talk to someone by holding the x button";

        if (objectiveCompleted == true)
        {
            objectiveCompleted = false;
            currentStep = 4;
            StartObjective();
        }
    }

    new public void EndQuest()
    {
        currentObjective = "Quest Complete!";
        complete = true;
    }

    
}
