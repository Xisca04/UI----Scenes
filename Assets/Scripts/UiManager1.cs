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

    /* Función para la persistencia de datos entre partidas
     
    public void SaveUsernameWithPlayerPrefs()
    {
        PlayerPrefs.SetString("USERNAME", DataPersistence.sharedInstance.username);
    }
    
    private string existingUsername;
    private const string USERNAME = "USERNAME"; // tipo CONS no se puede modificar, es una constante

    private void Start()
    {
        existingUsername = PlayerPrefs.GetString(USERNAME); // Busca si existe la clave username

        if(existingUsername != "")
        {
            inputField.placeholder.GetComponent<TextMeshProUGUI>().text = existingUsername; // Si se ha guardado un username en player prefs, se sobrescribe
        }
    }
    */
}
