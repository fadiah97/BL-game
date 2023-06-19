using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PanelScript : MonoBehaviour {

    public GameObject panel;


    int counter;

    public void openPanel()
    {

        if (panel != null)
        {

            bool Isactive = panel.activeSelf;

            panel.SetActive(!Isactive);
        }

    }

}
