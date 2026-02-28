using UnityEngine;

public class circleWalk : MonoBehaviour
{
    public CharacterController controller;
    public float movespeed = 1f;
    public float angle = 25f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, angle * Time.deltaTime);
        controller.Move(transform.forward * movespeed *  Time.deltaTime);
    }
}
