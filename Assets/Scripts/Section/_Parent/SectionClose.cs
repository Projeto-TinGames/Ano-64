using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SectionClose : MonoBehaviour {
    private int cooldown;

    private void OnEnable() {
        cooldown = 5;
    }

    private void FixedUpdate() {
        if (cooldown > 0) {
            cooldown--;
        }
    }

    public void Close() {
        if (cooldown <= 0) {
            SectionManager.instance.ExitSection();
        }
    }
}
