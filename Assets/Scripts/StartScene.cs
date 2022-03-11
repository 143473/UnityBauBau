using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Load a specific scene only at the first launch of the game
        
        if(PlayerPrefs.GetInt("FirstLaunch") == 0)
        {
            //First launch
            PlayerPrefs.SetInt("FirstLaunch", 1);
            SceneManager.LoadScene(1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
