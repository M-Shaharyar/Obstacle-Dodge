using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float moveSpeed = 0.05f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void Update()
    { 
        MovePlayer();
    }

    void MovePlayer(){
        float xValue = Input.GetAxis("Horizontal")* Time.deltaTime* moveSpeed;
        float yValue = 0f;
        float zValue =Input.GetAxis("Vertical")* Time.deltaTime * moveSpeed;
        transform.Translate(xValue ,yValue,zValue);
    }
}
