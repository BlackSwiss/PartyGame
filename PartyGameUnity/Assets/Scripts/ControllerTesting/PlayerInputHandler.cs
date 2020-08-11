using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

public class PlayerInputHandler : MonoBehaviour
{
    //ref to playerInput
    private PlayerInput playerInput; //The literal player Input of the controller
    private Mover mover; //ref to movement script
    void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        var movers = FindObjectsOfType<Mover>(); //Get player objects
        var index = playerInput.playerIndex; //Get index of the Contrller
        mover = movers.FirstOrDefault(m => m.GetPlayerIndex() == index); //organize all contrllers by index;
    }

    //Function that is called by controller
    public void OnMove(CallbackContext context)
    {
        if(mover !=null)
            mover.SetInputVector(context.ReadValue<Vector2>()); //Tells the mover script what value the stick motion is returning and saves it to be used later
    }
}
