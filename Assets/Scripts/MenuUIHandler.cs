using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuUIHandler : MonoBehaviour
{
    private string stringPlayerName;
    public TMP_InputField tmpPlayerName;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void StartNew()
    {
        stringPlayerName = tmpPlayerName.text;
        Debug.Log("player name is" + stringPlayerName);
        SceneManager.LoadScene(1);
    }
}
