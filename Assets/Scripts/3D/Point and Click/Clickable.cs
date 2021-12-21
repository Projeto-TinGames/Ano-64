using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clickable : MonoBehaviour {

    private Outline outline;
    private bool targeted;

    private void Awake() {
        outline = gameObject.AddComponent<Outline>();
        gameObject.tag = "Clickable";
    }

    public virtual void Start() {
        outline.enabled = false;
        outline.OutlineColor = Color.red;
        outline.OutlineWidth = 10f;

        ClickManager.instance.mouseEnter.AddListener(MouseEnter);
        ClickManager.instance.click.AddListener(Click);
        ClickManager.instance.mouseExit.AddListener(MouseExit);
    }

    private void MouseEnter() {
        if (ClickManager.instance.IsTargeting(this.gameObject)) {
            Target(true);
        }
    }

    public virtual void Click() {
        if (targeted) {
            Target(false);
        }
    }
    
    private void MouseExit() {
        if (targeted) {
            Target(false);
        }
    }

    private void Target(bool target) {
        targeted = target;
        outline.enabled = target;
    }
}
