using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager2 : MonoBehaviour
{
    public TextMeshProUGUI helloText;

    private void Start()
    {
        helloText.text = $"Hola, {DataPersistence.sharedInstance.username}";
    }
}
