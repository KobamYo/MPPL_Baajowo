using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Notifications.Android;

public class Notif : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AndroidNotificationCenter.CancelAllDisplayedNotifications();

        var channel = new AndroidNotificationChannel()
        {
            Id = "channel_id",
            Name = "Default_Channel",
            Importance = Importance.Default,
            Description = "Generic notifications",
        };
        AndroidNotificationCenter.RegisterNotificationChannel(channel);

        var notification = new AndroidNotification();
        notification.Title = "Sugeng Enjing";
        notification.Text = "Piye kabare, aja lali sinau Basa Jawane. Langsung ae bukak TTS Baajowo";
        notification.FireTime = System.DateTime.Now.AddSeconds(10);

        var id = AndroidNotificationCenter.SendNotification(notification, "channel_id");

        if(AndroidNotificationCenter.CheckScheduledNotificationStatus(id) == NotificationStatus.Scheduled)
        {
            AndroidNotificationCenter.CancelAllNotifications();
            AndroidNotificationCenter.SendNotification(notification, "channel_id");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
