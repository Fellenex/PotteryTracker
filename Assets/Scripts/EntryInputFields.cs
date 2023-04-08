using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EntryInputFields : MonoBehaviour {

    //public Text nameInput;
    public TextMeshProUGUI nameInput;
    public Text numPiecesInput;

    //TODO DatePicker type
    public GameObject thrownDateInput;
    public GameObject trimDateInput;
    public GameObject glazeDateInput;

    public Text clayNamesInput;
    public Text glazeNamesInput;
    public Text notesInput;

    public void Start() {
        nameInput.text = "Yesss";
    }

    public void saveEntry() {
        Debug.Log("Saving entry");
    }

}
