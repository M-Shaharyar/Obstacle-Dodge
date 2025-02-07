using Unity.VisualScripting;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] int timer = 3;
    Rigidbody myRegidbody;
    MeshRenderer myMeshRenderer;
    void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
        myRegidbody = GetComponent<Rigidbody>();
        myMeshRenderer.enabled = false;
        myRegidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timer){
            myMeshRenderer.enabled = true;
            myRegidbody.useGravity = true;
        }
    }
}
