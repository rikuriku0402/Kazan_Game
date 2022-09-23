using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallInstantiate : MonoBehaviour
{
    Transform _pool;

    void Start()
    {
        _pool = new GameObject("Ball").transform;    
    }

    void GetObject(GameObject obj, Vector3 pos, Quaternion qua)
    {
        foreach (Transform t in _pool)
        {
            if (!t.gameObject.activeSelf)
            {
                t.SetPositionAndRotation(pos, qua);
                t.gameObject.SetActive(true);
            }
        }
        Instantiate(obj, pos, qua, _pool);
    }
}
