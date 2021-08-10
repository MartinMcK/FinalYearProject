using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIAppear : MonoBehaviour
{
    [SerializeField]
    private Image customImage;

    void onTriggerEnter (Collider other)
    {
        if(other.CompareTag("Player"))
        {
            customImage.enabled = true;

        }
    }
    void onTriggerExit(Collider other)
    {
        if (other.CompareTag("player"))
        {
            customImage.enabled = false;

        }
    }
}
