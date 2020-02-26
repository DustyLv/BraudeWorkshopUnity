using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BucketMoveKeyboard : MonoBehaviour
{
    public float m_MoveSpeed = 2f;

    void Start()
    {
        
    }

    void Update()
    {
        float inputHorizontal = Input.GetAxis("Horizontal");

        transform.Translate(transform.right * inputHorizontal * m_MoveSpeed * Time.deltaTime);
    }
}
