using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cambiar : MonoBehaviour
{

    public GameObject panel;
    public GameObject panel1;

    // Update is called once per frame
    public void Cambiar_panel()
    {
        panel.SetActive(false);
        panel1.SetActive(true);
    }
}
