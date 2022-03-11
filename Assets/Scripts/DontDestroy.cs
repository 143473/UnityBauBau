using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class DontDestroy : MonoBehaviour
{
    private EventSystem current;
    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(0))
        {
            DontDestroyOnLoad(EventSystem.current);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
