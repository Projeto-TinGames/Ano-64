using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ApproachManager : ClickManager {
    public static ApproachManager selfInstance;

    [SerializeField]private Camera objCamera;
    [SerializeField]private GameObject backButton;
    private Vector3 resetCamera;

    public override void Awake() {
        base.Awake();
        if (selfInstance == null) {
            selfInstance = this;
        }
        else {
            Destroy(gameObject);
        }
        resetCamera = new Vector3(objCamera.transform.position.x,objCamera.transform.position.y,objCamera.transform.position.z);
        Debug.Log(resetCamera);
    }

    public void ApproachCamera(GameObject obj) {
        backButton.SetActive(true);
        Vector3 targetPosition = obj.transform.position;
        objCamera.transform.position = new Vector3(targetPosition.x, targetPosition.y + 1f, targetPosition.z - 5f);
    }

    public void ReturnCamera() {
        backButton.SetActive(false);
        Debug.Log(resetCamera);
        objCamera.transform.position = resetCamera;
    }

}
