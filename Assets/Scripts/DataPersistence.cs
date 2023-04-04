using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataPersistence : MonoBehaviour
{
    // En este script hay que crear todas las variables que queramos que se guarden entre escennas

    public static DataPersistence sharedInstance;

    public string username;

    private void Awake()  // Código para que el script sea único
    {
        if(sharedInstance == null)  // Si la variable es nula, no tiene ningún tipo de valor
        {
            sharedInstance = this; // Hacemos que tenga un valor
            DontDestroyOnLoad(this); // Hace que no destruyan los datos al cambiar de escenas
        }
        else
        {
            Destroy(gameObject); // Todo copia que se haga del script se destruirá, para que este sea único
        }
    }
}
