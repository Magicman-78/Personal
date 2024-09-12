using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; 
    public float speed;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, target.position, Time.deltaTime * speed) + offset; 
    }
}
