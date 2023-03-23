using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PotteryEntryView : MonoBehaviour {

    public TMP_Text label;
    public Image image;
    public TMP_Text thrownDate;
    public TMP_Text editedDate;


    public void setLabelText(string _text){
        label.text = _text;
    }
}
