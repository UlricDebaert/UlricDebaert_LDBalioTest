using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuffInteractable : MonoBehaviour
{
    Animator anim;


    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void Interact()
    {
        anim.SetBool("pushed", true);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "UD_PlayerArmature")
        {
            other.GetComponent<PlayerInteract>().puff = this;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "UD_PlayerArmature")
        {
            other.GetComponent<PlayerInteract>().puff = null;
        }
    }
}
