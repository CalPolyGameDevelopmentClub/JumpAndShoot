using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets._2D
{
    [RequireComponent(typeof (PlatformerCharacter2D))]
    public class Platformer2DUserControl : MonoBehaviour
    {
     
        private PlatformerCharacter2D m_Character;
        private Platformer2DFire m_FireComponent;
        private bool m_Jump;
        private bool m_Fire;
        
        private void Awake()
        {
            m_Character = GetComponent<PlatformerCharacter2D>();
            m_FireComponent = GetComponent<Platformer2DFire>();
            
        }


        private void Update()
        {
            if (!m_Jump)
            {
                // Read the jump input in Update so button presses aren't missed.
                m_Jump = CrossPlatformInputManager.GetButtonDown("Jump");
            }
            if(!m_Fire)
            {
                m_Fire = CrossPlatformInputManager.GetButtonDown("Fire1");
               
            }


        }


        private void FixedUpdate()
        {
            // Read the inputs.
            bool crouch = Input.GetKey(KeyCode.LeftControl);
            float h = CrossPlatformInputManager.GetAxis("Horizontal");
            m_FireComponent.Fire(m_Fire,!m_Character.GetFacingRight());
            // Pass all parameters to the character control script.
            m_Character.Move(h, crouch, m_Jump);
            m_Jump = false;
            m_Fire = false;
           
        }
    }
}
