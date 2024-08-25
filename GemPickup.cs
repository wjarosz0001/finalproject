using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemPickup : MonoBehaviour
{
    [SerializeField] AudioClip gemPickupSFX;
    
    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Player")
        {
            AudioSource.PlayClipAtPoint(gemPickupSFX, Camera.main.transform.position);
            Destroy(gameObject);
            Score.instance.AddPoint();
        }
    }

}
