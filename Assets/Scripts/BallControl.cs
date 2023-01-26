using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallControl : MonoBehaviour
{
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "Floor")
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            else if (collision.gameObject.tag == "Obstacle")
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            else if (collision.gameObject.tag == "Wall")
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        
        }
}
