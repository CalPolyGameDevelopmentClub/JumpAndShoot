using UnityEngine;
using System.Collections;

public class Platform2DProjectile : MonoBehaviour {
	public float m_velocity;
	public float lifeTime;
	private Vector3 m_direction;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		lifeTime--;
		if(lifeTime < 0)
		{
			Destroy(gameObject);
		}
		transform.Translate(m_velocity * m_direction * Time.deltaTime,Space.World);

	}

	public void SetDirection(Vector3 dir)
	{
		m_direction = dir;
	}


}
