using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataPersistence : MonoBehaviour
{
    // En este script hay que crear todas las variables que queramos que se guarden entre escennas

    public static DataPersistence sharedInstance;

    public string username;

    private void Awake()  // C�digo para que el script sea �nico
    {
        if(sharedInstance == null)  // Si la variable es nula, no tiene ning�n tipo de valor
        {
            sharedInstance = this; // Hacemos que tenga un valor
            DontDestroyOnLoad(this); // Hace que no destruyan los datos al cambiar de escenas
        }
        else
        {
            Destroy(gameObject); // Todo copia que se haga del script se destruir�, para que este sea �nico
        }
    }
}
