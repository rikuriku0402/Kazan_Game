using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cysharp;
using Cysharp.Threading.Tasks;


public class Rotator : MonoBehaviour
{
    const float ROTATE_X = 0;//x軸の回転角度
    const float ROTATE_Z = 0;//z軸の回転角度

    [SerializeField]
    [Header("y軸の回転角度")]
    float _rotate_Y = 0;


    private void Start()
    {
        var uniTask = SpeedChange();
    }

    // Update is called once per frame
    void Update()
    {
        // X,Y,Z軸に対してそれぞれ、指定した角度ずつ回転させている。
        // deltaTimeをかけることで、フレームごとではなく、1秒ごとに回転するようにしている。
        gameObject.transform.Rotate(new Vector3(ROTATE_X, _rotate_Y, ROTATE_Z) * Time.deltaTime);
    }

    async UniTask SpeedChange()
    {
        await UniTask.Delay(10000);
        print("あ");
        _rotate_Y = Random.Range(8f, 18f);
        var uniTask = SpeedChange();
    }
}
