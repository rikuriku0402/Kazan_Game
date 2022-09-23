using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    GameObject _spawn;
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out IHit hit))
        {
            hit.Hit();
        }
        else if(!other.TryGetComponent(out IHit notHit))
        {
            gameObject.SetActive(false);
            gameObject.transform.position = _spawn.transform.position;
            GameManager.Instance._isBall = false;
        }
    }
}
