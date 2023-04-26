using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AinuParsledzejs : MonoBehaviour {
    // metode lauj parslegties no ui ainas uz sakumu
    public void uzSakumu()
    {
        SceneManager.LoadScene("Sakums", LoadSceneMode.Single);
    }
    // metode aizvert programmu

    public void Apturet()
    {
        Application.Quit();
    }

    public void uzUI()
    {
        SceneManager.LoadScene("UI elementi", LoadSceneMode.Single);
    }
}
