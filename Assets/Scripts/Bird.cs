using UnityEngine;

namespace DefaultNamespace
{
    public class Bird: MonoBehaviour
    {
        [Range(0, 20)]
        [SerializeField] protected float speed;
        [Range(0, 5)]
        [SerializeField] protected float gravity;
        [SerializeField]protected GameManager gameManager;
        
        protected Rigidbody rb;
        

        private void Start()
        {
            rb = GetComponent<Rigidbody>();
            Physics.gravity *= gravity;
        }

        private void Update()
        {
            rb.AddForce(Physics.gravity);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.velocity = Vector3.up * speed;
            }
        }

        private void OnCollisionEnter(Collision pipe)
        {
            gameManager.GameOver();
        }
    }
}