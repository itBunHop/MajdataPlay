using MajdataPlay.Types;
using MajdataPlay.Utils;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace MajdataPlay.IO
{
#nullable enable
    public class Sensor : MonoBehaviour, IEventPublisher<EventHandler<InputEventArgs>>
    {
        public bool IsJudging { get; set; } = false;
        private bool IsDebug = false;
        private Image image;
        public SensorStatus Status = SensorStatus.Off;
        public SensorType Type;
        public SensorGroup Group
        {
            get
            {
                var i = (int)Type;
                if (i <= 7)
                    return SensorGroup.A;
                else if (i <= 15)
                    return SensorGroup.B;
                else if (i <= 16)
                    return SensorGroup.C;
                else if (i <= 24)
                    return SensorGroup.D;
                else
                    return SensorGroup.E;
            }
        }

        event EventHandler<InputEventArgs>? OnStatusChanged;//oStatus nStatus
        public void AddSubscriber(EventHandler<InputEventArgs> handler)
        {
            OnStatusChanged += handler;
        }
        public void RemoveSubscriber(EventHandler<InputEventArgs> handler)
        {
            if(OnStatusChanged is not null)
                OnStatusChanged -= handler;
        }
        public void PushEvent(in InputEventArgs args)
        {
            if (OnStatusChanged is not null)
                OnStatusChanged(this, args);
        }
        public void ClearSubscriber() => OnStatusChanged = null;
        void Start()
        {
            IsDebug = MajInstances.Setting.Debug.DisplaySensor;
            image = GetComponent<Image>();
            if (!IsDebug)
            {
                Destroy(image);
            }
        }
        private void Update()
        {
            if (IsDebug)
            {
                image.color = Status == SensorStatus.On ? new Color(0, 0, 0, 0.3f) : new Color(0, 0, 0, 0f);
            }
        }
    }
}