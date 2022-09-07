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
            print("‚ ‚½‚è");
        }
    }

    public void Lose(GameObject ball)
    {
        if (HitORLose.Lose == _type)
        {
            print("‚Í‚¸‚ê");
            Destroy(ball);
        }
    }

    enum HitORLose
    {
        Hit,
        Lose
    }
}
