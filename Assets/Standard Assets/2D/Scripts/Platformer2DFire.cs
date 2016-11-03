using UnityEngine;
using System.Collections;

public class Platformer2DFire : MonoBehaviour {
	public Transform fireSpawnPosition;
	public Platform2DProjectile m_BulletPrefab;
	public Platform2dSFX m_sfx;
	// Use this for initialization
	public void Fire(bool fire, bool flipped)
	{
		if(fire && m_BulletPrefab != null)
		{
			Quaternion rot = m_BulletPrefab.transform.rotation;
			if(flipped)
			{
	            rot = Quaternion.Euler(0,0,90);
			}
			Platform2DProjectile proj = Instantiate(m_BulletPrefab, fireSpawnPosition.position, rot) as Platform2DProjectile;
			
			proj.SetDirection(transform.right * (flipped? -1.0f : 1.0f));
			if(m_sfx != null)
			{
				m_sfx.PlayShootSFX();
			}
		}
	}
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
