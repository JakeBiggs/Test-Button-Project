using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        GameManager.score--;
        Destroy(other);
    }
}
