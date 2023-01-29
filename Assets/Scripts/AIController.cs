using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : MonoBehaviour
{
    public float speed = 1;

    [SerializeField]
    private Transform player;
    private PlayerController playerControllerScr;
    public bool isDead;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isDead)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
            transform.LookAt(player);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 6)
        {
            GameOverPanelControl.Instance.EnablePanel(GameState.LevelFailed, 0.5f);
            //Destroy(gameObject);
            //Time.timeScale = 0;
        }
    }

}
