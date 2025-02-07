using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float speed = 1f;
    Vector3 playerPosition; 
    private void Awake() {
        gameObject.SetActive(false);
    }
    void Start()
    {
        
        playerPosition = player.transform.position;
        
    }

    void Update()
    {
        MovetoPlayer();
        DestroyWhenReached();
        
    }

    void DestroyWhenReached(){
        if (transform.position == playerPosition){
            Destroy(gameObject);
        }
    }

    void MovetoPlayer(){
        transform.position = 
        Vector3.MoveTowards(transform.position,playerPosition,speed * Time.deltaTime);
    }
}
