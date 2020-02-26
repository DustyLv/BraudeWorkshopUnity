using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Transform m_StartPosition;
    public float m_BallOffsetFromStart = 1f;
    private Rigidbody m_Rigidbody;

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        m_Rigidbody.isKinematic = true;
        transform.position = m_StartPosition.position;
    }

    void Update()
    {
        
    }

    public void OnBallInBucket()
    {


        StartCoroutine(WaitAndResetBall());
    }

    IEnumerator WaitAndResetBall()
    {

        yield return new WaitForSeconds(1f);
        if (m_Rigidbody.isKinematic == true)
        {
            m_Rigidbody.isKinematic = false;
        }
        m_Rigidbody.velocity = Vector3.zero;
        m_Rigidbody.angularVelocity = Vector3.zero;
        Vector3 pos = new Vector3(m_StartPosition.position.x + Random.Range(-m_BallOffsetFromStart, m_BallOffsetFromStart), m_StartPosition.position.y, m_StartPosition.position.z);
        transform.position = pos;
    }
}
