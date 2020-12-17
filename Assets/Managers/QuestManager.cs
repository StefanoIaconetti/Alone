using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class QuestManager : MonoBehaviour
{
    //Users list of the quests
    List<Quest> questList = new List<Quest>();

    //Creates a tutorial quest object
    public Tutorial tutorialQuest = new Tutorial();

    //Users objective
    public string objective = "";
    //Users current quest
    public string activeQuest = "tutorial";

    //Title and stepin the ui
    public Text title;
    public Text step;

    public Image questStepChange;

    //For the congrtulations screen
    public Text congratDesc;
    public CanvasGroup congrats;

    void Start()
    {
        //Sets the title and step
        title = GameObject.Find("Canvas/QuestBox/Title").GetComponent<Text>();
        step = GameObject.Find("Canvas/QuestBox/CurrentStep").GetComponent<Text>();
        
        //If the user loads in and they havent completed the tutorial then start it
        if (tutorialQuest.complete == false)
        {
            tutorialQuest.StartNewObjective();
        }

    }
    //Adds a delay when the text plays
    public IEnumerator DelayQuest(string tempObjective)
    {
        //Waits for 5 seconds
        yield return new WaitForSeconds(5f);

        //Switch case through the quests
        switch (tempObjective)
        {
            case "tutorial":
                //FFFFFF
                 questStepChange.color = new Color32(255, 255, 255, 255);
                tutorialQuest.StartNewObjective();

                break;
        }



        yield return null;
    }


    //Complete objective accepts the objective 
    public void CompleteObjective(string tempObjective)
    {
        objective = tempObjective;
        if (objective != "")
        {
            //Goes through the respective quests
            switch (objective)
            {
                case "tutorial":
                    tutorialQuest.objectiveCompleted = true;
                    questStepChange.color = new Color32(0, 230, 118, 255);
                    StopCoroutine(DelayQuest(objective));
                    StartCoroutine(DelayQuest(objective));
                    break;
            }
        }
    }



    //Adds a delay when the text plays
    public IEnumerator CongratulationTimer()
    {
        //Waits for 5 seconds
        yield return new WaitForSeconds(5f);
        congrats.alpha = 0;

        yield return null;
    }

    public void QuestCompleted(string tempObjective)
    {
        //Switch case through the quests
        switch (tempObjective)
        {
            case "tutorial":

               

                congratDesc.text = tutorialQuest.congratsDesc;
                    congrats.alpha = 1;
                
                    StopCoroutine(CongratulationTimer());
                    StartCoroutine(CongratulationTimer());
                break;
        }
    }
    


    public void GiveQuest()
    {

    }

}
