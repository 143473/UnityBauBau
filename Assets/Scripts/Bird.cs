using UnityEngine;

namespace DefaultNamespace
{
    public class Bird: MonoBehaviour
    {
        [Range(0, 20)]
        [SerializeField] protected float speed = 5;
        [Range(0, 5)]
        [SerializeField] protected float gravity = 2;
        [SerializeField]protected GameManager gameManager;
        
        protected Rigidbody rb;
        

        private void Start()
        {
            rb = GetComponent<Rigidbody>();
            
        }

        private void Update()
        {
            rb.AddForce(Physics.gravity * gravity);
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