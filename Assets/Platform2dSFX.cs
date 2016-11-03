using UnityEngine;
using System.Collections;

public class Platform2dSFX : MonoBehaviour {
	public AudioClip sfx_Jump;
	public AudioClip sfx_Shoot;
	private AudioSource source;

	// Use this for initialization
	void Start () {
		source = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void PlayJumpSFX()
	{

		source.PlayOneShot(sfx_Jump,1);
	}
	public void PlayShootSFX()
	{
		source.PlayOneShot(sfx_Shoot,1);

	}
}
