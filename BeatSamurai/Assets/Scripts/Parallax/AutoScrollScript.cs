using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoScrollScript : MonoBehaviour
{
    [Header("�X�N���[�����x"), SerializeField] float scrollSpeed = 1f;

    void FixedUpdate()
    {
        transform.position += new Vector3(scrollSpeed * Time.deltaTime, 0f, 0f);
    }
}
