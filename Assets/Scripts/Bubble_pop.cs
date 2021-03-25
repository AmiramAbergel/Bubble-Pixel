using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble_pop : MonoBehaviour
{
    public Sprite[] PoppedBubbles;
    public Sound sound;
    private SpriteRenderer spriteRenderer;
    private bool Popped = false;

    

    void Start() 
	{
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void OnMouseDown()
    {
       
        if (Popped == false)
        {
            sound.MakeBubblePoppingSound();
            spriteRenderer.sprite = PoppedBubbles[Random.Range(0, PoppedBubbles.Length - 1)];
            Object.Destroy(spriteRenderer, 0.3f);
            Popped = true;
            GameManager.instance.bubble_p();       
        }
    }
}
