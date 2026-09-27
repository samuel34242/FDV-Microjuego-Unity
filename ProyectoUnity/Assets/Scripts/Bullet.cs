using UnityEngine;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{

    public float speed = 10f;
    public float maxLifeTime = 3f;
    public Vector3 targetVector;

    void Start()
    {
        
        Destroy(gameObject, maxLifeTime);

    }

    void Update()
    {
        transform.Translate(translation:speed * targetVector * Time.deltaTime);
    }


    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Enemy"))
        {
            IncreaseScore();
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

    }

    private void IncreaseScore()
    {
        Player.SCORE++;
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        GameObject go = GameObject.FindGameObjectWithTag("Ui");
        go.GetComponent<Text>().text = "Puntos : " + Player.SCORE;
    }

}
