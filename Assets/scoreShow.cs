using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scoreShow : MonoBehaviour
{
    private Text scored;
    public int s;

    // Start is called before the first frame update
    void Start()
    {
        scored = GameObject.Find("Scored").GetComponent<Text>();
        s = PlayerPrefs.GetInt("Score");
        scored.text = "You Scored: ";
    }

    // Update is called once per frame
    void Update()
    {
        scored.text = "You Scored: " + s.ToString();
        if (Input.GetKey("space") == true)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
