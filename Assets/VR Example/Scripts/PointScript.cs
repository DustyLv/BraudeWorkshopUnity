using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PointScript : MonoBehaviour
{
    public TextMeshProUGUI m_PointText;
    public int m_CurrentPoints = 0;


    // This is called when the ball enters the bucket trigger
    public void AddPoints()
    {
        // Add 1 point to the total points
        m_CurrentPoints = m_CurrentPoints + 1;
        // Call function that updates the UI only when adding points
        UpdateScoreUI();
    }

    public void UpdateScoreUI()
    {
        // Sets the UI Text objects text to the current total points
        m_PointText.text = m_CurrentPoints.ToString();
    }
}
