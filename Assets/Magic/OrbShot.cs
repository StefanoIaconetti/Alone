using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbShot : MonoBehaviour
{
    
    public GameObject orb;
    int amntOfOrbs = 2;
    public List<GameObject> orbShots;

    public static OrbShot SharedInstance;

    void Awake()
    {
        SharedInstance = this;
    }


    // Use this for initialization
    void Start()
    {
        //Making a list of orbs
        orbShots = new List<GameObject>();

        //Instantiating the orbs
        for (int i = 0; i < amntOfOrbs; i++)
        {
            GameObject obj = (GameObject)Instantiate(orb);
            obj.SetActive(false);
            orbShots.Add(obj);
        }

    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }


    //Grabbing the next available orb
    public GameObject GrabOrb(){
        //Going through the list
        for (int i = 0; i < orbShots.Count; i++) {
            if (!orbShots[i].activeInHierarchy)
            {
                return orbShots[i];
            }
        }
        return null;
    }
}
