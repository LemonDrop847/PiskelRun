using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int oranges = 0;
    [SerializeField] private Text orangesCounter; 
    [SerializeField] private AudioSource collectionSound;   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Orange"))
        {
            collectionSound.Play();
            Destroy(collision.gameObject);
            oranges++;
            orangesCounter.text = "Oranges : " + oranges ;
            
        }   
    }
}
