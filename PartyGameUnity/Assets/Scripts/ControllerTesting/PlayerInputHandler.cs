using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;
//This script gets player Input and sends it over to the controller input script
public class PlayerInputHandler : MonoBehaviour
{
    private Mover mover;
    private PlayerInput playerInput;
    [SerializeField]
    private int playerIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        var index = playerInput.playerIndex;
        
    }
    // Update is called once per frame
    void Update()
    {
        var x = Input.GetAxisRaw("Horizontal");
        var y = Input.GetAxisRaw("Vertical");
        mover.SetInputVector(new Vector2(x, y));
    }
    public int GetPlayerIndex()
    {
        return playerIndex;
    }
    //Function from contrller
    public void OnMove(CallbackContext context)
    {
       mover.SetInputVector(context.ReadValue<Vector2>()); //reads controller 
    }
}

