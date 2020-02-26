using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BucketTrigger : MonoBehaviour
{
    public BallController m_BallController;
    public PointScript m_PointScript;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball")
        {
            m_BallController.OnBallInBucket();
            m_PointScript.AddPoints();
        }
    }
}
