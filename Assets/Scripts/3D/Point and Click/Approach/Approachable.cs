using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Approachable : Clickable {
    [System.NonSerialized]public List<GameObject> childrenObjects = new List<GameObject>();

    public override void Start() {
        base.Start();

        for (int i = 0; i < gameObject.transform.childCount; i++) {
            childrenObjects.Add(gameObject.transform.GetChild(i).gameObject);
            gameObject.transform.GetChild(i).gameObject.SetActive(false);
        }
    }

    public override void Click() {
        base.Click();
        ApproachManager.instance.ApproachCamera(this);
        this.gameObject.SetActive(false);
    }
}
