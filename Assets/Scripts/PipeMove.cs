using UnityEngine;

namespace DefaultNamespace
{
    public class PipeMove: MonoBehaviour
    {
        [SerializeField]protected float speed;

        void Start()
        {
           
        }

        private void Update()
        {
            transform.position += Vector3.back * speed * Time.deltaTime;
        }
    }
}