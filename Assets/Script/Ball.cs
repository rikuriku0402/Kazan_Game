using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out IHit hit))
        {
            hit.Hit();
        }
        if (other.TryGetComponent(out ILoose loose))
        {
            loose.Loose();
        }
    }
}
