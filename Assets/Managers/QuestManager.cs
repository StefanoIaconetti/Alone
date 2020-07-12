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
                    StopCoroutine(DelayQuest(objective));
                    StartCoroutine(DelayQuest(objective));
                    break;
            }
        }
    }


    public void GiveQuest()
    {

    }

}
