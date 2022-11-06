using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bullet : MonoBehaviour
{
    public float speed = 30f;
    private Rigidbody rb;
    public string nextScene;

    void Start()
    {
        // 往前飛
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * speed;
    }

    void Update()
    {
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            gamescore.score += 1;
            other.gameObject.SetActive(false);
            Destroy(other.gameObject);

            GameObject[] objs = GameObject.FindGameObjectsWithTag("Enemy");

            if (gamescore.score == 4)
            {
                SceneManager.LoadScene(nextScene);
            }
        }
        if(other.gameObject.tag == "target")
        {
            gamescore.score = 0;
            SceneManager.LoadScene(0);
        }
    }
}
