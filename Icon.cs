using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Icon : MonoBehaviour {

    [SerializeField]
    private Image icon;
    public Image textbox;
    public GameObject dialougebox;

 

    private void OnTriggerEnter2D(Collider2D Other)
    {
        if (Other.CompareTag("Player"))
        {
            icon.enabled = true;
            textbox.enabled = true;
            dialougebox.SetActive(true);
        }


    }

    private void OnTriggerExit2D(Collider2D Other)
    {
        if (Other.CompareTag("Player"))
        {
            icon.enabled = false;
            textbox.enabled = false;
            dialougebox.SetActive(false);
        }
    }
}
