using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class ZoomManager : MonoBehaviour {
    public static ZoomManager instance;
    public CinemachineVirtualCamera cam;
    public Transform focus;
    private Transform follow;
    private bool zooming;
    private int movingCounter;

    private void Awake() {
        if (instance == null) {
            instance = this;
        }
        else {
            Destroy(gameObject);
        }
    }

    private void FixedUpdate() {
        if (zooming && cam.m_Lens.OrthographicSize > 1f) {
            if (movingCounter > 0) {
                ChangeFollow(follow);
                movingCounter--;
            }
            else {
                cam.m_Lens.OrthographicSize -= 0.05f;
            }
        }
        else if (!zooming && cam.m_Lens.OrthographicSize < 3f) {
            cam.m_Lens.OrthographicSize += 0.05f;
            if (cam.m_Lens.OrthographicSize >= 3f) {
                ChangeFollow(follow);
            }
        }
    }

    public void ControlZoom(bool zoom, Transform transform) {
        if (zoom) {
            ZoomIn(transform);
        }
        else {
            ZoomOut(focus);
        }
    }

    public void ZoomIn(Transform transform) { 
        follow = transform;
        movingCounter = 30;
        zooming = true;
    }

    public void ZoomOut(Transform transform) {
        follow = transform;
        zooming = false;
    }

    private void ChangeFollow(Transform transform) {
        cam.m_Follow = transform;
    }
}
