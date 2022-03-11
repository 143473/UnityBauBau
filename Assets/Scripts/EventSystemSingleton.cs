using UnityEngine;

public class EventSystemSingleton: MonoBehaviour
{
    private static EventSystemSingleton instance;

    public static EventSystemSingleton Instance
    {
        get { return instance; }
        //set { instance = value; }
    }

    void Awake()
    {
        EventSystemSingleton[] behaviours = FindObjectsOfType<EventSystemSingleton>();
        if (behaviours.Length > 1)
        {
            DestroyImmediate(gameObject);
        }
        else
        {
            instance = this;
        }
    }
}
