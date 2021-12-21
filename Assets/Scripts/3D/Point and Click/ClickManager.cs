using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ClickManager : MonoBehaviour {
    public static ClickManager instance;
    private GameObject targetObject;

    [System.NonSerialized]public UnityEvent mouseEnter;
    [System.NonSerialized]public UnityEvent click;
    [System.NonSerialized]public UnityEvent mouseExit;

    public virtual void Awake() {
        if (instance == null) {
            mouseEnter = new UnityEvent();
            click = new UnityEvent();
            mouseExit = new UnityEvent();
            instance = this;
        }
        else {
            Destroy(this);
        }
    }

    private void Update() {
        ShootRaycast();
    }

    private void ShootRaycast() {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 100f) && hit.transform != null && hit.transform.gameObject.CompareTag("Clickable")) {
            if (targetObject == null) {
                targetObject = hit.transform.gameObject;
                mouseEnter.Invoke();
            }
            if (Input.GetMouseButton(0)) {
                click.Invoke();
            }
        }
        else {
            targetObject = null;
            mouseExit.Invoke();
        }
    }

    public bool IsTargeting(GameObject obj) {
        return obj == targetObject;
    }

}
