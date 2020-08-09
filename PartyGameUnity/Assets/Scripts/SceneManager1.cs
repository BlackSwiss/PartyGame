using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager1 : MonoBehaviour
{

    public void OnButtonClicked()
    {
        SceneManager.LoadScene("Scene1");
    }
}
