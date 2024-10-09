﻿using MajdataPlay.Extensions;
using MajdataPlay.Game.Notes;
using MajdataPlay.Types;
using UnityEngine;

namespace MajdataPlay.Game
{
    public sealed class NoteEffectPool : MonoBehaviour
    {
        [SerializeField]
        GameObject tapEffectPrefab;
        [SerializeField]
        GameObject touchEffectPrefab;
        [SerializeField]
        GameObject holdEffectPrefab;

        TapEffectDisplayer[] tapJudgeEffects = new TapEffectDisplayer[8];
        TapEffectDisplayer[] touchHoldJudgeEffects = new TapEffectDisplayer[33];
        TouchEffectDisplayer[] touchJudgeEffects = new TouchEffectDisplayer[33];

        HoldEffectDisplayer[] holdEffects = new HoldEffectDisplayer[8];
        HoldEffectDisplayer[] touchHoldEffects = new HoldEffectDisplayer[33];

        void Start () 
        {
            var tapParent = transform.GetChild(0);
            var touchParent = transform.GetChild(1);
            var touchHoldParent = transform.GetChild(2);
            // Judge Effect
            for(int i = 0;i < 8;i++)
            {
                var rotation = Quaternion.Euler(0, 0, -22.5f + -45f * i);
                var obj = Instantiate(tapEffectPrefab, tapParent);
                obj.name = $"TapEffect_{i + 1}";
                obj.transform.rotation = rotation;
                var displayer = obj.GetComponent<TapEffectDisplayer>();
                displayer.DistanceRatio = GameManager.Instance.Setting.Display.OuterJudgeDistance;
                displayer.ResetAll();
                tapJudgeEffects[i] = displayer;
            }
            for(int i = 0;i < 33;i++)
            {
                var sensorPos = (SensorType)i;
                var obj = Instantiate(touchEffectPrefab, touchParent);
                var displayer = obj.GetComponent<TouchEffectDisplayer>();
                displayer.DistanceRatio= GameManager.Instance.Setting.Display.InnerJudgeDistance;
                obj.name = $"TouchEffect_{sensorPos}";
                displayer.SensorPos = sensorPos;
                displayer.ResetAll();
                touchJudgeEffects[i] = displayer;

                var obj4Hold = Instantiate(tapEffectPrefab, touchHoldParent);
                var distance = TouchBase.GetDistance(sensorPos.GetGroup());
                var position = Vector3.zero;
                position.y += distance;
                var rotation = TouchBase.GetRoation(TouchBase.GetAreaPos(sensorPos), sensorPos);
                var displayer4Hold = obj4Hold.GetComponent<TapEffectDisplayer>();
                obj4Hold.transform.rotation = rotation;
                displayer4Hold.DistanceRatio = GameManager.Instance.Setting.Display.InnerJudgeDistance;
                displayer4Hold.LocalPosition = position;
                obj4Hold.name = $"TouchHoldEffect_{sensorPos}";
                displayer4Hold.ResetAll();
                touchHoldJudgeEffects[i] = displayer4Hold;
            }
            // Hold Effect
            for (int i = 0; i < 8; i++)
            {
                var obj = Instantiate(holdEffectPrefab, tapParent);
                obj.name = $"HoldEffect_{i + 1}";
                var position = NoteDrop.GetPositionFromDistance(4.8f, i + 1);
                var displayer = obj.GetComponent<HoldEffectDisplayer>();
                displayer.Position = position;
                displayer.Reset();
                holdEffects[i] = displayer;
            }
            for (int i = 0; i < 33; i++)
            {
                var sensorPos = (SensorType)i;
                var obj = Instantiate(holdEffectPrefab, touchHoldParent);
                obj.name = $"TouchHold_HoldingEffect_{sensorPos}";
                var position = TouchBase.GetAreaPos(sensorPos);
                var displayer = obj.GetComponent<HoldEffectDisplayer>();
                displayer.Position = position;
                displayer.Reset();
                touchHoldEffects[i] = displayer;
            }
        }
        /// <summary>
        /// Tap、Hold、Star
        /// </summary>
        /// <param name="judgeResult"></param>
        /// <param name="keyIndex"></param>
        public void Play(in JudgeResult judgeResult,int keyIndex)
        {
            var effectDisplayer = tapJudgeEffects[keyIndex - 1];
            effectDisplayer.PlayEffect(judgeResult);
            effectDisplayer.PlayResult(judgeResult);
            effectDisplayer.PlayFastLate(judgeResult);
        }
        /// <summary>
        /// Touch
        /// </summary>
        /// <param name="judgeResult"></param>
        /// <param name="sensorPos"></param>
        public void Play(in JudgeResult judgeResult, SensorType sensorPos)
        {
            var effectDisplayer = touchJudgeEffects[(int)sensorPos];
            effectDisplayer.PlayEffect(judgeResult);
            effectDisplayer.PlayResult(judgeResult);
            effectDisplayer.PlayFastLate(judgeResult);
        }
        /// <summary>
        /// TouchHold
        /// </summary>
        /// <param name="judgeResult"></param>
        /// <param name="sensorPos"></param>
        public void PlayTouchHoldEffect(in JudgeResult judgeResult, SensorType sensorPos)
        {
            var effectDisplayer = touchHoldJudgeEffects[(int)sensorPos];
            effectDisplayer.PlayEffect(judgeResult);
            effectDisplayer.PlayResult(judgeResult);
            effectDisplayer.PlayFastLate(judgeResult);
        }
        public void PlayHoldEffect(in JudgeType judgeType,int keyIndex)
        {
            var displayer = holdEffects[keyIndex - 1];
            displayer.Play(judgeType);
        }
        public void PlayHoldEffect(in JudgeType judgeType, SensorType sensorPos)
        {
            var displayer = touchHoldEffects[(int)sensorPos];
            displayer.Play(judgeType);
        }
        public void ResetHoldEffect(int keyIndex)
        {
            var displayer = holdEffects[keyIndex - 1];
            displayer.Reset();
        }
        public void ResetHoldEffect(SensorType sensorPos)
        {
            var displayer = touchHoldEffects[(int)sensorPos];
            displayer.Reset();
        }
        /// <summary>
        /// Tap、Hold、Star
        /// </summary>
        /// <param name="keyIndex"></param>
        public void Reset(int keyIndex)
        {
            var effectDisplayer = tapJudgeEffects[keyIndex - 1];
            effectDisplayer.Reset();
        }
    }
}