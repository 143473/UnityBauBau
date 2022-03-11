using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] protected Canvas options;
    // Start is called before the first frame update
    void Awake()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void GoOptions()
    {
        GetComponent<Canvas>().enabled = false;
        options.enabled = true;
    }

    public void BackToMenu()
    {
        options.enabled = false;
        GetComponent<Canvas>().enabled = enabled;
    }
}
