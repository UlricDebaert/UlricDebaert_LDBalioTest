using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bride : MonoBehaviour
{
    public GameObject starPrefab;
    public Transform spawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "UD_PlayerArmature" && GameManager.instance.groomFound)
        {
            GameManager.instance.LeaveGroom();
            Instantiate(starPrefab, spawnPoint);
        }
    }
}
