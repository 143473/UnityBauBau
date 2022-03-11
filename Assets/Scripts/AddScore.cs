using UnityEngine;

public class AddScore : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Score.score++;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
