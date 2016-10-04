using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DontDestroy : MonoBehaviour {

    public InputField input;
    public string playerName;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void loadNextScene()
    {
        playerName = input.text;
        SceneManager.LoadScene("Main");
    }
}
