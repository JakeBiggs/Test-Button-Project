using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCheck : MonoBehaviour
{
    public string tagToCheck = "A";

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == tagToCheck){
            GameManager.score++;
            Destroy(other.gameObject);
        }

    }
}
