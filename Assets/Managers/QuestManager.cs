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
        if (objective != "")
        {
            switch (objective)
            {
                case "tutorial":
                    tutorialQuest.StartObjective();
                    break;
            }
        }

    }
    public void GiveQuest()
    {

    }

}
