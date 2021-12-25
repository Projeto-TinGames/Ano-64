using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Approachable : Clickable {

    private List<GameObject> children = new List<GameObject>();
    private List<_OnApproachProperty> onApproachProperties = new List<_OnApproachProperty>();

    private bool rotateParent;
    private Quaternion parentTargetRotation;

    public override void Start() {
        base.Start();

        for (int i = 0; i < gameObject.transform.childCount; i++) {
            children.Add(gameObject.transform.GetChild(i).gameObject);
        }

        onApproachProperties = new List<_OnApproachProperty>(GetComponents<_OnApproachProperty>());

        foreach (_OnApproachProperty property in onApproachProperties) {
            property.enabled = false;
        }
    }

    private void FixedUpdate() {
        if (rotateParent) {
            transform.rotation = Quaternion.Lerp(transform.rotation, parentTargetRotation, Time.deltaTime * 5f);

            if (Quaternion.Angle(transform.rotation, parentTargetRotation) < 0.001f) {
                rotateParent = false;
            }
        }
    }

    public override void Click() {
        if (targeted) {
            base.Click();
            Approach();
        }
    }

    public void Approach(bool addToCache = true) {
        foreach (_OnApproachProperty property in onApproachProperties) {
            property.Activate();
        }

        targetable = false;

        foreach (GameObject child in children) {
            child.SetActive(true);
        }

        ApproachManager.instance.Approach(this,addToCache);
    }

    public void Desapproach() {
        foreach (GameObject child in children) {
            child.SetActive(false);
        }

        foreach (_OnApproachProperty property in onApproachProperties) {
            property.Deactivate();
        }

        targetable = true;
    }

    public void AdjustParent(Approachable child) {
        Vector3 angles = child.transform.localEulerAngles;

        Quaternion childRotation = Quaternion.Euler(-angles.x, -angles.y, -angles.z);
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(1f,1f,0f) - transform.position);

        parentTargetRotation = lookRotation * childRotation;
        rotateParent = true;
    }

    public void LoseFocus() {
        foreach (_OnApproachProperty property in onApproachProperties) {
            property.LoseFocus();
        }
    }
}
