using UnityEngine;

public class ObjectHit : MonoBehaviour
{
   private void OnCollisionEnter(Collision other)
   {
      if (other.gameObject.tag == "Player")
      {
         Material copy = new Material(Shader.Find("Universal Render Pipeline/Lit"));
         copy.color = Color.gray;
         GetComponent<MeshRenderer>().material = copy;
         gameObject.tag = "Hit";
      }

   }
}
