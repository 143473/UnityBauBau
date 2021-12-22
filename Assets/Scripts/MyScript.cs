using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

[Serializable]
public class MyCallback : UnityEngine.Events.UnityEvent<string> {}

[RequireComponent(typeof(CharacterController))]
public class MyScript : MonoBehaviour
{
    [SerializeField]
    protected string customText;
    [Range(0, 10)]
    [SerializeField] protected float speed;
    [Range(0, 10)]
    [SerializeField] protected float gravity;

    [SerializeField] protected MyCallback onEsc;

    protected CharacterController controller;

    // Awake is called before the start
    private void Awake()
    {
        controller = GetComponent<CharacterController>();
        //controller = FindObjectOfType<CharacterController>();
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"Hello World!{customText}");
        Debug.LogWarning($"Hello World!{customText}");
        Debug.LogError($"Hello World!{customText}");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            controller.Move(speed * transform.forward);
        }
        if (Input.GetKey(KeyCode.S))
        {
            controller.Move(-speed * transform.forward);
        }
        if (Input.GetKey(KeyCode.A))
        {
            controller.Move(-speed * transform.right);
        }
        if (Input.GetKey(KeyCode.D))
        {
            controller.Move(speed * transform.right);
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            onEsc.Invoke("Esc Pressed");
        }

        RaycastHit hit;
        if (Physics.Raycast(transform.position, -transform.up, out hit))
        {
            Debug.Log(hit.point + hit.collider.transform.name);
            Debug.DrawLine(transform.position, hit.point, Color.red);

            if ((hit.point - transform.position).magnitude > 0.5f)
            {
                Fall();
            }
        }
        else
        {
            Fall();
        }
    }

    public void Clone()
    {
        GameObject clone = Instantiate(gameObject);
        clone.transform.position = new Vector3(Random.Range(0f,8f),Random.Range(0f,1),Random.Range(0,8f));
        Destroy(clone.GetComponent<MyScript>());
        clone.GetComponent<Renderer>().material.color = Color.yellow;
        Destroy(clone.GetComponentInChildren<Camera>());
        clone.AddComponent<Rigidbody>();
    }
    void Fall()
    {
        controller.Move(-gravity * transform.up);
    }
}
