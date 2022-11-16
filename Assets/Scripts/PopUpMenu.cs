using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpMenu : MonoBehaviour
{
    public GameObject panel;

    void Start()
    {
        panel.SetActive(false);
    }

    public void PopUp(GameObject panel)
    {
        panel.SetActive(!panel.activeSelf);
    }
}