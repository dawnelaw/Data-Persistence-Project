using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuUIHandler : MonoBehaviour
{
  //  private string stringPlayerName;
    public TMP_InputField tmpPlayerName;


   // public static MenuUIHandler Instance;
    public static string playerName;

/*    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        // end of new code

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }*/

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void StartNew()
    {
        playerName = tmpPlayerName.text;

        Debug.Log("player name is" + playerName);
        SceneManager.LoadScene(1);
    }
}
