using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarkLightManager : MonoBehaviour {
    public GameObject darkLight;

    private void Update() {
        if (Input.GetButtonDown("DarkLight") && Player.instance.FindItem("DarkLight")) {
            darkLight.SetActive(!darkLight.activeSelf);
        }
    }
}
