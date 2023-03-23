using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    public GameObject entryPrefab; // prefab for the entry UI
    public Transform entriesContainer; // transform for the container holding the entries

    private List<PotteryEntry> entries; // list of pottery entries

    private void Start() {
        entries = GetComponent<PotteryEntryListDeserializer>().potteryEntries;

        // create UI for each pottery entry
        foreach (PotteryEntry entry in entries) {
            Debug.Log("Adding an entry " + entry.label);
            // instantiate the entry prefab
            GameObject entryUI = Instantiate(entryPrefab, entriesContainer);

            // set the entry's name
            entryUI.GetComponent<PotteryEntryView>().setLabelText(entry.label);

            // set the entry's image
            //entryUI.GetComponentInChildren<Image>().sprite = entry.getImage();
        }
    }
}