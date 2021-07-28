using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class SelectNotebookSection : MonoBehaviour {
    public UnityEvent evento;

    private List<SpriteRenderer> spritesSelecionados;

    private void Start() {
        spritesSelecionados = new List<SpriteRenderer>(GetComponentsInChildren<SpriteRenderer>());
    }

    private void OnMouseEnter() {
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
        TrocarCor(Color.clear);
        evento.Invoke();
    }

    private void TrocarCor(Color cor) {
        foreach (SpriteRenderer sprite in spritesSelecionados) {
            sprite.material.color = cor;
        }
    }
}
