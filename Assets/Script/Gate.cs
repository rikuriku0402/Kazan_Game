using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour,ILose,IHit
{
    [SerializeField]
    HitORLose _type;

    public void Hit()
    {
        if (HitORLose.Hit == _type)
        {
            print("あたり");
        }
    }

    public void Lose()
    {
        if (HitORLose.Lose == _type)
        {
            print("はずれ");
            //Destroy(ball);
        }
    }

    enum HitORLose
    {
        Hit,
        Lose
    }
}
