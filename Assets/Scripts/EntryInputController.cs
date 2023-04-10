using UnityEngine;
using System;

public class EntryInputController : MonoBehaviour
{

    public PotteryEntry activeEntry; // a model to keep track of this pottery entry
    public EntryInputFields entryView; // a script that holds references to all the text input fields

    public event Action<PotteryEntry> CloseDetailedEntry;

    private void Start() {
        entryView = GetComponent<EntryInputFields>();
    }

    public void closeEntry() {
        //Hand back control to the main menu controller
        Debug.Log("Closing/Cancelling");
        CloseDetailedEntry?.Invoke(activeEntry);
    }

    public void saveEntry() {
        Debug.Log("Saving!");
        CloseDetailedEntry?.Invoke(activeEntry);
    }


}
