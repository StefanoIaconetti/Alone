using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class QuestManager : MonoBehaviour
{
    List<Quest> questList = new List<Quest>();

    public Tutorial tutorialQuest = new Tutorial();

    public string objective = "";
    public string activeQuest = "tutorial";

    public Text title;
    public Text step;

    void Start()
    {
        title = GameObject.Find("Canvas/QuestBox/Title").GetComponent<Text>();
        step = GameObject.Find("Canvas/QuestBox/CurrentStep").GetComponent<Text>();
        

        if (tutorialQuest.complete == false)
        {
            tutorialQuest.StartObjective();
        }

    }

    void Awake()
    {
        
    }


    void Update()
    {
       

    }


    //Adds a delay when the text plays
    public IEnumerator DelayQuest(string tempObjective)
    {
        yield return new WaitForSeconds(5f);

        switch (tempObjective)
        {
            case "tutorial":
                
                tutorialQuest.StartObjective();

                break;
        }
        yield return null;
    }

    public void CompleteObjective(string tempObjective)
    {
        objective = tempObjective;
        if (objective != "")
        {
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
