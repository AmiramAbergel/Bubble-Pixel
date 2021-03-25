using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioClip[] bubblePoppingSounds;
  

	private void MakeSound(AudioClip originalClip)
	{
		// As it is not 3D audio clip, position doesn't matter.

		AudioSource.PlayClipAtPoint(originalClip, transform.position);
	}

	public void MakeBubblePoppingSound()
	{
		MakeSound(bubblePoppingSounds[Random.Range(0,bubblePoppingSounds.Length-1)]);
	}
}
