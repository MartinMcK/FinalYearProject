using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObject : MonoBehaviour
{

    public Score score;


    [SerializeField]
    private int scoreValue = 1;


   private void OnTriggerEnter(Collider collider)
    {
        score.AddScore(scoreValue);
        Destroy(gameObject);
    }
}
