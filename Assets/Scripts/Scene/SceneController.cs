using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.VFX;

public class SceneController : MonoBehaviour {
    public static SceneController instance;

    public Animator transition;
    public float transitionTime = 1;

    private void Awake() {
        if (instance == null) {
            instance = this;
        }
        else {
            Destroy(gameObject);
        }
    }

    public void Load(int scene) {
        Player.instance.page = scene;
        StartCoroutine(LoadLevel(scene));
    }

    IEnumerator LoadLevel(int scene) {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(scene);
    }
}
