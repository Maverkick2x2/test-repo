using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePanel : MonoBehaviour
{
    [SerializeField] private GameObject activePanel;
    [SerializeField] private GameObject inactivePanel;

    public void ChangeActivePanel()
    {
        activePanel.SetActive(false);
        inactivePanel.SetActive(true);
    }
}
