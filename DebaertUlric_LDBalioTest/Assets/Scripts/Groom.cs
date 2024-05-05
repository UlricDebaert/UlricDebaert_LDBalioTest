using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Groom : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "UD_PlayerArmature")
        {
            GameManager.instance.GetGroom();
        }
    }
}
