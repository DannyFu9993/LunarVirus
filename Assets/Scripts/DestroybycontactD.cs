using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< HEAD
<<<<<<< HEAD
public class DestroybycontactP : MonoBehaviour {
=======
public class DestroybycontactD : MonoBehaviour {
>>>>>>> Added sawblades, page 1 and 2, alien transparency, animation, nonworking script
=======
public class DestroybycontactD : MonoBehaviour {
>>>>>>> 214002f2de4f1f92954139069e30ebd2e9f6fe83

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
