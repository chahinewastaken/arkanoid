using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ball : MonoBehaviour
{
    private float speed = 6.0f;
    private int score;
    public Text scoreUI;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
    }
    float hitfactor(Vector2 ballPos, Vector2 racketPos,float racketWidth) {
        return (ballPos.x - racketPos.x) / racketWidth;
    }
  private  void OnCollisionEnter2D(Collision2D col) {
            //hit the racket?
            if (col.gameObject.name == "Player") {
                //calculate hit factory
                float x = hitfactor(transform.position,
                                  col.transform.position,
                                   col.collider.bounds.size.x);
                Vector2 dir = new Vector2(x, 1).normalized;
                GetComponent<Rigidbody2D>().velocity = dir * speed;
        }

        if (col.gameObject.tag == "block")
        {
            score++;
            scoreUI.text = score.ToString();
        }
        if (col.gameObject.name == "blocker")
        {
            //  transform.position = new Vector3(0, (float)-0.95, 0);
            SceneManager.LoadScene("SampleScene");

        }
    }
}
