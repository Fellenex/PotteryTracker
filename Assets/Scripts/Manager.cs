using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {

    public MainMenuController menuController;
    public EntryInputController entryController;
    
    void Start() {
        entryController.CloseDetailedEntry += OnCloseDetailedEntryView;
    }

    public void OnCloseDetailedEntryView(PotteryEntry editedEntry) {
        //TODO save things back to .json here?
        Debug.Log("Manager caught close detailed entry event");
    }
}
