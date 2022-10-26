using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public GameObject PlayerFx;
    public GameObject EnemyFx;
    
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.CompareTag("player"))
        {
            Instantiate(PlayerFx, other.transform.position, PlayerFx.transform.rotation);
            Destroy(other.gameObject);
        }
    }
   
}
