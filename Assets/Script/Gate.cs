using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour,IHit
{
    [SerializeField]
    HitORLose _type;

    public void Hit()
    {
        print("������");
    }
}

[System.Serializable]
public enum HitORLose
{
    Hit,
}
