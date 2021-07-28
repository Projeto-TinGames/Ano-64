using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Selecionar : MonoBehaviour {
    private List<SpriteRenderer> spritesSelecionados;
    public UnityEvent eventos;

    private void Start() {
        spritesSelecionados = new List<SpriteRenderer>(GetComponentsInChildren<SpriteRenderer>());
    }

    private void OnMouseEnter() {
        foreach (SpriteRenderer sprite in spritesSelecionados) {
            sprite.material.color = Color.red;
        }
    }

    private void OnMouseExit() {
        foreach (SpriteRenderer sprite in spritesSelecionados) {
            sprite.material.color = Color.clear;
        }
    }

    private void OnMouseDown() {
        Debug.Log('l');
    }
}
