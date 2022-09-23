using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cysharp;
using Cysharp.Threading.Tasks;


public class Rotator : MonoBehaviour
{
    const float ROTATE_X = 0;//x²‚Ì‰ñ“]Šp“x
    const float ROTATE_Z = 0;//z²‚Ì‰ñ“]Šp“x

    [SerializeField]
    [Header("y²‚Ì‰ñ“]Šp“x")]
    float _rotate_Y = 0;


    private void Start()
    {
        var uniTask = SpeedChange();
    }

    // Update is called once per frame
    void Update()
    {
        // X,Y,Z²‚É‘Î‚µ‚Ä‚»‚ê‚¼‚êAw’è‚µ‚½Šp“x‚¸‚Â‰ñ“]‚³‚¹‚Ä‚¢‚éB
        // deltaTime‚ğ‚©‚¯‚é‚±‚Æ‚ÅAƒtƒŒ[ƒ€‚²‚Æ‚Å‚Í‚È‚­A1•b‚²‚Æ‚É‰ñ“]‚·‚é‚æ‚¤‚É‚µ‚Ä‚¢‚éB
        gameObject.transform.Rotate(new Vector3(ROTATE_X, _rotate_Y, ROTATE_Z) * Time.deltaTime);
    }

    async UniTask SpeedChange()
    {
        await UniTask.Delay(10000);
        print("‚ ");
        _rotate_Y = Random.Range(8f, 18f);
        var uniTask = SpeedChange();
    }
}
