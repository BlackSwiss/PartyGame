using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class buttonExmaple : MonoBehaviour {

    string[] joystickArray = new string[]{"Joystick Button 0", "Joystick Button 1", "Joystick Button 2",
    "Joystick Button 3","Joystick Button 4","Joystick Button 5"};
    string[] ex = new string[] { "1", "2", "3", "4" };

    System.Random r = new System.Random();

    

    public KeyCode key;

    private Button button;

    int count = 0;

    private void Awake()
    {
        //ex = ex.OrderBy(x => r.Next()).ToArray();
       // Debug.Log(ex[0]);
        button = GetComponent<Button>();
        /*joystickArray.Shuffle();
        Debug.Log(joystickArray[0]);
        */

        joystickArray = joystickArray.OrderBy(x => r.Next()).ToArray();
        Debug.Log(joystickArray[0]);
    }


    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        
        if (Input.GetButtonDown(joystickArray[0]))
        {
            count++;
            button.onClick.Invoke();
             Debug.Log("Pressed " + count);
            //Debug.Log(joystickArray[0]);
            joystickArray = joystickArray.OrderBy(x => r.Next()).ToArray();
            Debug.Log(joystickArray[0]);

        }
	}

}
