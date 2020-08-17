using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countdownScript : MonoBehaviour
{
    //Types of treadmills
    private GameObject[] treadmillFoward;

    private GameObject[] treadmillBackward;

    //Types of materials
    public Material materialF;
    public Material materialB;

    //Timer for switching directions
    public float currentTime = 0;
    public float startingTime = Random.Range(0.5f,7f);

    public Text countdown;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        //Count down by 1 second
        currentTime -= 1 * Time.deltaTime;
        countdown.text = "Countdown until switch: " + currentTime.ToString("0");
        //Once it hits 0
        if (currentTime <= 0)
        {
            //Set time back
            currentTime = Random.Range(0.5f, 7f);

            //find every treadmill
            treadmillFoward = GameObject.FindGameObjectsWithTag("Treadmill");
            treadmillBackward = GameObject.FindGameObjectsWithTag("TreadmillB");

            //Switch tags
            foreach(GameObject item in treadmillFoward)
            {
                item.gameObject.tag = "TreadmillB";
                item.gameObject.GetComponent<MeshRenderer>().material = materialB;
            }
            foreach (GameObject item in treadmillBackward)
            {
                item.gameObject.tag = "Treadmill";
                item.gameObject.GetComponent<MeshRenderer>().material = materialF;
            }

        }
    }
}
