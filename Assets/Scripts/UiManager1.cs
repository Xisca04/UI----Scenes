using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class UiManager1 : MonoBehaviour
{
    public TMP_InputField inputField;

    public void SaveUsername()
    {
        string inputText = inputField.text;

        if(inputText == "")
        {
            DataPersistence.sharedInstance.username = inputField.placeholder.GetComponent<TextMeshProUGUI>().text;
        }
        else
        {
            DataPersistence.sharedInstance.username = inputText;
        }
    }
}
