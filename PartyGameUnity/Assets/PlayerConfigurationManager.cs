using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Linq;
using UnityEngine.SceneManagement;

//In charge of player configurations (playerNum, appearance, what buttons they pressed
public class PlayerConfigurationManager : MonoBehaviour
{
    private List<PlayerConfiguration> PlayerConfigs; //List of Players

    [SerializeField]
    private int MaxPlayers = 2;

    //Use singleton to assure this class will exist in any scene and there will only be one
    public static PlayerConfigurationManager Instance { get; private set; }

    private void Awake()
    {
      if(Instance != null)
        {
            Debug.Log("Creating an Instance");
        }
      else
        {
            Instance = this; //Makes this object the only one in existence
            DontDestroyOnLoad(Instance); //keeps object from beiung destroyed across scenes
            PlayerConfigs = new List<PlayerConfiguration>();
        }
    }
    public void SetPlayerColor(int index, Material Color)
    {
        PlayerConfigs[index].PlayerMaterial = Color;
    }

    public void ReadyPlayer(int index)
    {
        PlayerConfigs[index].isReady = true;
        if(PlayerConfigs.Count == MaxPlayers && PlayerConfigs.All(p => p.isReady ==true)) //if we have all the players and they are ready
        {
            SceneManager.LoadScene("Multiplayer Scene");
        }
    }


}

//Sub class to store player data
public class PlayerConfiguration
{
    public PlayerConfiguration(PlayerInput pi)
    {
        PlayerIndex = pi.playerIndex;
        Input = pi;
    }

    public PlayerInput Input { get; set; } //Input of player object
    public int PlayerIndex { get; set; } //Player 1, Player 2, etc.
    public bool isReady { get; set; } //Is player ready to play?
    public Material PlayerMaterial {get; set;} // Player Color (will be changed when assets are available
}
