using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StarterAssets
{
    public class JumpPad : MonoBehaviour
    {
        public float jumpHeight = 5f;

        private void OnTriggerEnter(Collider other)
        {
            if (other.name.ToString() == "UD_PlayerArmature")
            {
                print("Bump");
                other.GetComponent<ThirdPersonController>().Bump(jumpHeight);
            }
            else print(other.name.ToString());
        }
    }

}
