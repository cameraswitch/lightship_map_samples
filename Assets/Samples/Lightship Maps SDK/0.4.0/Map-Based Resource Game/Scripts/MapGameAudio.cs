using System;
using System.Collections.Generic;
using UnityEngine;

namespace Niantic.Lightship.Maps.Samples.GameSample
{
    /// <summary>
    ///
    /// </summary>
    internal class MapGameAudio : MonoBehaviour
    {
        [SerializeField]
        private AudioSource audioSource;

        [SerializeField]
        private AudioClip[] audioClipArray;

        private readonly Dictionary<MapGameState.ResourceType, AudioClip> _clipMap = new();

        private void Awake()
        {
            _clipMap[MapGameState.ResourceType.Wood] = audioClipArray[0];
            _clipMap[MapGameState.ResourceType.Stone] = audioClipArray[1];
            _clipMap[MapGameState.ResourceType.Ducks] = audioClipArray[2];
        }

        private void Start()
        {
            var clipIndex = UnityEngine.Random.Range(0, 3);
            audioSource.clip = audioClipArray[clipIndex];
            audioSource.Play(0);
        }

        public void play(MapGameState.ResourceType resourceType) {
            audioSource.clip = _clipMap[resourceType];
            audioSource.Play(0);
        }
    }
}