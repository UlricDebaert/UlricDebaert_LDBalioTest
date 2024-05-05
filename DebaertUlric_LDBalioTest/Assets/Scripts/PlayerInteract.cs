using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteract : MonoBehaviour
{

    PlayerInput inputs;
    public PuffInteractable puff;


    void Start()
    {
        inputs = GetComponent<PlayerInput>();
    }

    void Update()
    {
        if(puff != null && inputs.actions["Interact"].triggered)
        {
            puff.Interact();
        }
    }
}
