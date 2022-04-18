using UnityEngine;

public class Pipe_Controller : MonoBehaviour
{

    [SerializeField]
    [Range(0,5)]
    public float speed;

    [SerializeField]
    [Range(0,5)]
    public float lifeTime;


    void Start()
    {

    }


    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        Destroy(gameObject, lifeTime);
    }


}
