using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed = 1f;

    void Update()
    {
        {
            if (transform.position.y < -500)
            {
                string currentSceneName = SceneManager.GetActiveScene().name;
                SceneManager.LoadScene(currentSceneName);
            }
            else
            {

            }
        }
        Vector3 pos = transform.position;

        if (Input.GetKey("w") ||
            Input.GetKey(KeyCode.UpArrow))
        {
            pos.y += speed * Time.deltaTime * 3;
        }
        if (Input.GetKey("s") ||
          Input.GetKey(KeyCode.DownArrow))
        {
            pos.y -= speed * Time.deltaTime * 5/2;
        }
        if (Input.GetKey("d") ||
            Input.GetKey(KeyCode.RightArrow))
        {
            pos.x += speed * Time.deltaTime * 5/2;
        }
        if (Input.GetKey("a") ||
            Input.GetKey(KeyCode.LeftArrow))
        {
            pos.x -= speed * Time.deltaTime * 5/2;
        }

        transform.position = pos;
    }


    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Lava")
        {
            Destroy(this.gameObject);
        }
    }
}


