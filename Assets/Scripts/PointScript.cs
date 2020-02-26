using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PointScript : MonoBehaviour
{
    public TextMeshProUGUI m_PointText;
    public int m_CurrentPoints = 0;

    public void AddPoints()
    {
        m_CurrentPoints = m_CurrentPoints + 1;
        UpdateScoreUI();
    }

    public void UpdateScoreUI()
    {
        m_PointText.text = m_CurrentPoints.ToString();
    }
}
