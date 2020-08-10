using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

public class PlayerInputHandler : MonoBehaviour
{
    //ref to playerInput
    private PlayerInput playerInput;
    private Mover mover; //ref to movement script
    void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        var movers = FindObjectsOfType<Mover>(); //Get player objects
        var index = playerInput.playerIndex;
        mover = movers.FirstOrDefault(m => m.GetPlayerIndex() == index);
    }

    //Function that is called by controller
    public void OnMove(CallbackContext context)
    {
        if(mover !=null)
            mover.SetInputVector(context.ReadValue<Vector2>());
    }
}
