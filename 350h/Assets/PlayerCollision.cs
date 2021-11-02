
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public playermovement movement;
    void OnCollisionEnter(Collision collisionInfo)
    {
       // Debug.Log(collisionInfo.collider.name);
        if (collisionInfo.collider.tag == "Obstcle") {
        //    Debug.Log(" we hit Obstcle");
            movement.enabled = false;
        }
    }
}
