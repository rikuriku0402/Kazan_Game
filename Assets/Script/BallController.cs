using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField]
    GameObject _ballPrefab = null;

    [SerializeField]
    GameObject _spawn;

    public void BallSetActive()
    {
        _ballPrefab.SetActive(true);
        GameManager.Instance._isBall = true;
    }

    public void BallPush()
    {
        if (!GameManager.Instance._isBall)
        {
            BallSetActive();
        }
    }
}
