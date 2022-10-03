using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTime : MonoBehaviour
{

    [SerializeField]
    int hour;

    [SerializeField]
    int minute;

    [SerializeField]
    int second;

    [SerializeField]
    GameObject hourHand;

    [SerializeField]
    GameObject minuteHand;

    [SerializeField]
    GameObject secondHand;

    // Start is called before the first frame update
    void Start()
    {
        var normalizedHour = hour % 12;
        var normalizedMinute = minute % 60;
        var normalizedSeconds = second % 60;

        hourHand.transform.localRotation = Quaternion.Euler(new Vector3(90 + 30 * (normalizedHour + normalizedMinute / 60f), 0, -90));
        minuteHand.transform.localRotation = Quaternion.Euler(new Vector3(90 + 6 * (normalizedMinute + normalizedSeconds / 60f), 0, -90));
        secondHand.transform.localRotation = Quaternion.Euler(new Vector3(90 + 6 * normalizedSeconds, 0, -90));

        //hourHand.transform.Rotate(90 + 30 * (normalizedHour + normalizedMinute / 60f), 0, -90);
        //minuteHand.transform.Rotate(90 + 6 * (normalizedMinute + normalizedSeconds / 60f), 0, -90);
        //secondHand.transform.Rotate(90 + 6 * normalizedSeconds, 0, -90);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
