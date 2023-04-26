using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    internal IEnumerator Die()
    {
        Invoke("reboot", 1);
        yield return null;
        
    }

    private void reboot()
    {
        string currentScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentScene);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
