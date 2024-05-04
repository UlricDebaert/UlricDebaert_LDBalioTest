using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StarterAssets
{
    public class CaramelZone : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.name == "UD_PlayerArmature")
            {
                print("SLOWED!");
                other.GetComponent<ThirdPersonController>().isSlowed = true;
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.name == "UD_PlayerArmature")
            {
                print("FREE!");
                other.GetComponent<ThirdPersonController>().isSlowed = false;
            }
        }
    }

}
