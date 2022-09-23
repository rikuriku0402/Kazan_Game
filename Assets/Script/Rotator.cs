using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cysharp;
using Cysharp.Threading.Tasks;


public class Rotator : MonoBehaviour
{
    const float ROTATE_X = 0;//x���̉�]�p�x
    const float ROTATE_Z = 0;//z���̉�]�p�x

    [SerializeField]
    [Header("y���̉�]�p�x")]
    float _rotate_Y = 0;


    private void Start()
    {
        var uniTask = SpeedChange();
    }

    // Update is called once per frame
    void Update()
    {
        // X,Y,Z���ɑ΂��Ă��ꂼ��A�w�肵���p�x����]�����Ă���B
        // deltaTime�������邱�ƂŁA�t���[�����Ƃł͂Ȃ��A1�b���Ƃɉ�]����悤�ɂ��Ă���B
        gameObject.transform.Rotate(new Vector3(ROTATE_X, _rotate_Y, ROTATE_Z) * Time.deltaTime);
    }

    async UniTask SpeedChange()
    {
        await UniTask.Delay(10000);
        print("��");
        _rotate_Y = Random.Range(8f, 18f);
        var uniTask = SpeedChange();
    }
}
