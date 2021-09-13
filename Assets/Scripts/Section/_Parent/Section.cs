using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Section : MonoBehaviour {

    public SectionObject sectionObject;
    private Item item;
    private List<SpriteRenderer> spritesSelecionados;

    private void Start() {
        spritesSelecionados = new List<SpriteRenderer>(GetComponentsInChildren<SpriteRenderer>());
        item = GetComponent<Item>();
    }

    private void OnMouseOver() {
        if (!SectionManager.instance.onSection) {
            TrocarCor(Color.red);
        }
    }

    private void OnMouseExit() {
        TrocarCor(Color.clear);
    }

    private void OnMouseDown() {
        if (!SectionManager.instance.onSection) {
            TrocarCor(Color.clear);

            sectionObject.Execute(transform);
            if (item != null) {
                item.PickUp();
            }
        }
    }

    private void TrocarCor(Color cor) {
        foreach (SpriteRenderer sprite in spritesSelecionados) {
            sprite.material.color = cor;
        }
    }
}