using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< HEAD
public class DestroybycontactP : MonoBehaviour {
=======
public class DestroybycontactD : MonoBehaviour {
>>>>>>> Added sawblades, page 1 and 2, alien transparency, animation, nonworking script

    void OnTriggerEnter2D(Collider2D other)
    {
        // Ignore the boundary collider
        if (other.tag == "Boundary")
        {
            Debug.Log(other.gameObject.name + " Check");
            return;
        }


        // Create the asteroid explosion

        Destroy(other.gameObject);
        Destroy(this.gameObject);
    }
}
