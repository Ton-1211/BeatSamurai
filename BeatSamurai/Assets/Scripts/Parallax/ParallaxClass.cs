using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable] public class ParallaxClass
{
    [Header("�������摜�̃I�u�W�F�N�g"), SerializeField] GameObject imageObject;
    [Header("���̉摜�̃T�C�Y�ƍ���Ȃ��Ƃ��ɐݒ�"), SerializeField] GameObject sizeObject;
    [Tooltip("�J�����ւ̒Ǐ]���ɂ����i0�œ����Ȃ��A1�ŃJ�����Ɠ��������j"), SerializeField] Vector2 parallaxEffect = new Vector2(1f, 0f);
    [Header("���[�v���邩�ǂ���"), SerializeField] bool canLoop = true;
    float length;
    Vector3 startPos;
    float timeElapsed;

    public GameObject ImageObject
    {
        get { return imageObject; }
    }
    public GameObject SizeObject
    {
        get { return sizeObject; }
    }
    public Vector2 ParallaxEffect
    {
        get { return parallaxEffect; }
    }
    public float Length
    {
        get { return length; }
        set { length = value; }
    }
    public Vector3 StartPos
    {
        get { return startPos; }
        set { startPos = value; }
    }
    public bool CanLoop
    {
        get { return canLoop; }
    }
    public float TimeElapsed
    {
        get { return timeElapsed; }
        set { timeElapsed = value; }
    }
    public bool IsSizeObjectAttached() { return sizeObject != null; }// sizeObject��null�łȂ�(=�A�^�b�`����Ă���)���ǂ�����Ԃ�
}
