using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuffDeadly : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name.ToString() == "UD_PlayerArmature")
        {
            print("DEAD");
        }
    }
}
