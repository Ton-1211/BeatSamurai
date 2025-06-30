using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ParallaxScript : MonoBehaviour
{
    [SerializeField] Camera mainCamera;
    [Header("�������w�i����"), SerializeField] ParallaxClass[] parallaxClasses;
    // Start is called before the first frame update
    void Start()
    {
        foreach(ParallaxClass parallaxClass in parallaxClasses)// �o�^����Ă���w�i�I�u�W�F�N�g���ׂ�
        {
            // �J�n���_�̈ʒu�Ɖ摜�̒���(x������)��ݒ�
            parallaxClass.StartPos = parallaxClass.ImageObject.transform.position;// �J�n���_�̃I�u�W�F�N�g�̈ʒu���擾
            GameObject lengthObject = parallaxClass.IsSizeObjectAttached() == true ? parallaxClass.SizeObject : parallaxClass.ImageObject;// �T�C�Y�̊�ɂ���I�u�W�F�N�g��ݒ�
                                                                                                                                                       
            parallaxClass.Length = lengthObject.GetComponent<SpriteRenderer>().bounds.size.x;
        }
    }

    private void FixedUpdate()
    {
        foreach(var parallaxClass in parallaxClasses)
        {
            float loopDistanceX = mainCamera.transform.position.x * (1 - parallaxClass.ParallaxEffect.x);// ���[�v����p
            float distanceX = mainCamera.transform.position.x * parallaxClass.ParallaxEffect.x;// �������ʗp
            float distanceY = mainCamera.transform.position.y * parallaxClass.ParallaxEffect.y;

            parallaxClass.ImageObject.transform.position = new Vector3(parallaxClass.StartPos.x + distanceX,
                parallaxClass.StartPos.y + distanceY, parallaxClass.StartPos.z);// �w�i���W��distance�̕��ړ�������

            if (parallaxClass.CanLoop)// ���[�v����^�C�v�̂Ƃ�
            {
                // �w�i����ʊO�ɍs������w�i���ړ�������(�������[�v�̏���)
                if (loopDistanceX > parallaxClass.StartPos.x + parallaxClass.Length)
                {
                    parallaxClass.StartPos += new Vector3(parallaxClass.Length, 0f, 0f);
                }
                else if (loopDistanceX < parallaxClass.StartPos.x - parallaxClass.Length)
                {
                    parallaxClass.StartPos -= new Vector3(parallaxClass.Length, 0f, 0f);
                }
            }
        }
    }
}
