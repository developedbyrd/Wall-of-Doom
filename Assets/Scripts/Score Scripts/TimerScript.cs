using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public Text timer_Text;
    public int timer_Count;

    void Start()
    {
        StartCoroutine(CountTime());
        //timer_Text = GameObject.Find("Timer").GetComponent<Text>();
        //Time.timeScale = 1f;
    }

    IEnumerator CountTime()
    {
        yield return new WaitForSeconds(1f);

        timer_Count++;

        timer_Text.text = "Timer :  " + timer_Count;

        StartCoroutine(CountTime());

    }

}
