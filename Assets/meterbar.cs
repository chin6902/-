using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class meterbar : MonoBehaviour
{
    private Slider slider;

    public float fillSpeed = 0.01f;
    [SerializeField] private float timer = 0;
    // Start is called before the first frame update
    private void Awake()
    {
        slider = gameObject.GetComponent<Slider>();
    }

    private void Start()
    {
        IncrementProgress(1.0f);
    }
    // Update is called once per frame
    void Update()
    {
        if(slider.value < timer)
        {
            slider.value += fillSpeed * Time.deltaTime;
        }
    }

    public void IncrementProgress(float newProgress)
    {
        timer = slider.value + newProgress;
    }
}
