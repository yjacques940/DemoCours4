using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Dialog")]
public class DialogText : ScriptableObject {
    [TextArea(10, 14)] [SerializeField] string scriptableText;
    [SerializeField] DialogText nextDialog;

    public string GetDialogText()
    {
        return scriptableText;
    }

    public DialogText GetNextDialog()
    {
        return nextDialog;
    }

    public bool IsNextDialog()
    {
        if(nextDialog)
        {
            return true;
        }
        return false;
    }
}
