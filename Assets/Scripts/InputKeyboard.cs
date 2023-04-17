using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputKeyboard : MonoBehaviour
{
    public GameObject QButton, WButton, EButton;

    private void Update(){

        QButton.SetActive(Input.GetKey(KeyCode.Q));
        WButton.SetActive(Input.GetKey(KeyCode.W));
        EButton.SetActive(Input.GetKey(KeyCode.E));
    }
}
