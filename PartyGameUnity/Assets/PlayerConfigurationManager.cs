﻿using System.Collections;
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
    private int MaxPlayers = 2; //Maximum number of players

    //Use singleton instance variabele
    public static PlayerConfigurationManager Instance { get; private set; }

    private void Awake()
    {
        //Create singleton and Don't Destroy on Load
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
    //Customization of player colors
    public void SetPlayerColor(int index, Material Color)
    {
        PlayerConfigs[index].PlayerMaterial = Color;
    }

    //When all players are ready, load the scene we want
    public void ReadyPlayer(int index)
    {
        PlayerConfigs[index].isReady = true;
        if(PlayerConfigs.Count == MaxPlayers && PlayerConfigs.All(p => p.isReady ==true)) //if we have all the players and they are ready
        {
            SceneManager.LoadScene("Tron");
        }
    }

    //Handles player join
    public void HandlePlayerJoin(PlayerInput pi)
    {
        Debug.Log("Player joined: " + pi.playerIndex + 1);
        
        if(!PlayerConfigs.Any(p => p.PlayerIndex == pi.playerIndex)) // if player has not been added, add player
        {
            pi.transform.SetParent(transform);
            PlayerConfigs.Add(new PlayerConfiguration(pi));
        }
    }

    //returns player info to the smaller Game Manager
    public List<PlayerConfiguration> GetPlayerConfigs()
    {
        return PlayerConfigs;
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
