using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class SelectSection : MonoBehaviour {
    public UnityEvent evento;

    private List<SpriteRenderer> spritesSelecionados;

    private void Start() {
        spritesSelecionados = new List<SpriteRenderer>(GetComponentsInChildren<SpriteRenderer>());
    }

    private void OnMouseOver() {
        if (!SectionManager.instance.onSection) {
            TrocarCor(Color.red);
        }
    }

    private void OnMouseExit() {
        if (!SectionManager.instance.onSection) {
            TrocarCor(Color.clear);
        }
    }

    private void OnMouseDown() {
        if (!SectionManager.instance.onSection) {
            TrocarCor(Color.clear);
            evento.Invoke();
        }
    }

    private void TrocarCor(Color cor) {
        foreach (SpriteRenderer sprite in spritesSelecionados) {
            sprite.material.color = cor;
        }
    }
}
