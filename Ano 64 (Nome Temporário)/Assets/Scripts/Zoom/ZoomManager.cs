using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class ZoomManager : MonoBehaviour {
    public static ZoomManager instance;
    public CinemachineVirtualCamera camera;
    private bool zooming;

    private void Awake() {
        if (instance == null) {
            instance = this;
        }
        else {
            Destroy(gameObject);
        }
    }

    private void FixedUpdate() {
        if (zooming && camera.m_Lens.OrthographicSize > 1f) {
            camera.m_Lens.OrthographicSize -= 0.05f;
        }
        else if (!zooming && camera.m_Lens.OrthographicSize < 3f) {
            camera.m_Lens.OrthographicSize += 0.05f;
        }
    }

    public void ZoomIn(Transform transform) {
        camera.m_Follow = transform;
        zooming = true;
    }

    public void ZoomOut(Transform transform) {
        camera.m_Follow = transform;
        zooming = false;
    }
}
