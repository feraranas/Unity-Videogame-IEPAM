using UnityEngine;
 
public class FollowPlayerCamera : MonoBehaviour
{

    // Referencia al objecto
    public Transform player;

    // Generamos un offset con Vector3 (guarda 3 floats)
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        // To display the position of a object
        // Debug.Log(player.position);
        
        // Non capitalized t we refer to the position of the object that
        // this script is sitting in
        transform.position = player.position + offset; 
    }
}
