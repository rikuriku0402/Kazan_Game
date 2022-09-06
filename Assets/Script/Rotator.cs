using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField]
    [Tooltip("x���̉�]�p�x")]
    private float rotateX = 0;

    [SerializeField]
    [Tooltip("y���̉�]�p�x")]
    private float rotateY = 0;

    [SerializeField]
    [Tooltip("z���̉�]�p�x")]
    private float rotateZ = 0;

    // Update is called once per frame
    void Update()
    {
        // X,Y,Z���ɑ΂��Ă��ꂼ��A�w�肵���p�x����]�����Ă���B
        // deltaTime�������邱�ƂŁA�t���[�����Ƃł͂Ȃ��A1�b���Ƃɉ�]����悤�ɂ��Ă���B
        gameObject.transform.Rotate(new Vector3(rotateX, rotateY, rotateZ) * Time.deltaTime);
    }
}