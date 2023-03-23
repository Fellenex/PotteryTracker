using System.Collections.Generic;
using UnityEngine;
using System;

public class PotteryEntryListDeserializer : MonoBehaviour {
    public TextAsset json;
    public List<PotteryEntry> potteryEntries = new List<PotteryEntry>();

    void Start() {
        //Deserialize the JSON array into a list of PotteryEntry objects
        PotteryEntryList jsonEntries = JsonUtility.FromJson<PotteryEntryList>(json.text);
        foreach (PotteryEntry potteryEntry in jsonEntries.entries) {
            potteryEntries.Add(potteryEntry);
            Debug.Log($"Pottery entry label: {potteryEntry.label}");
        }
    }
}