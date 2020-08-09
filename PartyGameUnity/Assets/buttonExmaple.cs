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

    public GameObject[] buttonPics = new GameObject[] { };

    public GameObject currentButton;

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
        //Display first button
        switch (joystickArray[0])
        {
            case "Joystick Button 0":
                currentButton = buttonPics[0];
                currentButton.SetActive(true);
                break;

            case "Joystick Button 1":
                currentButton = buttonPics[1];
                currentButton.SetActive(true);
                break;

            case "Joystick Button 2":
                currentButton = buttonPics[2];
                currentButton.SetActive(true);
                break;

            case "Joystick Button 3":
                currentButton = buttonPics[3];
                currentButton.SetActive(true);
                break;

            case "Joystick Button 4":
                currentButton = buttonPics[4];
                currentButton.SetActive(true);
                break;

            case "Joystick Button 5":
                currentButton = buttonPics[5];
                currentButton.SetActive(true);
                break;
        }

        Debug.Log(joystickArray[0]);
    }


    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown(joystickArray[0]))
        {
            currentButton.SetActive(false);

            count++;
            button.onClick.Invoke();
            Debug.Log("Pressed " + count);
            
            joystickArray = joystickArray.OrderBy(x => r.Next()).ToArray();
            Debug.Log(joystickArray[0] + " " + count);
            switch (joystickArray[0])
            {
                case "Joystick Button 0":
                    currentButton = buttonPics[0];
                    currentButton.SetActive(true);
                    break;

                case "Joystick Button 1":
                    currentButton = buttonPics[1];
                    currentButton.SetActive(true);
                    break;

                case "Joystick Button 2":
                    currentButton = buttonPics[2];
                    currentButton.SetActive(true);
                    break;

                case "Joystick Button 3":
                    currentButton = buttonPics[3];
                    currentButton.SetActive(true);
                    break;

                case "Joystick Button 4":
                    currentButton = buttonPics[4];
                    currentButton.SetActive(true);
                    break;

                case "Joystick Button 5":
                    currentButton = buttonPics[5];
                    currentButton.SetActive(true);
                    break;
            }
        }
    }

}
