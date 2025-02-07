using UnityEngine;

public class Scorer : MonoBehaviour
{
  int score = 0;
  private void OnCollisionEnter(Collision other) {
    if (other.gameObject.tag != "Hit"){
      score++;
      Debug.Log("You have bumped this many times " + score);
    }
  }
}
