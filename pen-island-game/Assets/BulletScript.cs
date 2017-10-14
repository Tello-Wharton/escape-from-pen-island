using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision collision)
    {

        foreach (ContactPoint contact in collision.contacts)
        {
            Debug.DrawRay(contact.point, contact.normal, Color.white);

            var cake = contact.otherCollider;



            if (cake.GetComponent(typeof(IKillable)) != null)
            {
                print("Working??");

                IKillable component = cake.GetComponent(typeof(IKillable)) as IKillable;
                component.Shot();

                Destroy(collision.gameObject);
            }

        }

        print("cake");


       if(collision.gameObject.GetComponent(typeof(IKillable)) != null)
        {
            print("Working??");

            IKillable component = collision.gameObject.GetComponent(typeof(IKillable)) as IKillable;
            component.Shot();

            Destroy(collision.gameObject);
        }
     

        
    }

    void OnTriggerEnter(Collider collider)
    {
        print("YAYAYAYYAY");
        
        

        //Destroy(collider.gameObject);

        if (collider.gameObject.GetComponent<CalculatorScript>() != null)
        {
            print("Working??");

            IKillable component = collider.gameObject.GetComponent(typeof(IKillable)) as IKillable;
            component.Shot();

            
        }
    }

}
