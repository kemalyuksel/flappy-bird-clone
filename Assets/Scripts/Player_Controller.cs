using UnityEngine;

public class Player_Controller : MonoBehaviour
{

    [SerializeField]
    [Range(1, 20)]
    public float jumpForce;

    public Rigidbody2D playerRb;

    public GameObject deathScreen;

    public AudioClip pointSound;
    public AudioClip deathSound;

    private GameManager gameManager;
    private AudioSource audioSource;


    void Start()
    {
        Time.timeScale = 1;
        gameManager = GameObject.FindObjectOfType<GameManager>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            playerRb.velocity = Vector2.up * jumpForce;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        string tag = other.gameObject.tag.ToString();

        if (tag == "Ground" || tag == "Pipe")
        {
            audioSource.clip = deathSound;
            audioSource.Play();
            deathScreen.SetActive(true);
            Time.timeScale = 0;
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        string tag = other.gameObject.tag.ToString();

        if (tag == "ScoreTrigger")
        {
            audioSource.clip = pointSound;
            audioSource.Play();
            gameManager.GameScore(1);
        }

    }



}
