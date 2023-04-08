using UnityEngine.UI;
using System;
using System.Collections.Generic;

[Serializable]
public class PotteryEntryList {
    public List<PotteryEntry> entries;
}

[Serializable]
public class PotteryEntry {
    public int id;
    public string label;
    public int pieces;
    public DateTime thrownDate;
    public DateTime trimmedDate;
    public DateTime glazedDate;
    public List<string> clays;
    public List<string> trims;
    public List<string> glazes;
    public string notes;
    public string imagePath;
    

    public Image getImage() {
        //TODO load image from path.
        return null;
    }

}