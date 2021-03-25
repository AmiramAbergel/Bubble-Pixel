using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class watchAd : MonoBehaviour
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
/*        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.GetComponent<BoxCollider>() != null)
                {
                    Destroy(hit.collider.GetComponent<BoxCollider>());
                }
            }
        }*/
    }

    private void OnMouseDown()
    {
        // Object.Destroy(spriteRenderer);
        // Object.Destroy(BoxCollider2D);
        transform.parent.gameObject.SetActive(false);
        GameManager.instance.DestroyFiftyPrecentPrefabsInScene("Bubble");
       // Destroy(gameObject.GetComponent<BoxCollider>());

    }
}
