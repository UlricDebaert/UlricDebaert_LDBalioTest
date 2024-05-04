using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleStar : MonoBehaviour
{
    private bool isPickup;
    public Animator anim;


    public void DestroyCollectible()
    {
        Destroy(gameObject);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "UD_PlayerArmature" && !isPickup)
        {
            isPickup = true;
            if(anim != null) anim.SetBool("isPickup", true);
            GameManager.instance.AddStar();
        }
    }
}
