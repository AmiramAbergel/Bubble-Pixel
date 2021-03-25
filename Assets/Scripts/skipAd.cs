using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skipAd : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private BoxCollider2D BoxCollider2D;


    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        BoxCollider2D = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        // Object.Destroy(spriteRenderer);
        // Object.Destroy(BoxCollider2D);
       transform.parent.gameObject.SetActive(false);
        
        // GameManager.instance.destroyFiftyPrecent();
    }
}
