using UnityEngine;

namespace DefaultNamespace
{
    public class Bird: MonoBehaviour
    {
        [Range(0, 20)]
        [SerializeField] protected float speed = 1;
        [Range(0, 5)]
        [SerializeField] protected float gravity = 1;
        [SerializeField]protected GameManager gameManager;

        private Rigidbody rb;
        
        
        private void Start()
        {
            Physics.gravity = new Vector3(0, -9.81f * gravity, 0);
            rb = GetComponent<Rigidbody>();
            //Physics.gravity *= gravity;
            rb.useGravity = true;
        }

        private void Update()
        {
            //rb.AddForce(Physics.gravity);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.velocity = Vector3.up * speed;
                //rb.AddForce(transform.up*speed,ForceMode.Impulse);
            }
        }

        private void OnCollisionEnter(Collision pipe)
        {
            gameManager.GameOver();
        }
    }
}