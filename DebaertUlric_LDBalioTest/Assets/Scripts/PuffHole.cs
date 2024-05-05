using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuffHole : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Puff"))
        {
            Destroy(other.gameObject);
        }
    }
}
