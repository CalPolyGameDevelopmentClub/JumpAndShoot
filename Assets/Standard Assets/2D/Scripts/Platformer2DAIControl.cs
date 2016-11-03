using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets._2D
{
    [RequireComponent(typeof (PlatformerCharacter2D))]
    public class Platformer2DAIControl : MonoBehaviour
    {
     
        private PlatformerCharacter2D m_Character;
        public float speed;
        private Transform m_InFrontOfCheck;
        private float k_FrontRadius = 0.02f;
        private bool isRunningLeft;
        private void Awake()
        {
            m_Character = GetComponent<PlatformerCharacter2D>();
            m_InFrontOfCheck =  transform.Find("InFrontOfCheck");
           
            
        }


        private void Update()
        {
            CheckIfShouldTurnAround();


        }


        private void FixedUpdate()
        {
            // Read the inputs.
            float h = speed*(isRunningLeft?-1.0f: 1.0f);
            // Pass all parameters to the character control script.
            m_Character.Move(h, false, false);
            
        }

        private void CheckIfShouldTurnAround()
        {
            Collider2D[] colliders = Physics2D.OverlapCircleAll(m_InFrontOfCheck.position, k_FrontRadius);
            for (int i = 0; i < colliders.Length; i++)
            {
                if (colliders[i].gameObject != gameObject)
                {
                    isRunningLeft = !isRunningLeft;
                    break;                    
                }

            }
        }
    }
}
