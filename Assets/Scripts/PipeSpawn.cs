using UnityEngine;
using Random = UnityEngine.Random;

public class PipeSpawn : MonoBehaviour
{
    [SerializeField]protected float maxTime;

    private float timer = 0;

    [SerializeField]protected GameObject tubes;

    [SerializeField]protected float height;
    // Start is called before the first frame update
    void Start()
    {
        GameObject newTubes = Instantiate(tubes);
        newTubes.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime)
        {
            GameObject newTubes = Instantiate(tubes);
            newTubes.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newTubes,15);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
