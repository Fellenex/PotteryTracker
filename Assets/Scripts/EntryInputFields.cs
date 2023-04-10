using UnityEngine;
using System.Collections.Generic;
using System;
using UnityEngine.UI;
using TMPro;

public class EntryInputFields : MonoBehaviour {

    public TextMeshProUGUI idDisplay;
    public TextMeshProUGUI nameInput;
    public TextMeshProUGUI numPiecesInput;
    public TextMeshProUGUI weightInput;

    public TextMeshProUGUI thrownDateInput;
    public TextMeshProUGUI trimDateInput;
    public TextMeshProUGUI glazeDateInput;

    public TextMeshProUGUI clayNamesInput;
    public TextMeshProUGUI glazeNamesInput;
    public TextMeshProUGUI notesInput;

    public List<TextMeshProUGUI> inputFields;

    public void Start() {
        inputFields = new List<TextMeshProUGUI>{
            idDisplay,
            nameInput,
            numPiecesInput,
            weightInput,
            thrownDateInput,
            trimDateInput,
            glazeDateInput,
            clayNamesInput,
            glazeNamesInput,
            notesInput
        };

        /*
        foreach (TextMeshProUGUI tmp in inputFields) {
            tmp.text = "10";
        }
        */
    }

    public void saveEntry() {
        Debug.Log("Saving entry");
    }

}
