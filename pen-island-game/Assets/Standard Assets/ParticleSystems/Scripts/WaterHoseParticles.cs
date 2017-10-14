using System;
using System.Collections.Generic;
using UnityEngine;

namespace UnityStandardAssets.Effects
{
    public class WaterHoseParticles : MonoBehaviour
    {
        public static float lastSoundTime;
        public float force = 1;


        private ParticleCollisionEvent[] m_CollisionEvents = new ParticleCollisionEvent[16];
        private ParticleSystem m_ParticleSystem;

        List<ParticleCollisionEvent> collisionEvents;


        private void Start()
        {
            m_ParticleSystem = GetComponent<ParticleSystem>();
        }


        private void OnParticleCollision(GameObject other)
        {
            int safeLength = m_ParticleSystem.GetSafeCollisionEventSize();

            if (m_CollisionEvents.Length < safeLength)
            {
                m_CollisionEvents = new ParticleCollisionEvent[safeLength];
            }

            int numCollisionEvents = m_ParticleSystem.GetCollisionEvents(other, collisionEvents);
            int i = 0;

            while (i < numCollisionEvents)
            {
                if (Time.time > lastSoundTime + 0.2f)
                {
                    lastSoundTime = Time.time;
                }

                var col = m_CollisionEvents[i].colliderComponent;

                if (col.GetComponent<Rigidbody>() != null)
                {
                    Vector3 vel = m_CollisionEvents[i].velocity;
                    col.GetComponent<Rigidbody>().AddForce(vel*force, ForceMode.Impulse);
                }

                other.BroadcastMessage("Extinguish", SendMessageOptions.DontRequireReceiver);

                i++;
            }
        }
    }
}
