using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scoreShow : MonoBehaviour
{
    private Text scored;
    public Text hiScore;

    // Start is called before the first frame update
    void Start()
    {
        scored = GameObject.Find("Scored").GetComponent<Text>();
        hiScore = GameObject.Find("HiScore").GetComponent<Text>();
        scored.text = "You Scored: ";
        hiScore.text = "Hi-Score: ";
    }

    // Update is called once per frame
    void Update()
    {
        scored.text = "You Scored: " + PlayerPrefs.GetInt("Score").ToString();
        if(PlayerPrefs.GetInt("hi") < PlayerPrefs.GetInt("Score"))
        {
            PlayerPrefs.SetInt("hi", PlayerPrefs.GetInt("Score"));
        }
        hiScore.text = "Hi-Score: " + PlayerPrefs.GetInt("hi").ToString();
        if (Input.GetKey("space") == true)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
