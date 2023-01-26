using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarControl : MonoBehaviour
{
    public float speed;
    public float trunSpeed;
    public string nextScene;

    // Update is called once per frame
    void Update()
    {
        float moveVertical = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        this.transform.Translate(0, 0, moveVertical);

        float moveHorizontal = Input.GetAxis("Horizontal") * trunSpeed * Time.deltaTime;
        this.transform.Rotate(0, moveHorizontal, 0);

    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "FinishFloor")
        {
            SceneManager.LoadScene(nextScene);
        }
    }
}
