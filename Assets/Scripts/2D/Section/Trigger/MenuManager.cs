using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : _TriggerManager {
    private bool onTitle = true;
    public GameObject titleSection;
    public GameObject loadSection;

    public override void Awake() {
        base.Awake();
        ActivateSection(titleSection);
    }

    public override void FixedUpdate() {
        base.FixedUpdate();

        if (onTitle && Input.GetMouseButton(0)) {
            onTitle = false;
            ExitSection();
        } 
    }

    private void NewGame() {
        SceneController.instance.Load(1);
    }

    private void Load() {
        ActivateSection(loadSection);
    }

    private void Options() {
        Debug.Log("Abrir Opções");
    }

    private void Credits() {
        Debug.Log("Abrir Créditos");
    }

    private void Exit() {
        Application.Quit();
    }

    public override void ExecuteSection(SectionObject sectionObject) {

        TriggerObject triggerObject = (TriggerObject)sectionObject;

        switch (triggerObject.function) {

            case "NewGame":
                NewGame();
                break;

            case "Load":
                Load();
                break;

            case "Options":
                Options();
                break;

            case "Credits":
                Credits();
                break;

            case "Exit":
                Exit();
                break;
                
        }
    }

}
