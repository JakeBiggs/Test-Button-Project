using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beat : MonoBehaviour
{
    private void Update()
    {
        transform.position += (Vector3.back * GameManager.gameSpeed) * Time.deltaTime;
    }
}
