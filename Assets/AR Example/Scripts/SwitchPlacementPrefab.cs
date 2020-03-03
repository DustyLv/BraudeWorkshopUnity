using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.AR;

public class SwitchPlacementPrefab : MonoBehaviour
{
    public GameObject m_ChairPrefab;
    public GameObject m_TablePrefab;
    public GameObject m_TVPrefab;
    public ARPlacementInteractable m_PlacementInteractable;

    public void SwapToChair()
    {
        if (m_PlacementInteractable == null)
            return;

        m_PlacementInteractable.placementPrefab = m_ChairPrefab;
    }

    public void SwapToTable()
    {
        if (m_PlacementInteractable == null)
            return;

        m_PlacementInteractable.placementPrefab = m_TablePrefab;
    }
    
    public void SwapToTV()
    {
        if (m_PlacementInteractable == null)
            return;

        m_PlacementInteractable.placementPrefab = m_TVPrefab;
    }
}
