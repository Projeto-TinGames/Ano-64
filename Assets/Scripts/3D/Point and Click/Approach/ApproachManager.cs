using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ApproachManager : MonoBehaviour {
    public static ApproachManager instance;

    public Camera m_camera;
    public GameObject backButton;
    private Approachable approachedObject;
    private Vector3 resetCamera;

    public void Awake() {
        if (instance == null) {
            instance = this;
        }
        else {
            Destroy(gameObject);
        }
        resetCamera = new Vector3(m_camera.transform.position.x,m_camera.transform.position.y,m_camera.transform.position.z);
    }

    public void ApproachCamera(Approachable approachable) {
        backButton.SetActive(true);
        approachedObject = approachable;

        foreach (GameObject childObject in approachedObject.childrenObjects) {
            childObject.SetActive(true);
            childObject.transform.parent = null;
        }

        Vector3 targetPosition = approachable.transform.position;
        m_camera.transform.position = new Vector3(targetPosition.x, targetPosition.y + 1f, targetPosition.z - 5f);
    }

    public void ReturnCamera() {
        approachedObject.gameObject.SetActive(true);

        foreach (GameObject childObject in approachedObject.childrenObjects) {
            childObject.SetActive(false);
            childObject.transform.parent = approachedObject.gameObject.transform;
        }


        backButton.SetActive(false);
        m_camera.transform.position = resetCamera;
    }
}
